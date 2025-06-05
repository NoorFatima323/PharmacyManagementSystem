using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
            this.Show(); // shows main menu again after admin closes

        }

        private void btnPharmacist_Click(object sender, EventArgs e)
        {
            this.Hide();
            PharmacistForm pharmacistForm = new PharmacistForm();
            pharmacistForm.ShowDialog();
            this.Show();

        }
    }
}
