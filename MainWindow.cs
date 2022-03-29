using System;
using System.Windows.Forms;
using System.Collections;
using PizzaPlaceGUI.UserControls;
using PizzaPlaceGUI.SessionManagement;


namespace PizzaPlaceGUI
{
    public partial class MainWindow : Form
    {

        // Private usercontrol classes
        private homepage home = new homepage();
        private CustomerLogin custLogin = new CustomerLogin();
        private onlineMenu pizzaMenu = new onlineMenu();
        private newCustomerSignup signupScreen = new newCustomerSignup();
        private userSession custSession = new userSession();

        // The master list of valid users. Normally this is a database, but that is
        //    outside the scope of this project. 
        static public ArrayList useList = new ArrayList();
        static public ArrayList menu = new ArrayList();


        public MainWindow()
        // Default constructor
        {
            InitializeComponent();
            // Docks the homepage
            home.Dock = DockStyle.Fill;
            custLogin.Dock = DockStyle.Fill;
            pizzaMenu.Dock = DockStyle.Fill;
            signupScreen.Dock = DockStyle.Fill;
            // On load, create an instance of mainMenu, dock it to the window, and add the control to the controls held by the form.
            this.Controls.Add(home);
            this.Controls.Add(custLogin);
            this.Controls.Add(pizzaMenu);
            this.Controls.Add(signupScreen);


            //Register events to process them
            #region eventRegistry

            // Register events which open the homepage
            pizzaMenu.returnHomeEvent += OpenHp;
            custLogin.ReturnHomeEvent += OpenHp;
            signupScreen.returnHomeEvent += OpenHp;

            // Register events which open the customer login page
            home.openLogin += OpenCl;
            signupScreen.openLogin += OpenCl;

            // Register events which open the customer signup page
            custLogin.OpenSignUp += OpenSignupPage;
            
            // Register events which open the menu
            home.openOMenu += OpenOm;

            // Register events which open the customer information/session page
            custLogin.UserLoggedIn += OpenSessionPage;
            signupScreen.accountSignupSuccessful += OpenSessionPage;
            #endregion

            // Make a dummy user for testing
            useList.Add(new User(9998887654,"kittens"));

            // Defines menu items. Several of them.
            #region menuItems



            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        // Bring the homepage to the forefront
        private void OpenHp(object sender, EventArgs e)
        {
            home.Open();
        }

        // Bring the login userControl to the forefront
        private void OpenCl(object sender, EventArgs e)
        {
            custLogin.Open();
        }

        // Bring the ordering menu usercontrol to the forefront
        private void OpenOm(object sender, EventArgs e)
        {
            pizzaMenu.Open();
        }

        private void OpenSignupPage (object sender, EventArgs e)
        {
            signupScreen.Open();
        }

        private void OpenSessionPage (object sender, EventArgs e)
        {

        }


    }
}
