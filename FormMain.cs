using RDRCPGen.Properties;
using System.Windows.Forms;

namespace RDRCPGen {
    public partial class FormMain : Form {
        // List of originals:
        private List<Record> originals = new List<Record>();
        // List of modified:
        private List<RecordModified> mods = new List<RecordModified>();
        // check whether lbOriginals was selected last:
        private bool lbOriginalsSelectedLast = false;

        public FormMain() {
            InitializeComponent();
            this.FormClosing += FormMain_FormClosing;
        }

        // Load CSV:
        private void btnLoad_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                openFileDialog.Title = "Load CSV";

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    // Load CSV, set label display:
                    string csvFilePath = openFileDialog.FileName;
                    string loadedFile = Path.GetFileName(csvFilePath);
                    lblLoadedFile.Text = loadedFile;
                    pbStatus.BackgroundImage = Resources.Oxygen_go48;
                    gbKWDs.Enabled = true;

                    // save read data:
                    originals = Record.ReadCSV(csvFilePath);

                    // add to listbox (lbOriginals):
                    lbOriginals.Items.Clear();
                    foreach (Record item in originals) {
                        lbOriginals.Items.Add(item.ToListBoxHuman());
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"Something went wrong:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // sets all checkboxes to unchecked:
        private void btnClear_Click(object sender, EventArgs e) {
            ClearCBstatus();
        }

        // adds selected kwds to selected object in lbMods:
        private void btnApply_Click(object sender, EventArgs e) {
            try {
                Record original = originals[lbOriginals.SelectedIndex];
                RecordModified modified = new RecordModified(original);
                RecordModified existing = mods.FirstOrDefault(m => m.FormID == original.FormID);

                // check if already exists:
                if (existing != null) {
                    var result = MessageBox.Show($"Looks like you've already added keywords to\n{existing.Item} (FormID: {existing.FormID}).\n\nDo you want to overwrite the previous record?", "RD's SAKR/RCP Gen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No) {
                        return;
                    }

                    mods.Remove(existing);
                    lbMods.Items.Remove(existing.ToListBoxHuman().ToString());
                }
                
                // add modified:
                foreach (Control ctrl in gbKWDs.Controls) {
                    if (ctrl is CheckBox cb && cb.Checked) {
                        modified.Keywords.Add(cb.Tag.ToString());
                    }
                }

                mods.Add(modified);

                lbOriginals.Items.Remove(original);
                lbMods.Items.Add(modified.ToListBoxHuman());
                pbStatus.BackgroundImage = Resources.Oxygen_ok48;

                if (!cbKeep.Checked) {
                    ClearCBstatus();
                }
                
                // auto increment:
                if (lbOriginals.Items.Count == 0) {
                    MessageBox.Show("Couldn't find any items in this CSV. Did you export the CSV properly, using 'RD_Export_FormIDs_SAKR.pas' script?\n\nTry again and if this message still shows up, report the issue immediately.\n\nThanks!", "RD's SAKR/RCPGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (lbOriginals.SelectedIndex < lbOriginals.Items.Count - 1) {
                    lbOriginals.SelectedIndex++;
                } else {
                    MessageBox.Show("Reached end of loaded CSV.", "RD's SAKR/RCPGen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            } catch (Exception ex) {
                MessageBox.Show($"Something went wrong...\n\nMore info:\n{ex.Message}", "RD's SAKR/RCPGen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pbStatus.BackgroundImage = Resources.Oxygen_notok48;
            }
        }

        // remove from modified list:
        private void btnRemove_Click(object sender, EventArgs e) {
            int selectedIndex = lbMods.SelectedIndex;
            if (selectedIndex >= 0) {
                mods.RemoveAt(selectedIndex);
                lbMods.Items.RemoveAt(selectedIndex);
            }
        }

        // clear all checkboxes (set to unchecked):
        public void ClearCBstatus() {
            foreach (var control in gbKWDs.Controls) {
                if (control is CheckBox cb) {
                    cb.Checked = false;
                }
            }
        }

        private void lbOriginals_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedStr = lbOriginals.SelectedItem as string;
            Record selected = originals.FirstOrDefault(x => x.ToListBoxHuman() == selectedStr);

            // set selected last to true:
            if (!lbOriginalsSelectedLast) {
                lbMods.ClearSelected();
                lbOriginalsSelectedLast = true;
            }

            if (selected != null) {
                lblSelectedItem.Text = $"[{selected.PluginName}] {selected.Item}";
            }

            pbStatus.BackgroundImage = Resources.Oxygen_go48;
        }

        private void lbMods_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedStr = lbMods.SelectedItem as string;
            RecordModified selected = mods.FirstOrDefault(x => x.ToListBoxHuman() == selectedStr);

            // set selected last to false:
            if (lbOriginalsSelectedLast) {
                lbOriginals.ClearSelected();
                lbOriginalsSelectedLast = false;
            }

            // check if null:
            if (selected != null) {
                lblSelectedItem.Text = $"[W] [{selected.PluginName}] {selected.Item}";

                // upon selection, check all the checkboxes with selected kwds
                foreach (Control ctrl in gbKWDs.Controls) {
                    if (ctrl is CheckBox cb) {
                        cb.Checked = false;
                    }
                }

                foreach (string kwd in selected.Keywords) {
                    foreach (Control ctrl in gbKWDs.Controls) {
                        if (ctrl is CheckBox cb && cb.Tag.ToString() == kwd) {
                            cb.Checked = true;
                        }
                    }
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e) {
            if (mods.Count > 0) {
                // Show save file dialog to get path to save the INI file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "INI Files|*.ini";
                saveFileDialog.Title = "Save INI";

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    try {
                        // Get the selected path and write to the file
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName)) {
                            sw.WriteLine("// INI automatically generated by Rubber Duck's SAKR/RCP Gen");
                            sw.WriteLine("// By RubberDuck");
                            sw.WriteLine("// RDRCPGen v0.7.4 - build 14/04/23\n");
                            // Loop through the mods list and write to the file
                            foreach (RecordModified mod in mods) {
                                // Write:
                                sw.Write($"// {mod.Item}"); // comment

                                sw.WriteLine(); // new line
                                sw.Write($"filterByArmors={mod.PluginName}|{mod.FormID}:keywordsToAdd=");

                                bool first = true;
                                foreach (string kwd in mod.Keywords) {
                                    if (!first) {
                                        sw.Write(",");
                                    }
                                    sw.Write($"SkimpyArmorKeywordResource.esm|{kwd}");
                                    first = false;
                                }

                                sw.WriteLine();
                            }
                        }

                        MessageBox.Show("INI saved successfully!", "RD's SAKR/RCPGen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch (Exception ex) {
                        MessageBox.Show($"Couldn't save to INI. More info:\n{ex.Message}", "RD's SAKR/RCPGen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else {
                MessageBox.Show("Cannot write empty INI!", "RD's SAKR/RCPGen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // set checkbox to bold if checked and back if unchecked:
        private void checkBox_CheckedChanged(object sender, EventArgs e) {
            foreach (Control ctrl in gbKWDs.Controls) {
                if (ctrl is CheckBox cb) {
                    if (cb.Checked) {
                        cb.Font = new Font(cb.Font, FontStyle.Bold);
                    } else {
                        cb.Font = new Font(cb.Font, FontStyle.Regular);
                    }
                }
            }
        }

        // close:
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Quit application? Your progress won't be saved if you didn't write the INI file.", "Quit -- RD's SAKR/RCPGen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                e.Cancel = true;
            }
        }
    }
}