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
    public partial class Apartamento : Form
    {
        public Apartamento()
        {
            InitializeComponent();
            GetCategory();
            GetOnwer();
            ShowApart();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\HotelManTuto.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetCategory()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CNum from CategoryTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CNum", typeof(int));
            dt.Load(Rdr);
            TipoCb.ValueMember = "CNum";
            TipoCb.DataSource = dt;
            Con.Close();
        }
        private void GetOnwer()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select LLId from LandLordTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("LLId", typeof(int));
            dt.Load(Rdr);
            OnwerCb.ValueMember = "LLId";
            OnwerCb.DataSource = dt;
            Con.Close();
        }
        private void ShowApart()
        {
            Con.Open();
            string Query = "Select * from ApartTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            ApartDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ResetData()
        {
            AName.Text = "";
            AEnd.Text = "";
            ACusto.Text = "";
            OnwerCb.SelectedIndex = -1;
            TipoCb.SelectedIndex = -1;
            
        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            if (AName.Text == "" || ACusto.Text == "" || OnwerCb.SelectedIndex == -1 || TipoCb.SelectedIndex == -1 || AEnd.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ApartTbl(AName,AAdress,AType,ACost,Onwer)values(@AN,@AE,@AT,@AC,@AO)", Con);
                    cmd.Parameters.AddWithValue("@AN", AName.Text);
                    cmd.Parameters.AddWithValue("@AE", AEnd.Text);                  
                    cmd.Parameters.AddWithValue("@AT", TipoCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@AC", ACusto.Text);
                    cmd.Parameters.AddWithValue("@AO", OnwerCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Apartamento Adicionado");
                    Con.Close();
                    ResetData();
                    ShowApart();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void ApartDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AName.Text = ApartDGV.SelectedRows[0].Cells[1].Value.ToString();
            AEnd.Text = ApartDGV.SelectedRows[0].Cells[2].Value.ToString();
            TipoCb.Text = ApartDGV.SelectedRows[0].Cells[3].Value.ToString();
            ACusto.Text = ApartDGV.SelectedRows[0].Cells[4].Value.ToString();
            OnwerCb.Text = ApartDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (AName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ApartDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }






        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Apartamento_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        int Key = 0;

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (AName.Text == "" || ACusto.Text == "" || OnwerCb.SelectedIndex == -1 || TipoCb.SelectedIndex == -1 || AEnd.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ApartTbl where Anum=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Apartamento Excluido");
                    Con.Close();
                    ResetData();
                    ShowApart();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AName.Text == "" || ACusto.Text == "" || OnwerCb.SelectedIndex == -1 || TipoCb.SelectedIndex == -1 || AEnd.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ApartTbl set AName=@AN,AAdress=@AE,AType=@AT,ACost=@AC,Onwer=@AO where Anum=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AN", AName.Text);
                    cmd.Parameters.AddWithValue("@AE", AEnd.Text);
                    cmd.Parameters.AddWithValue("@AT", TipoCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@AC", ACusto.Text);
                    cmd.Parameters.AddWithValue("@AO", OnwerCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inquilino Atualizado");
                    Con.Close();
                    ResetData();
                    ShowApart();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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
            
        }
    }
}
