using System.Windows.Forms;

namespace HouseRental
{
    partial class Tenants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tenants));
            this.Tname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Ttel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TenantsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManTutoDataSet = new HotelMan.HotelManTutoDataSet();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Gencb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tenantTblTableAdapter = new HotelMan.HotelManTutoDataSetTableAdapters.TenantTblTableAdapter();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AddTenant = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.TenantsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManTutoDataSet)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tname
            // 
            this.Tname.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Tname.Location = new System.Drawing.Point(299, 199);
            this.Tname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(268, 38);
            this.Tname.TabIndex = 12;
            this.Tname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(303, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 33);
            this.label9.TabIndex = 31;
            this.label9.Text = "Inquilino:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(603, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 33);
            this.label10.TabIndex = 33;
            this.label10.Text = "Telefone:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Ttel
            // 
            this.Ttel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.Ttel.Location = new System.Drawing.Point(598, 199);
            this.Ttel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ttel.Name = "Ttel";
            this.Ttel.Size = new System.Drawing.Size(268, 38);
            this.Ttel.TabIndex = 32;
            this.Ttel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(299, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 33);
            this.label11.TabIndex = 35;
            this.label11.Text = "Inquilino Lista:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // TenantsDGV
            // 
            this.TenantsDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.TenantsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.TenantsDGV.AutoGenerateColumns = false;
            this.TenantsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TenantsDGV.BackgroundColor = System.Drawing.Color.White;
            this.TenantsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TenantsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TenantsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TenantsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.TenantsDGV.ColumnHeadersHeight = 4;
            this.TenantsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenIdDataGridViewTextBoxColumn,
            this.tenNameDataGridViewTextBoxColumn,
            this.tenTelDataGridViewTextBoxColumn,
            this.tenGenDataGridViewTextBoxColumn});
            this.TenantsDGV.DataSource = this.tenantTblBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TenantsDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.TenantsDGV.EnableHeadersVisualStyles = false;
            this.TenantsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TenantsDGV.Location = new System.Drawing.Point(290, 366);
            this.TenantsDGV.Name = "TenantsDGV";
            this.TenantsDGV.RowHeadersVisible = false;
            this.TenantsDGV.RowHeadersWidth = 51;
            this.TenantsDGV.RowTemplate.Height = 24;
            this.TenantsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TenantsDGV.Size = new System.Drawing.Size(933, 256);
            this.TenantsDGV.TabIndex = 36;
            this.TenantsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TenantsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TenantsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TenantsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TenantsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TenantsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TenantsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TenantsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TenantsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.TenantsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TenantsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TenantsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TenantsDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.TenantsDGV.ThemeStyle.ReadOnly = false;
            this.TenantsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TenantsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TenantsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TenantsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TenantsDGV.ThemeStyle.RowsStyle.Height = 24;
            this.TenantsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TenantsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TenantsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TenantsDGV_CellContentClick);
            // 
            // tenIdDataGridViewTextBoxColumn
            // 
            this.tenIdDataGridViewTextBoxColumn.DataPropertyName = "TenId";
            this.tenIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.tenIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenIdDataGridViewTextBoxColumn.Name = "tenIdDataGridViewTextBoxColumn";
            this.tenIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNameDataGridViewTextBoxColumn
            // 
            this.tenNameDataGridViewTextBoxColumn.DataPropertyName = "TenName";
            this.tenNameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.tenNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNameDataGridViewTextBoxColumn.Name = "tenNameDataGridViewTextBoxColumn";
            // 
            // tenTelDataGridViewTextBoxColumn
            // 
            this.tenTelDataGridViewTextBoxColumn.DataPropertyName = "TenTel";
            this.tenTelDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.tenTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTelDataGridViewTextBoxColumn.Name = "tenTelDataGridViewTextBoxColumn";
            // 
            // tenGenDataGridViewTextBoxColumn
            // 
            this.tenGenDataGridViewTextBoxColumn.DataPropertyName = "TenGen";
            this.tenGenDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.tenGenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenGenDataGridViewTextBoxColumn.Name = "tenGenDataGridViewTextBoxColumn";
            // 
            // tenantTblBindingSource
            // 
            this.tenantTblBindingSource.DataMember = "TenantTbl";
            this.tenantTblBindingSource.DataSource = this.hotelManTutoDataSet;
            // 
            // hotelManTutoDataSet
            // 
            this.hotelManTutoDataSet.DataSetName = "HotelManTutoDataSet";
            this.hotelManTutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EditBtn
            // 
            this.EditBtn.ActiveBorderThickness = 1;
            this.EditBtn.ActiveCornerRadius = 20;
            this.EditBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EditBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EditBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.ButtonText = "Editar";
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.EditBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleCornerRadius = 20;
            this.EditBtn.IdleFillColor = System.Drawing.Color.Red;
            this.EditBtn.IdleForecolor = System.Drawing.Color.Azure;
            this.EditBtn.IdleLineColor = System.Drawing.Color.Red;
            this.EditBtn.Location = new System.Drawing.Point(419, 263);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(148, 41);
            this.EditBtn.TabIndex = 37;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Deletar";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.Red;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.Azure;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(861, 263);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(148, 41);
            this.DeleteBtn.TabIndex = 38;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Gencb
            // 
            this.Gencb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gencb.FormattingEnabled = true;
            this.Gencb.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.Gencb.Location = new System.Drawing.Point(893, 199);
            this.Gencb.Name = "Gencb";
            this.Gencb.Size = new System.Drawing.Size(186, 37);
            this.Gencb.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(902, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 33);
            this.label12.TabIndex = 40;
            this.label12.Text = "Genero:";
            // 
            // tenantTblTableAdapter
            // 
            this.tenantTblTableAdapter.ClearBeforeFill = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ImageButton2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label7);
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Cyan;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Cyan;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(284, 622);
            this.guna2CustomGradientPanel1.TabIndex = 57;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Location = new System.Drawing.Point(12, 37);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(62, 52);
            this.guna2ImageButton2.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 13.8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(89, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 33);
            this.label7.TabIndex = 24;
            this.label7.Text = "Aluguel";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 33);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sair";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(94, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 33);
            this.label5.TabIndex = 22;
            this.label5.Text = "Senhorio";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "Apartamentos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Categoria";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Inquilino";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "House Rental MS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(290, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 55);
            this.panel2.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(7, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 43);
            this.label8.TabIndex = 30;
            this.label8.Text = "Inquilinos";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(1171, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(52, 58);
            this.guna2ImageButton1.TabIndex = 59;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // AddTenant
            // 
            this.AddTenant.BackColor = System.Drawing.Color.Transparent;
            this.AddTenant.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddTenant.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddTenant.Image = ((System.Drawing.Image)(resources.GetObject("AddTenant.Image")));
            this.AddTenant.ImageOffset = new System.Drawing.Point(6, 0);
            this.AddTenant.ImageRotate = 0F;
            this.AddTenant.Location = new System.Drawing.Point(1130, 189);
            this.AddTenant.Name = "AddTenant";
            this.AddTenant.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddTenant.Size = new System.Drawing.Size(93, 49);
            this.AddTenant.TabIndex = 60;
            this.AddTenant.Click += new System.EventHandler(this.AddTenant_Click);
            // 
            // Tenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1235, 622);
            this.Controls.Add(this.AddTenant);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Gencb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.TenantsDGV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Ttel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Tname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tenants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenants";
            this.Load += new System.EventHandler(this.Tenants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TenantsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManTutoDataSet)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox Tname;
        private Label label9;
        private Label label10;
        private TextBox Ttel;
        private Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView TenantsDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private ComboBox Gencb;
        private Label label12;
        private HotelMan.HotelManTutoDataSet hotelManTutoDataSet;
        private BindingSource tenantTblBindingSource;
        private HotelMan.HotelManTutoDataSetTableAdapters.TenantTblTableAdapter tenantTblTableAdapter;
        private DataGridViewTextBoxColumn tenIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenTelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenGenDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label8;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton AddTenant;
    }
}