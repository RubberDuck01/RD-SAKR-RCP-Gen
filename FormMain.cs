namespace RDRCPGen {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
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

                // create new plugin:
                Plugin plugin = new Plugin(csvFilePath);
            }
        }
    }
}