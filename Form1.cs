using System;
using System.Data;
using System.Windows.Forms;
using CrudApp.Data;

namespace CrudApp
{
    public partial class Form1 : Form
    {
        Database db = new Database();
        BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataTable table = db.GetClients();

            bindingSource.DataSource = table;

            dataGridView1.DataSource = bindingSource;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            db.InsertClient(txtName.Text, txtEmail.Text);

            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            db.UpdateClient(id, txtName.Text, txtEmail.Text);

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            db.DeleteClient(id);

            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
        }
    }
}
