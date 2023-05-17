using System.Xml.Serialization;
using System.Diagnostics;
using System;
using System.
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using PowerShell = System.Management.Automation.PowerShell;


namespace user_manager
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        /* Allgemeine Infos an IT:
                Telefon- oder Handynummer erstellen
                
                spezielle Gruppen hinzufügen
           
     
            UserCredentials: 
                set Full name: "Vorname Nachname"
                set Display Name: "Vorname Nachname" 
                set User Logon Name: "vorname.nachname@simplon.com"
                set User logon name pre WIN 2000: "vorname.nachname"
                set Domain: "@simplon.com"
                set Password: "Initial01"
                set E-mail: "vorname.nachname@simplon.com"

            JobTitel:
                set JobTitel
                set Description

            Straße/Addresse:
                set City, State, Zip, Country
            
            Abteilung:
                set Company: SIMPLON Fahrrad GmbH
                set Abteilung based on Manager


            Return:
                 return "Running"
                 return "Alles ok"
                 return Error

           
        */

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

    }
}