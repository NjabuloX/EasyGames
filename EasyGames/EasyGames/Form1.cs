using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace EasyGames
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = .\SQLExpress; Initial Catalog = EasyG1data; Integrated Security = True;");
        int clientId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)

                    conn.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@ClientId",clientId);
                param.Add("@Name", txt_nam.Text.Trim());
                param.Add("@surname", txt_surn.Text.Trim());
                param.Add("@ClientsBalance",txt_comment.Text.Trim());
                conn.Execute("ClientAddorEdit", param, commandType: CommandType.StoredProcedure);
                FillDataGridView();
                if(clientId == 0)
                {
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    MessageBox.Show("Updated Successfully");
                    FillDataGridView();
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void FillDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ClientId", txt_find.Text.Trim());
            List<Client> list = conn.Query<Client>("ClientVieworFind", param, commandType: CommandType.StoredProcedure).ToList<Client>();
            data_display.DataSource = list;
        }
        void TransactGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ClientId", txt_find.Text.Trim());
            List<Transaction> list = conn.Query<Transaction>("ClientViewById", param, commandType: CommandType.StoredProcedure).ToList<Transaction>();
            data_display.DataSource = list;
        }
        class Client
        {
            public int ClientId { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public float ClientBalance { get; set; }
        }
        class Transaction
        {
            public int TransactionId { get; set; }
            public double Amount { get; set; }
            public string Comment { get; set; }
            public float ClientBalance { get; set; }

            public List<Client> Clients { get; set; } = new List<Client>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
           
                ClientViewFind();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void ClientViewFind()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ClientId", txt_find.Text.Trim());
            List<Client> list = conn.Query<Client>("ClientViewById", param, commandType: CommandType.StoredProcedure).ToList<Client>();
            data_display.DataSource = list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txt_nam.Text = txt_surn.Text = txt_comment.Text = txt_find.Text = "";
            clientId = 0;
            btn_add_update.Text = "Save";
            btn_delete.Enabled = false;
        }

        private void data_display_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(data_display.CurrentRow.Index != -1)
                {
                    clientId = Convert.ToInt32(data_display.CurrentRow.Cells[0].Value.ToString());
                    txt_nam.Text = data_display.CurrentRow.Cells[1].Value.ToString();
                    txt_surn.Text = data_display.CurrentRow.Cells[2].Value.ToString();
                    txt_comment.Text = data_display.CurrentRow.Cells[3].Value.ToString();
                    btn_add_update.Text = "Update";
                    btn_delete.Enabled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you Sure To Delete This Record?", "Message",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@ClientId", clientId);
                    conn.Execute("ClientDeleteById", param, commandType: CommandType.StoredProcedure);
                    Clear();
                    FillDataGridView();
                    MessageBox.Show("Deleted Sucessfully !");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
