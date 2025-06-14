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
    public partial class FormDemande : Form
    {
        public FormDemande()
        {
            InitializeComponent();
        }

        private void addContenu(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAddContenueDemandes.Controls.Clear();
            panelAddContenueDemandes.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnTousDemande_Click(object sender, EventArgs e)
        {
            TousDemandes tous = new TousDemandes();
            addContenu(tous);
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            DemandeAccepter accepte = new DemandeAccepter();
            addContenu(accepte);
        }

        private void btnEncour_Click(object sender, EventArgs e)
        {
            DemandeEnCours encour = new DemandeEnCours();
            addContenu(encour);
        }

        private void btnRefuser_Click(object sender, EventArgs e)
        {
            DemandeRefuser refuser = new DemandeRefuser();
            addContenu(refuser);
        }

        private void FormDemande_Load(object sender, EventArgs e)
        {
            TousDemandes tous = new TousDemandes();
            addContenu(tous);
        }

        private void btnVise_Click(object sender, EventArgs e)
        {
            DemandeVisé visé = new DemandeVisé();
            addContenu(visé);
        }

        private void btnDemandeSigne_Click(object sender, EventArgs e)
        {
            DemandeSigne s = new DemandeSigne();
            addContenu(s);
        }
    }
}
