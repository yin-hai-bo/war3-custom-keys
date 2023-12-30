using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yhb_war3_custom_keys.model {
    internal class CommentLine : IItem {

        private readonly string _content;

        public CommentLine(string content) {
            this._content = content;
        }

        public bool GetKeyValue(out string? key, out string? value) {
            key = null;
            value = null;
            return false;
        }

        public void Serialize(TextWriter writer) {
            writer.WriteLine(this._content);
        }
    }
}
