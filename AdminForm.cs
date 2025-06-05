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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PharmacyDB.accdb";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    string query = "INSERT INTO Medicines (NAME, CATEGORY, QUANTITY, PRICE, EXPIRYDATE, QUANTITY_PILL_PER_LEAF, NUMBER_OF_LEAFS_PER_BOX) " +
                                   "VALUES (@name, @category, @quantity, @price, @expiry, @pills, @leafs)";

                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@expiry", dtpExpiry.Value);
                    cmd.Parameters.AddWithValue("@pills", int.Parse(txtPillsPerLeaf.Text));
                    cmd.Parameters.AddWithValue("@leafs", int.Parse(txtLeafsPerBox.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Medicine added successfully!");

                    // Optional: Clear fields after adding
                    txtName.Clear();
                    txtCategory.Clear();
                    txtQuantity.Clear();
                    txtPrice.Clear();
                    txtPillsPerLeaf.Clear();
                    txtLeafsPerBox.Clear();
                    dtpExpiry.Value = DateTime.Today;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PharmacyDB.accdb";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Medicines";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvInventory.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
    }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInventory.Rows[e.RowIndex];

                txtName.Text = row.Cells["NAME"].Value.ToString();
                txtCategory.Text = row.Cells["CATEGORY"].Value.ToString();
                txtQuantity.Text = row.Cells["QUANTITY"].Value.ToString();
                txtPrice.Text = row.Cells["PRICE"].Value.ToString();
                dtpExpiry.Value = Convert.ToDateTime(row.Cells["EXPIRYDATE"].Value);
                txtPillsPerLeaf.Text = row.Cells["QUANTITY_PILL_PER_LEAF"].Value.ToString();
                txtLeafsPerBox.Text = row.Cells["NUMBER_OF_LEAFS_PER_BOX"].Value.ToString();
            }
        }

        private void tnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["ID"].Value);
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PharmacyDB.accdb";

                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    string query = "UPDATE Medicines SET NAME = @name, CATEGORY = @category, QUANTITY = @quantity, PRICE = @price, EXPIRYDATE = @expiry, QUANTITY_PILL_PER_LEAF = @pills, NUMBER_OF_LEAFS_PER_BOX = @leafs WHERE ID = @id";
                    OleDbCommand cmd = new OleDbCommand(query, con);

                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@expiry", dtpExpiry.Value);
                    cmd.Parameters.AddWithValue("@pills", int.Parse(txtPillsPerLeaf.Text));
                    cmd.Parameters.AddWithValue("@leafs", int.Parse(txtLeafsPerBox.Text));
                    cmd.Parameters.AddWithValue("@id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Medicine updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["ID"].Value);
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PharmacyDB.accdb";

                var confirm = MessageBox.Show("Are you sure you want to delete this medicine?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (OleDbConnection con = new OleDbConnection(connectionString))
                    {
                        string query = "DELETE FROM Medicines WHERE ID = @id";
                        OleDbCommand cmd = new OleDbCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", id);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Medicine deleted successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine to delete.");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

    