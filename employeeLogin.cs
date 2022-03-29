using System;
using System.Windows.Forms;

namespace PizzaPlaceGUI
{
    public partial class customerLogin : UserControl
    {
        public customerLogin()
        {
            InitializeComponent();
            this.Visible = false;
            this.Enabled = false;
        }

        public void OpenHome()
        {
            this.Visible = true;
            this.Enabled = true;
        }

        private void LanguageButton_Click(object sender, EventArgs e)
        {
            // This is an event which will eventually be used for language support. For now, it doesn't do anything.
        }

        private void customerLogin_Load(object sender, EventArgs e)
        {

        }


        // Handles input from the text fields. If the phone number is 7 digits long, append the ATL area code to it.
        private void passwordBoxClick(object sender, EventArgs e)
        {
            string phoneNumber = phoneBox.Text;
            string pass = passBox.Text;

            if (phoneNumber.Length == 7)
            {
                pass = "678" + pass;
            }
        }

        // Creates an event to return to the home screen
        public event EventHandler returnHomeEvent;

        // Returns to home screen
        private void onHomeClick(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            returnHomeEvent?.Invoke(sender, e);
        }
    }
}
