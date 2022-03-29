using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;

namespace PizzaPlaceGUI
{
    // Provides a generic utility class to hold static methods
    internal static class Utilities
    {
        // Hashes password strings for safer storage
        static public string hashPassword(string input, string salt)
        {
            long salty = (Convert.ToInt64(salt)) % Int32.MaxValue;
            Rfc2898DeriveBytes byteDeriver = new Rfc2898DeriveBytes(input, Convert.ToInt32(salty));
            byteDeriver.IterationCount = 10;
            byte[] hash = byteDeriver.GetBytes(24);
            return Convert.ToBase64String(hash);
            
        }

        // Generates a windows forms dialog box with an error message
        static public void throwErrorForReason(string input)
        {
            Label l = new Label();
            l.Text = input;
            l.Dock = DockStyle.Fill;
            l.Font = new System.Drawing.Font("Artifakt Element", 16F, System.Drawing.FontStyle.Bold);
            l.ForeColor = Color.Black;
            Form dlg = new Form();
            dlg.Controls.Add(l);
            dlg.Text = "ERR";
            dlg.ShowDialog();
        }
    }

}
