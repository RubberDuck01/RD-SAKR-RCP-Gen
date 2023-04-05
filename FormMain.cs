using System.Windows.Forms;

namespace RDRCPGen {
    public partial class FormMain : Form {
        // List of originals:
        private List<GameObject> originals = new List<GameObject>();
        private List<GameObjectModified> mods = new List<GameObjectModified>();

        public FormMain() {
            InitializeComponent();
            
            btnAddOneOrg.Enabled = false;
            btnAddAllOrg.Enabled = false;
            btnRemoveOneMod.Enabled = false;
            btnRemoveAllMod.Enabled = false;
        }

        // Load CSV:
        private void btnLoad_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog.Title = "Load CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                // Load CSV, set label display:
                string csvFilePath = openFileDialog.FileName;
                string loadedFile = Path.GetFileName(csvFilePath);
                lblLoadedFile.Text = loadedFile;

                // save read data:
                originals = GameObject.ReadCSV(csvFilePath);

                // add to listbox (lbOriginals):
                lbOriginals.Items.Clear();
                foreach (GameObject item in originals) {
                    lbOriginals.Items.Add(item.ToListBoxHuman());
                }
            }

            btnAddOneOrg.Enabled = true;
            btnAddAllOrg.Enabled = true;

            gbKWDs.Enabled = true;
        }

        // add highlighted to MODIFIED list:
        private void btnAddOneOrg_Click(object sender, EventArgs e) {
            if (lbOriginals.SelectedIndex != -1) {
                // get the selected item from lbOriginals
                GameObject selectedOriginal = originals[lbOriginals.SelectedIndex];

                // create a new GameObjectModified object from the selected item
                GameObjectModified modified = new GameObjectModified() {
                    PluginName = selectedOriginal.PluginName,
                    FormID = selectedOriginal.FormID,
                    Item = selectedOriginal.Item
                };

                // add the modified object to lbMods
                lbMods.Items.Add("*" + modified.ToListBoxHuman());

                // remove the added item from lbOriginals:
                lbOriginals.Items.Remove(selectedOriginal.ToListBoxHuman());
            }

            if (lbOriginals.Items.Count == 0) {
                btnAddOneOrg.Enabled = false;
                btnAddAllOrg.Enabled = false;
            } else {
                btnAddOneOrg.Enabled = true;
                btnAddAllOrg.Enabled = true;
            }
        }

        // remove selected back to ORIGINAL list:
        private void btnRemoveOneMod_Click(object sender, EventArgs e) {
            if (lbMods.SelectedItem != null) {
                // Get the selected item from lbMods
                var selectedItem = lbMods.SelectedItem as string;

                // Add the selected item back to lbOriginals and update its display
                lbOriginals.Items.Add(selectedItem);
                lbOriginals.Sorted = true;

                // Remove the selected item from lbMods
                lbMods.Items.Remove(selectedItem);
            }

            if (lbMods.Items.Count == 0) {
                btnRemoveOneMod.Enabled = false;
                btnRemoveAllMod.Enabled = false;
            } else {
                btnRemoveOneMod.Enabled = true;
                btnRemoveAllMod.Enabled = true;
            }
        }

        // adds everything from lbOriginals to lbMods:
        private void btnAddAllOrg_Click(object sender, EventArgs e) {
            // Disable btnAddOneOrg and btnAddAllOrg
            btnAddOneOrg.Enabled = false;
            btnAddAllOrg.Enabled = false;

            // Move all items to lbMods
            foreach (GameObject org in originals) {
                GameObjectModified mod = new GameObjectModified(org);
                mods.Add(mod);
                lbMods.Items.Add("*" + mod.ToListBoxHuman());
            }

            // Clear lbOriginals
            lbOriginals.Items.Clear();

            // enable remove buttons:
            btnRemoveOneMod.Enabled = true;
            btnRemoveAllMod.Enabled = true;
        }

        // removes everything from lbMods and returns it to lbOriginals:
        private void btnRemoveAllMod_Click(object sender, EventArgs e) {
            // Disable btnRemoveOneMod and btnRemoveAllMod
            btnRemoveOneMod.Enabled = false;
            btnRemoveAllMod.Enabled = false;

            // Move all items to lbOriginals
            foreach (GameObjectModified mod in mods) {
                GameObject org = new GameObject(mod);
                originals.Add(org);
                lbOriginals.Items.Add(org.ToListBoxHuman());
            }

            // Clear lbMods
            lbMods.Items.Clear();

            // Enable btnAddOneOrg
            btnAddOneOrg.Enabled = true;
            btnAddAllOrg.Enabled = true;
        }
    }
}