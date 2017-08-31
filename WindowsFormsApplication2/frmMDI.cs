using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Aperture de la liste de collaborateurs depuis le menu toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ouvrirToolStripButton_Click(object sender, EventArgs e)
        {
            CtrlListerCollaborateurs ctrlLstCollaborateurs = new CtrlListerCollaborateurs();
        }
    }
}
