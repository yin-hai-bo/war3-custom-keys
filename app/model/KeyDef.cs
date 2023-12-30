﻿using System.Text.RegularExpressions;

namespace yhb_war3_custom_keys.model {
    internal class KeyDef {

        private readonly Regex REGEX = new(@"(\w+)\s*=(.*)", RegexOptions.Compiled | RegexOptions.Singleline);

        internal readonly string Key;
        private readonly Dictionary<string, string> _map = new();

        internal KeyDef(string key) {
            this.Key = key;
        }

        internal void LoadFromReader(TextLineReader reader, CustomKeysParser parser) {
            while (true) {
                string? line = reader.ReadLine(trim: true);
                if (line == null) {
                    break;
                }
                if (parser.IsEmptyOrCommentLine(line)) {
                    continue;
                }
                var match = REGEX.Match(line);
                if (match.Success) {
                    var key = match.Groups[0].Value;
                    var value = match.Groups[1].Value.Trim();
                    _map[key] = value;
                } else if (parser.GetSectionName(line) != null) {
                    reader.MoveBackLine(line);
                    break;
                } else {
                    throw new CustomKeysParser.Exception(reader.NextLine, Resources.S_INVALID_LINE);
                }
            }
        }
    }
}
