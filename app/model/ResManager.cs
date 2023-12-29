using System.Reflection;

namespace war3_custom_keys.model {
    internal class ResManager {

        private const string RES_PREFIX = "war3_custom_keys.res.";

        public static ResManager Instance { get; private set; } = new ResManager();

        private ResManager() { }

        public Stream? LoadResourceStream(string path) {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var name = $"{RES_PREFIX}{path}";
            return assembly.GetManifestResourceStream(name);
        }
    }
}
