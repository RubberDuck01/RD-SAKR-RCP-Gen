using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDRCPGen {
    public class GameObject {
        public string PluginName { get; set; }
        public string FormID { get; set; }
        public string Item { get; set; }

        public GameObject() {
            PluginName = string.Empty;
            FormID = string.Empty;
            Item = string.Empty;
        }

        public GameObject(GameObject gameObject) {
            PluginName = gameObject.PluginName;
            FormID = gameObject.FormID;
            Item = gameObject.Item;
        }

        public static List<GameObject> ReadCSV(string csvFilePath) {
            List<GameObject> csvContent = new List<GameObject>();

            using (var reader = new StreamReader(csvFilePath)) {
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    // create new object:
                    GameObject gameObject = new GameObject();
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
