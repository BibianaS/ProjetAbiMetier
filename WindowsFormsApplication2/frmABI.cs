using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ABI
{
    public partial class frmABI : Form
    {
        public frmABI()
        {
            InitializeComponent();
            //initialisation des collaborateurs en dur
            init();
        }

        public void init()
        {
            MCollaborateur 
        }

        /// <summary>
        /// affichage des collaborateurs dans la data grid view
        /// </summary>
        public void afficherCollaborateurs()
        {
           
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
