using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff_Management
{
    public class BaseForm : Form
    {
        public string FORMNAME = string.Empty;
        public BaseForm():  base()
        {
            FORMNAME = this.Name;
        }
        public DialogResult DisplayMessage(string message, string title, MessageTypeEnum messageTypeEnum)
        {
            DialogResult dialogResult = DialogResult.OK;
            if (messageTypeEnum == MessageTypeEnum.ERROR)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (messageTypeEnum == MessageTypeEnum.WARNING)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (messageTypeEnum == MessageTypeEnum.INFO)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (messageTypeEnum == MessageTypeEnum.SUCCESS)
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (messageTypeEnum == MessageTypeEnum.INPUTBOX)
            {
                dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (messageTypeEnum == MessageTypeEnum.INPUTBOX_YES)
            {
                dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }
            return dialogResult;
        }
    }
}
