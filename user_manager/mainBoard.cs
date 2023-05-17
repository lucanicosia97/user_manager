using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_manager
{
    public partial class mainBoard : Form
    {
        public mainBoard()
        {
            InitializeComponent();
        }

        private void userHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUser aU = new addUser();
            aU.Show();

        }

        private void mainBoard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
