using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDRCPGen {
    public class Plugin {
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        // default:
        public Plugin() {
            Name = string.Empty;
            Items = new List<Item>();
        }

        public Plugin(string name, List<Item> items) {
            Name = name;
            Items = items;
        }

        public Plugin(string csvFilePath) {
            Items = new List<Item>();

        }
    }
}
