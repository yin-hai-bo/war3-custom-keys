using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yhb_war3_custom_keys.model {
    internal interface IItem {
        void Serialize(TextWriter writer);
        bool GetKeyValue(out string? key, out string? value);
    }
}
