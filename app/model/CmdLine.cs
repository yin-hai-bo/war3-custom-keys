
using yhb_war3_custom_keys.res;

namespace yhb_war3_custom_keys.model {
    public class CmdLine {

        public class Exception : System.Exception {
            private static readonly string FIXED_MSG = Resources.S_INVALID_CMDLINE;
            public Exception(string msg)
                : base($"{FIXED_MSG}: {msg}") { }
        }

        public bool IsValid { get; private set; }

        private readonly List<string> _files = new();
        public IEnumerable<string> Files => _files;

        public void Parse(string[] args) {
            for (int i = 1, len = args.Length; i < len; ++i) {
                var arg = args[i];
                switch (arg) {
                case "/f":
                case "-f":
                case "--file":
                    ++i;
                    if (i < len) {
                        _files.Add(args[i]);
                    } else {
                        throw new Exception(string.Format(Resources.S_EXPECT_FILENAME_AFTER_FILE_OPTION, arg));
                    }
                    break;
                default:
                    throw new Exception(string.Format(Resources.S_UNKNOWN_OPTION, arg));
                }
            }
            IsValid = true;
        }
    }
}
