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
            Keywords = new List<string>();
        }

        public RecordModified(Record noKw) {
            PluginName = noKw.PluginName;
            FormID = noKw.FormID;
            Item = noKw.Item;
        }
    }
}
