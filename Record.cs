using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDRCPGen {
    public class Record {
        public string PluginName { get; set; }
        public string FormID { get; set; }
        public string Item { get; set; }

        public Record() {
            PluginName = string.Empty;
            FormID = string.Empty;
            Item = string.Empty;
        }

        public Record(string pluginName, string formID, string item) {
            PluginName = pluginName;
            FormID = formID;
            Item = item;
        }

        public Record(RecordModified modifiedRecord) {
            PluginName = modifiedRecord.PluginName;
            FormID = modifiedRecord.FormID;
            Item = modifiedRecord.Item;
        }

        public static List<Record> ReadCSV(string csvFilePath) {
            List<Record> csvContent = new List<Record>();

            using (var reader = new StreamReader(csvFilePath)) {
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    // create new object:
                    Record gameObject = new Record();
                    gameObject.PluginName = values[0];
                    gameObject.FormID = values[1];
                    gameObject.Item = values[2];

                    // save object to list:
                    csvContent.Add(gameObject);
                }
            }

            return csvContent;
        }

        // custom for list box showcase:
        public string ToListBoxHuman() {
            return $"[{PluginName}:{FormID}] {Item}";
        }
    }
}
