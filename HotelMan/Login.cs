using HouseRental;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            user.Text = "";
            passw.Text = "";
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (user.Text == "" || passw.Text == "")
            {
                MessageBox.Show("Coloque o usuário");
                Reset();
            }
            else if(user.Text == "admin" && passw.Text == "admin")
            {
                Tenants tenants = new Tenants();
                tenants.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário inválido!");
                Reset();
            }
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
