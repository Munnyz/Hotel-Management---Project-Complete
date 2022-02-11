using HotelMan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseRental
{
    public partial class Tenants : Form
    {
        public Tenants()
        {
            InitializeComponent();
            ShowTenants();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\HotelManTuto.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowTenants()
        {
            Con.Open();
            string Query = "Select * from TenantTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            TenantsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ResetData()
        {
            Ttel.Text = "";
            Gencb.SelectedIndex = -1;
            Tname.Text = "";
        }

        private void AddTenant_Click(object sender, EventArgs e)
        {
                if (Tname.Text == "" || Gencb.SelectedIndex == -1 || Ttel.Text == "")
                {
                    MessageBox.Show("Bote todas as Informações");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into TenantTbl(TenName,TenTel,TenGen)values(@TN,@TT,@TG)", Con);
                        cmd.Parameters.AddWithValue("@TN", Tname.Text);
                        cmd.Parameters.AddWithValue("@TT", Ttel.Text);
                        cmd.Parameters.AddWithValue("@TG", Gencb.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Inquilino Adicionado");
                        Con.Close();
                        ResetData();
                        ShowTenants();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
        }

        int Key = 0;
        private void TenantsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tname.Text = TenantsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Ttel.Text = TenantsDGV.SelectedRows[0].Cells[2].Value.ToString();
            Gencb.Text = TenantsDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (Tname.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TenantsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Tname.Text == "" || Gencb.SelectedIndex == -1 || Ttel.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TenantTbl where TenId=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inquilino Excluido");
                    Con.Close();
                    ResetData();
                    ShowTenants();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Tname.Text == "" || Gencb.SelectedIndex == -1 || Ttel.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update TenantTbl set TenName=@TN,TenTel=@TT,TenGen=@TG where TenId=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TN", Tname.Text);
                    cmd.Parameters.AddWithValue("@TT", Ttel.Text);
                    cmd.Parameters.AddWithValue("@TG", Gencb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inquilino Atualizado");
                    Con.Close();
                    ResetData();
                    ShowTenants();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }







        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Tenants_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hotelManTutoDataSet.TenantTbl'. Você pode movê-la ou removê-la conforme necessário.
            this.tenantTblTableAdapter.Fill(this.hotelManTutoDataSet.TenantTbl);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

       

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


       

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Aluguel Al = new Aluguel();
            Al.Show();
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Senhorio sen = new Senhorio();
            sen.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Tenants ten = new Tenants();
            ten.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Apartamento apt = new Apartamento();
            apt.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Aluguel Al = new Aluguel();
            Al.Show();
            this.Hide();
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Senhorio sen = new Senhorio();
            sen.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Show();
            
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
