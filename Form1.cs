using Microsoft.Data.SqlClient;
using WFA221124.Properties;

namespace WFA221124
{
    public partial class Form1 : Form
    {
        private static SqlConnection connection = new SqlConnection(Resources.ConnectionString);

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
                    (reader.GetBoolean(2) ? "férfi" : "nõ"),
                    reader.GetDateTime(3).ToString("yyyy. MMMM dd.")
                    );
            }

            reader.Close();
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdatok.SelectedRows.Count == 0 || dgvAdatok.SelectedRows.Count > 1) return;
            tbNameModify.Text = dgvAdatok.SelectedRows[0].Cells["Nev"].Value.ToString();
            if (dgvAdatok.SelectedRows[0].Cells["Nem"].Value.ToString() == "nõ") rbWomanModify.Checked = true;
            else rbManModify.Checked = true;
            dtpModify.Value = DateTime.Parse(dgvAdatok.SelectedRows[0].Cells["Szuletett"].Value.ToString());
        }

        private void ModifyData(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNameModify.Text))
            {
                MessageBox.Show("A név mezõ nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("A név mezõ nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}