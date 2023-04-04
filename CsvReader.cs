using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDRCPGen {
    public class CsvReader {
        public static List<Plugin> ReadCsv(string csvFilePath) {
            List<Plugin> pluginList = new List<Plugin>();
            var csvData = File.ReadAllLines(csvFilePath);

            foreach (var line in csvData) {
                var parts = line.Split(';');
                var pluginName = parts[0];
                var formID = parts[1];
                var itemName = parts[2];
                var pluginData = pluginList.FirstOrDefault(p => p.Name == pluginName);

                if (pluginData == null) {
                    pluginData = new Plugin(pluginName);
                    pluginList.Add(pluginData);
                }

                pluginData.Items.Add(new Item { FormID = formID, ItemName = itemName });
            }
            return pluginList;
        }
    }
}
