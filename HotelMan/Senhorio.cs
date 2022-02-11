using HouseRental;
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

namespace HotelMan
{
    public partial class Senhorio : Form
    {
        public Senhorio()
        {
            InitializeComponent();
            ShowSen();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\HotelManTuto.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowSen()
        {
            Con.Open();
            string Query = "Select * from LandLordTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            SenDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ResetData()
        {
            Stel.Text = "";
            Gencb.SelectedIndex = -1;
            Sname.Text = "";
        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            if (Sname.Text == "" || Gencb.SelectedIndex == -1 || Stel.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into LandLordTbl(LLName,LLTel,LLGen)values(@LN,@LT,@LG)", Con);
                    cmd.Parameters.AddWithValue("@LN", Sname.Text);
                    cmd.Parameters.AddWithValue("@LT", Stel.Text);
                    cmd.Parameters.AddWithValue("@LG", Gencb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Senhorio Adicionado");
                    Con.Close();
                    ResetData();
                    ShowSen();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Sname.Text == "" || Gencb.SelectedIndex == -1 || Stel.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from LandLordTbl where LLId=@LKey", Con);
                    cmd.Parameters.AddWithValue("@LKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Senhorio Excluido");
                    Con.Close();
                    ResetData();
                    ShowSen();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SenDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sname.Text = SenDGV.SelectedRows[0].Cells[1].Value.ToString();
            Stel.Text = SenDGV.SelectedRows[0].Cells[2].Value.ToString();
            Gencb.Text = SenDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (Sname.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SenDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Sname.Text == "" || Gencb.SelectedIndex == -1 || Stel.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update LandLordTbl set LLName=@LN,LLTel=@LT,LLGen=@LG where LLId=@LKey", Con);
                    cmd.Parameters.AddWithValue("@LN", Sname.Text);
                    cmd.Parameters.AddWithValue("@LT", Stel.Text);
                    cmd.Parameters.AddWithValue("@LG", Gencb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inquilino Atualizado");
                    Con.Close();
                    ResetData();
                    ShowSen();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Categoria Obj = new Categoria();
            Obj.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
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
        private void label7_Click(object sender, EventArgs e)
        {
            Aluguel Al = new Aluguel();
            Al.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Show();
            
        }
    }
    }

