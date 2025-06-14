using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionConger.FormulairePanel
{
    public partial class Moncompte : Form
    {
        public Moncompte()
        {
            InitializeComponent();
        }

        private void addContenu(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelParam.Controls.Clear();
            panelParam.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMdp_Click(object sender, EventArgs e)
        {
            ModifierPwd pwd = new ModifierPwd();
            addContenu(pwd);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ListePersonne p = new ListePersonne();
            addContenu(p);
        }
    }
}
