using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDRCPGen {
    public class GameObjectModified : GameObject {
        // list with keywords to apply:
        public List<string> Keywords {  get; set; }

        public GameObjectModified() { 
            Keywords = new List<string>();
        }

        public GameObjectModified(GameObject noKw) {
            PluginName = noKw.PluginName;
            FormID = noKw.FormID;
            Item = noKw.Item;
        }
    }
}
