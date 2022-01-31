using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Uclaray_Transport_Management_System.Classes
{
    class RegexValidation
    {
        public bool IsValid(Guna2TextBox textBox, String regex, String msg)
        {
            string inputText = textBox.Text.Trim();
            if (Regex.Match(inputText, regex).Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox.Focus();
                return false;
            }

        }
    }
}
