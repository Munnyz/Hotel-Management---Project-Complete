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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
            ShowCategory();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lucas\Documents\HotelManTuto.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowCategory()
        {
            Con.Open();
            string Query = "Select * from CategoryTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            CategoryDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ResetData()
        {
            CategoryTxt.Text = "";
            RemarksTxt.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CategoryTxt.Text == "" || RemarksTxt.Text == "")
            {
                MessageBox.Show("Bote todas as Informações");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CategoryTbl(Category,Remarks)values(@Cat,@Rem)", Con);
                    cmd.Parameters.AddWithValue("@Cat", CategoryTxt.Text);
                    cmd.Parameters.AddWithValue("@Rem", RemarksTxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoria Adicionada");
                    Con.Close();
                    ResetData();
                    ShowCategory();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
