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
    public partial class Aluguel : Form
    {
        public Aluguel()
        {
            InitializeComponent();
            GetApart();
            GetTenant();
            ShowAluguel();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\HotelManTuto.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetApart()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Anum from ApartTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Anum", typeof(int));
            dt.Load(Rdr);
            Apartcb.ValueMember = "Anum";
            Apartcb.DataSource = dt;
            Con.Close();
        }
        private void GetTenant()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select TenId from TenantTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TenId", typeof(int));
            dt.Load(Rdr);
            Tenantcb.ValueMember = "TenId";
            Tenantcb.DataSource = dt;
            Con.Close();
        }
        private void ShowAluguel()
        {
            Con.Open();
            string Query = "Select * from RentTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            AluguelDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ResetData()
        {
            Valor.Text = "";
            Apartcb.SelectedIndex = -1;
            Tenantcb.SelectedIndex = -1;
        }
        private void GetCost()
        {
            Con.Open();
            string Query = "select * from ApartTbl where Anum=" + Apartcb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            Adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Valor.Text = dr["ACost"].ToString();
            }
            Con.Close();
        }

        private void AddTenant_Click(object sender, EventArgs e)
        {
            if (Apartcb.SelectedIndex == -1 || Tenantcb.SelectedIndex == -1 || Valor.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    string Period = RDate.Value.Date.Month+"-"+ RDate.Value.Date.Year;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into RentTbl(Apart,Tenant,Period,Amount)values(@RA,@RT,@RP,@RV)", Con);
                    cmd.Parameters.AddWithValue("@RA", Apartcb.SelectedValue.ToString());                   
                    cmd.Parameters.AddWithValue("@RT", Tenantcb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@RP", Period);
                    cmd.Parameters.AddWithValue("@RV", Valor.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Apartamento Alugado");
                    Con.Close();
                    ResetData();
                    ShowAluguel();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void Aluguel_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Apartcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetCost();
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
