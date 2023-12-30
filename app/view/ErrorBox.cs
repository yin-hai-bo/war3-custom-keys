using yhb_war3_custom_keys.res;

namespace yhb_war3_custom_keys.view {
    internal class ErrorBox {
        internal static void Show(IWin32Window owner, string msg) {
            MessageBox.Show(owner, msg, Resources.S_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    internal class WarningBox {
        internal static void Show(IWin32Window owner, string msg) {
            MessageBox.Show(owner, msg, Resources.S_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

}

