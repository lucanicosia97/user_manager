using System.Xml.Serialization;
using System.Diagnostics;

namespace user_manager
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void txtVorname_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNachname_TextChanged(object sender, EventArgs e)
        {

        }
        /*
           set Display Name: "Vorname Nachname" 
           set User Logon Name: "vorname.nachname"
           set User logon name pre WIN 2000: "vorname.nachname"
           set Domain: "@simplon.com"
           set Password: "Initial01"
           set E-mail: "vorname.nachname@simplon.com"

        */

        private void txtJobtitel_TextChanged(object sender, EventArgs e)
        {
            /*    
                set Job titel
                set Description
            */
        }


        private void cboStraﬂe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboAbteilung_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*   
               set Company: SIMPLON Fahrrad GmbH
               set Department based on Manager
               
           */
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UserCredentials();
            MessageBox.Show( test(5).ToString());
        }

        private int test(int b) 
        {
            int a = 0;
            a = b + 1;
            return a;
        }

        private void UserCredentials() 
        {

        }

    }
}