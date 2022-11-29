using Microsoft.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using WFA221124.Properties;

namespace WFA221124
{
    public partial class Form1 : Form
    {
        private static SqlConnection connection = new SqlConnection(Resources.ConnectionString);
        private static int selectedIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            connection.Open();
            LoadData(false);
        }
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
        private void OnAdultCheckedChanged(object sender, EventArgs e)
        {
            LoadData((sender as CheckBox).Checked);
        }

        private void LoadData(bool adult)
        {
            string command = $"SELECT * FROM pelda.dbo.emberek {(adult ? "WHERE DATEDIFF(year, szul, GETDATE()) >= 18" : "")};";
            SqlCommand sql = new SqlCommand(command, connection);
            SqlDataReader reader = sql.ExecuteReader();

            dgvAdatok.Rows.Clear();
            while(reader.Read())
            {
                dgvAdatok.Rows.Add(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    (reader.GetBoolean(2) ? "f�rfi" : "n�"),
                    reader.GetDateTime(3).ToString("yyyy. MMMM dd.")
                    );
            }

            reader.Close();

            dgvAdatok.ClearSelection();
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdatok.SelectedRows.Count == 0 || dgvAdatok.SelectedRows.Count > 1) return;
            tbNameModify.Text = dgvAdatok.SelectedRows[0].Cells["Nev"].Value.ToString();
            if (dgvAdatok.SelectedRows[0].Cells["Nem"].Value.ToString() == "n�") rbWomanModify.Checked = true;
            else rbManModify.Checked = true;
            dtpModify.Value = DateTime.Parse(dgvAdatok.SelectedRows[0].Cells["Szuletett"].Value.ToString());
        }

        private void ModifyData(object sender, EventArgs e)
        {
            if (selectedIndex < 0) return;
            if (string.IsNullOrWhiteSpace(tbNameModify.Text))
            {
                MessageBox.Show("A n�v mez� nem lehet �res!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string command = $"UPDATE pelda.dbo.emberek SET " +
                $"nev = '{tbNameModify.Text}', " +
                $"nem = {(rbWomanModify.Checked ? 0 : 1)}, " +
                $"szul = '{DateTime.Parse(dtpModify.Value.ToShortDateString()).ToString("yyyy-MM-dd")}' " +
                $"WHERE id = {dgvAdatok.SelectedRows[0].Cells[0].Value.ToString()};";
            SqlCommand sql = new SqlCommand(command, connection);

            
            SqlDataAdapter sda = new SqlDataAdapter() //prevent sql injection
            {
                UpdateCommand = sql
            };
            sda.UpdateCommand.ExecuteNonQuery();

            LoadData(cbAdult.Checked);
        }

        private void AddData(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNameAdd.Text))
            {
                MessageBox.Show("A n�v mez� nem lehet �res!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string command = $"INSERT INTO pelda.dbo.emberek VALUES (" +
                $"'{tbNameAdd.Text}', " +
                $"{(rbWomanAdd.Checked ? 0 : 1)}, " +
                $"'{DateTime.Parse(dtpAdd.Value.ToShortDateString()).ToString("yyyy-MM-dd")}');";
            SqlCommand sql = new SqlCommand(command, connection);

            SqlDataAdapter sda = new SqlDataAdapter() //prevent sql injection
            {
                InsertCommand = sql
            };
            sda.InsertCommand.ExecuteNonQuery();

            LoadData(cbAdult.Checked);
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
            if (selectedIndex < 0) return;

            tbNameModify.Text = dgvAdatok.Rows[selectedIndex].Cells["Nev"].Value.ToString();
            if (dgvAdatok.Rows[selectedIndex].Cells["Nem"].Value.ToString() == "n�") rbWomanModify.Checked = true;
            else rbManModify.Checked = true;
            dtpModify.Value = DateTime.Parse(dgvAdatok.Rows[selectedIndex].Cells["Szuletett"].Value.ToString());
        }

        private void OnDeleteBtnClick(object sender, EventArgs e)
        {
            if (selectedIndex < 0) return;
            DialogResult diagres = MessageBox.Show(text: $"Biztos t�r�lni szeretn� {dgvAdatok[1, selectedIndex].Value} adatait?", caption: "Figyelmeztet�s", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Warning);

            if (diagres == DialogResult.Yes)
            {
                string command = $"DELETE FROM pelda.dbo.emberek WHERE id = {(int)dgvAdatok[0, selectedIndex].Value};";
                SqlCommand sql = new SqlCommand(command, connection);

                SqlDataAdapter sda = new SqlDataAdapter() //prevent sql injection
                {
                    DeleteCommand = sql
                };
                sda.DeleteCommand.ExecuteNonQuery();

                LoadData(cbAdult.Checked);
            }
        }
    }
}