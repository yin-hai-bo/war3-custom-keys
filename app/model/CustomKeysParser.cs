using System.Text.RegularExpressions;

namespace yhb_war3_custom_keys.model {
    public class CustomKeysParser {

        private readonly Regex REGEX_SECTION_NAME = new(
            @"^\s*\[\s*(\w+)\s*\]\s*$",
            RegexOptions.Compiled | RegexOptions.Singleline);

        public class Exception : IOException {
            public Exception(int lineNumber, string msg)
                : base($"{Resources.S_LINE} {lineNumber}: {msg}") { }
        }

        public bool IsEmptyOrCommentLine(string trimedLine) {
            return trimedLine.Length == 0 || trimedLine.StartsWith("//");
        }

        public string? GetSectionName(string line) {
            var match = REGEX_SECTION_NAME.Match(line);
            if (match.Success) {
                return match.Groups[1].Value;
            }
            return null;
        }
    }
}
