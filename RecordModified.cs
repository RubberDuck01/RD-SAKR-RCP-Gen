using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDRCPGen {
    public class RecordModified : Record {
        // list with keywords to apply:
        public List<string> Keywords {  get; set; }

        public RecordModified() { 
            PluginName = string.Empty;
            FormID = string.Empty;
            Item = string.Empty;
            Keywords = new List<string>();
        }

        public RecordModified(Record noKw) {
            PluginName = noKw.PluginName;
            FormID = noKw.FormID;
            Item = noKw.Item;
            Keywords = new List<string>();
        }

        public RecordModified(string pluginName, string formID, string item) : base(pluginName, formID, item) {
            Keywords = new List<string>();
        }

        public string ToListBoxHuman() {
            return $"[{PluginName}:{FormID}] {Item}";
        }
    }
}
