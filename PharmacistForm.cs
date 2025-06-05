using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class PharmacistForm : Form
    {
        public PharmacistForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PharmacyDB.accdb";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Medicines WHERE NAME LIKE @term OR CATEGORY LIKE @term";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@term", "%" + searchTerm + "%");

                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSearchResults.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        { 
            if (dgvSearchResults.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvSearchResults.SelectedRows[0].Cells["ID"].Value);
                int quantityToSell = (int)numSellQuantity.Value;

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PharmacyDB.accdb";

                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();

                    // Get current quantity
                    OleDbCommand getQtyCmd = new OleDbCommand("SELECT QUANTITY FROM Medicines WHERE ID = @id", con);
                    getQtyCmd.Parameters.AddWithValue("@id", id);
                    int currentQty = Convert.ToInt32(getQtyCmd.ExecuteScalar());

                    if (quantityToSell > 0 && currentQty >= quantityToSell)
                    {
                        int newQty = currentQty - quantityToSell;

                        OleDbCommand updateCmd = new OleDbCommand("UPDATE Medicines SET QUANTITY = @qty WHERE ID = @id", con);
                        updateCmd.Parameters.AddWithValue("@qty", newQty);
                        updateCmd.Parameters.AddWithValue("@id", id);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Medicine sold successfully!");

                        // Refresh search results
                        btnSearch.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Not enough stock available.");
                    }

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to sell.");
            }
        }

    }
}

