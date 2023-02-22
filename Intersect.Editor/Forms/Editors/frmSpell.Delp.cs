using System;
using Intersect.Editor.Localization;

namespace Intersect.Editor.Forms.Editors
{
    public partial class FrmSpell
    {
        private void ExtraLocalization()
        {
            chkIgnoreCancelOnMove.Text = Strings.SpellEditor.IgnoreCancelOnMove;
        }

        private void ExtraUpdate()
        {
            chkIgnoreCancelOnMove.Checked = mEditorItem.IgnoreCancelOnMoving;
        }

        private void chkIgnoreCancelOnMove_CheckedChanged(object sender, EventArgs e)
        {
            mEditorItem.IgnoreCancelOnMoving = chkIgnoreCancelOnMove.Checked;
        }
    }
}
