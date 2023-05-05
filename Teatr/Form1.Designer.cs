namespace Teatr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlMenu = new Panel();
            label1 = new Label();
            button1 = new Button();
            forClr = new System.Windows.Forms.Timer(components);
            Theatres = new ComboBox();
            pnlTeatrInfo = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            pnlSeanse = new Panel();
            close3 = new Button();
            pnlAddSeanse = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            textBox4 = new TextBox();
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            close4 = new Button();
            panel2 = new Panel();
            seances = new ComboBox();
            btnSeanseAdd = new Button();
            groupBox3 = new GroupBox();
            lblTheatreTel = new Label();
            label6 = new Label();
            lblTheatreAdress = new Label();
            label5 = new Label();
            lblTheatreCity = new Label();
            label4 = new Label();
            lblTheatreName = new Label();
            label2 = new Label();
            close1 = new Button();
            btnTeatrAdd = new Button();
            pnlMain = new Panel();
            pnlTheatreAdd = new Panel();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnSaqlash = new Button();
            pnltxt4 = new Panel();
            txtTheatreTel = new TextBox();
            pnltxt3 = new Panel();
            txtTheatreAdress = new TextBox();
            pnltxt2 = new Panel();
            txtTheatreCity = new TextBox();
            pnltxt1 = new Panel();
            txtTheatreName = new TextBox();
            close2 = new Button();
            pnlMenu.SuspendLayout();
            pnlTeatrInfo.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            pnlSeanse.SuspendLayout();
            pnlAddSeanse.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlTheatreAdd.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMenu.BackColor = Color.FromArgb(0, 50, 0);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(button1);
            pnlMenu.Location = new Point(12, 12);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1148, 43);
            pnlMenu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 7);
            label1.Name = "label1";
            label1.Size = new Size(481, 28);
            label1.TabIndex = 1;
            label1.Text = "Teatr va tomoshalar ma'lumotlarini taxrirlash bo'limi";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(60, 43);
            button1.TabIndex = 0;
            button1.Text = "≡";
            button1.UseVisualStyleBackColor = true;
            // 
            // forClr
            // 
            forClr.Enabled = true;
            forClr.Interval = 50;
            forClr.Tick += forClr_Tick;
            // 
            // Theatres
            // 
            Theatres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Theatres.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Theatres.FormattingEnabled = true;
            Theatres.Items.AddRange(new object[] { "1" });
            Theatres.Location = new Point(12, 71);
            Theatres.Name = "Theatres";
            Theatres.Size = new Size(1088, 30);
            Theatres.TabIndex = 1;
            Theatres.Text = " Teatrni tanlang";
            Theatres.SelectedIndexChanged += Theatres_SelectedIndexChanged;
            // 
            // pnlTeatrInfo
            // 
            pnlTeatrInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlTeatrInfo.Controls.Add(panel1);
            pnlTeatrInfo.Controls.Add(groupBox3);
            pnlTeatrInfo.Controls.Add(close1);
            pnlTeatrInfo.Dock = DockStyle.Top;
            pnlTeatrInfo.Location = new Point(0, 0);
            pnlTeatrInfo.Name = "pnlTeatrInfo";
            pnlTeatrInfo.Size = new Size(1148, 500);
            pnlTeatrInfo.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(392, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 470);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(pnlSeanse);
            panel3.Controls.Add(pnlAddSeanse);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(752, 426);
            panel3.TabIndex = 8;
            // 
            // pnlSeanse
            // 
            pnlSeanse.BorderStyle = BorderStyle.FixedSingle;
            pnlSeanse.Controls.Add(close3);
            pnlSeanse.Dock = DockStyle.Top;
            pnlSeanse.Location = new Point(0, 1);
            pnlSeanse.Name = "pnlSeanse";
            pnlSeanse.Size = new Size(752, 400);
            pnlSeanse.TabIndex = 6;
            // 
            // close3
            // 
            close3.Dock = DockStyle.Bottom;
            close3.Location = new Point(0, 370);
            close3.Name = "close3";
            close3.Size = new Size(750, 28);
            close3.TabIndex = 1;
            close3.Text = "↩️";
            close3.UseVisualStyleBackColor = true;
            close3.Click += close3_Click;
            close3.MouseLeave += close1_MouseLeave;
            close3.MouseHover += close1_MouseHover;
            // 
            // pnlAddSeanse
            // 
            pnlAddSeanse.BorderStyle = BorderStyle.FixedSingle;
            pnlAddSeanse.Controls.Add(panel5);
            pnlAddSeanse.Controls.Add(panel4);
            pnlAddSeanse.Controls.Add(close4);
            pnlAddSeanse.Dock = DockStyle.Top;
            pnlAddSeanse.Location = new Point(0, 0);
            pnlAddSeanse.Name = "pnlAddSeanse";
            pnlAddSeanse.Size = new Size(752, 1);
            pnlAddSeanse.TabIndex = 7;
            pnlAddSeanse.Paint += pnlAddSeanse_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(textBox4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(320, 0);
            panel5.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(82, -186);
            label3.Name = "label3";
            label3.Size = new Size(162, 22);
            label3.TabIndex = 6;
            label3.Text = "Boshlanish vaqti ";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(16, -225);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nom";
            textBox1.Size = new Size(286, 31);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(16, 63);
            button3.Name = "button3";
            button3.Size = new Size(286, 41);
            button3.TabIndex = 10;
            button3.Text = "Saqlash";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(16, -157);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "dd/mm/yyyy";
            textBox2.Size = new Size(286, 31);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(16, 30);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Izoh";
            textBox5.Size = new Size(286, 27);
            textBox5.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(16, -106);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "hh:mm";
            textBox3.Size = new Size(286, 31);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(16, -14);
            button2.Name = "button2";
            button2.Size = new Size(286, 29);
            button2.TabIndex = 8;
            button2.Text = "Rasm tanlash";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(16, -61);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Davomiyligi (soat)";
            textBox4.Size = new Size(286, 31);
            textBox4.TabIndex = 7;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(320, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(430, 0);
            panel4.TabIndex = 11;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(430, 0);
            dataGridView2.TabIndex = 0;
            // 
            // Column4
            // 
            Column4.HeaderText = "Sektor";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Qator";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Narx (UZS)";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // close4
            // 
            close4.Dock = DockStyle.Bottom;
            close4.Location = new Point(0, -28);
            close4.Name = "close4";
            close4.Size = new Size(750, 28);
            close4.TabIndex = 2;
            close4.Text = "↩️";
            close4.UseVisualStyleBackColor = true;
            close4.Click += close4_Click;
            close4.MouseLeave += close1_MouseLeave;
            close4.MouseHover += close1_MouseHover;
            // 
            // panel2
            // 
            panel2.Controls.Add(seances);
            panel2.Controls.Add(btnSeanseAdd);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 42);
            panel2.TabIndex = 5;
            // 
            // seances
            // 
            seances.Anchor = AnchorStyles.None;
            seances.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            seances.FormattingEnabled = true;
            seances.Items.AddRange(new object[] { "1" });
            seances.Location = new Point(19, 6);
            seances.Name = "seances";
            seances.Size = new Size(656, 30);
            seances.TabIndex = 2;
            seances.Text = " Tomoshani tanlang";
            seances.SelectedIndexChanged += seances_SelectedIndexChanged;
            // 
            // btnSeanseAdd
            // 
            btnSeanseAdd.Anchor = AnchorStyles.Bottom;
            btnSeanseAdd.FlatStyle = FlatStyle.System;
            btnSeanseAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeanseAdd.ForeColor = Color.Black;
            btnSeanseAdd.Location = new Point(680, 6);
            btnSeanseAdd.Name = "btnSeanseAdd";
            btnSeanseAdd.Size = new Size(54, 30);
            btnSeanseAdd.TabIndex = 4;
            btnSeanseAdd.Text = "+";
            btnSeanseAdd.UseVisualStyleBackColor = true;
            btnSeanseAdd.Click += btnSeanseAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTheatreTel);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(lblTheatreAdress);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lblTheatreCity);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(lblTheatreName);
            groupBox3.Controls.Add(label2);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(392, 470);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Teatr ma'lumotlari";
            // 
            // lblTheatreTel
            // 
            lblTheatreTel.Anchor = AnchorStyles.Left;
            lblTheatreTel.AutoSize = true;
            lblTheatreTel.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTheatreTel.Location = new Point(149, 295);
            lblTheatreTel.Name = "lblTheatreTel";
            lblTheatreTel.Size = new Size(0, 22);
            lblTheatreTel.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 295);
            label6.Name = "label6";
            label6.Size = new Size(94, 22);
            label6.TabIndex = 6;
            label6.Text = "Telefon : ";
            // 
            // lblTheatreAdress
            // 
            lblTheatreAdress.Anchor = AnchorStyles.Left;
            lblTheatreAdress.AutoSize = true;
            lblTheatreAdress.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTheatreAdress.Location = new Point(149, 248);
            lblTheatreAdress.Name = "lblTheatreAdress";
            lblTheatreAdress.Size = new Size(0, 22);
            lblTheatreAdress.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 248);
            label5.Name = "label5";
            label5.Size = new Size(86, 22);
            label5.TabIndex = 4;
            label5.Text = "Manzil : ";
            // 
            // lblTheatreCity
            // 
            lblTheatreCity.Anchor = AnchorStyles.Left;
            lblTheatreCity.AutoSize = true;
            lblTheatreCity.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTheatreCity.Location = new Point(149, 197);
            lblTheatreCity.Name = "lblTheatreCity";
            lblTheatreCity.Size = new Size(0, 22);
            lblTheatreCity.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 197);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 2;
            label4.Text = "Shaxar : ";
            // 
            // lblTheatreName
            // 
            lblTheatreName.Anchor = AnchorStyles.Left;
            lblTheatreName.AutoSize = true;
            lblTheatreName.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTheatreName.Location = new Point(149, 144);
            lblTheatreName.Name = "lblTheatreName";
            lblTheatreName.Size = new Size(0, 22);
            lblTheatreName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 144);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 0;
            label2.Text = "Nomi : ";
            // 
            // close1
            // 
            close1.Dock = DockStyle.Bottom;
            close1.Location = new Point(0, 470);
            close1.Name = "close1";
            close1.Size = new Size(1146, 28);
            close1.TabIndex = 0;
            close1.Text = "↩️";
            close1.UseVisualStyleBackColor = true;
            close1.Click += close1_Click;
            close1.MouseLeave += close1_MouseLeave;
            close1.MouseHover += close1_MouseHover;
            // 
            // btnTeatrAdd
            // 
            btnTeatrAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTeatrAdd.FlatStyle = FlatStyle.System;
            btnTeatrAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnTeatrAdd.ForeColor = Color.Black;
            btnTeatrAdd.Location = new Point(1106, 70);
            btnTeatrAdd.Name = "btnTeatrAdd";
            btnTeatrAdd.Size = new Size(54, 30);
            btnTeatrAdd.TabIndex = 3;
            btnTeatrAdd.Text = "+";
            btnTeatrAdd.UseVisualStyleBackColor = true;
            btnTeatrAdd.Click += btnTeatrAdd_Click;
            btnTeatrAdd.MouseLeave += btnTeatrAdd_MouseLeave;
            btnTeatrAdd.MouseHover += btnTeatrAdd_MouseHover;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.AutoScroll = true;
            pnlMain.Controls.Add(pnlTheatreAdd);
            pnlMain.Controls.Add(pnlTeatrInfo);
            pnlMain.Location = new Point(12, 116);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1148, 508);
            pnlMain.TabIndex = 4;
            // 
            // pnlTheatreAdd
            // 
            pnlTheatreAdd.BorderStyle = BorderStyle.FixedSingle;
            pnlTheatreAdd.Controls.Add(groupBox2);
            pnlTheatreAdd.Controls.Add(groupBox1);
            pnlTheatreAdd.Controls.Add(close2);
            pnlTheatreAdd.Dock = DockStyle.Top;
            pnlTheatreAdd.Location = new Point(0, 500);
            pnlTheatreAdd.Name = "pnlTheatreAdd";
            pnlTheatreAdd.Size = new Size(1148, 1);
            pnlTheatreAdd.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(738, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(408, 0);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Teatr O'rindiqlari haqida ma'lumotlarni kiriting";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(402, 0);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Sektor";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "Qator";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Joylar soni";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSaqlash);
            groupBox1.Controls.Add(pnltxt4);
            groupBox1.Controls.Add(txtTheatreTel);
            groupBox1.Controls.Add(pnltxt3);
            groupBox1.Controls.Add(txtTheatreAdress);
            groupBox1.Controls.Add(pnltxt2);
            groupBox1.Controls.Add(txtTheatreCity);
            groupBox1.Controls.Add(pnltxt1);
            groupBox1.Controls.Add(txtTheatreName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1146, 0);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Teatr ma'lumotlarini kiriting";
            // 
            // btnSaqlash
            // 
            btnSaqlash.Anchor = AnchorStyles.None;
            btnSaqlash.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaqlash.Location = new Point(234, 105);
            btnSaqlash.Name = "btnSaqlash";
            btnSaqlash.Size = new Size(291, 64);
            btnSaqlash.TabIndex = 8;
            btnSaqlash.Text = "Saqlash";
            btnSaqlash.UseVisualStyleBackColor = true;
            // 
            // pnltxt4
            // 
            pnltxt4.Anchor = AnchorStyles.None;
            pnltxt4.BackColor = Color.FromArgb(30, 30, 30);
            pnltxt4.Location = new Point(156, 81);
            pnltxt4.Name = "pnltxt4";
            pnltxt4.Size = new Size(446, 2);
            pnltxt4.TabIndex = 7;
            // 
            // txtTheatreTel
            // 
            txtTheatreTel.Anchor = AnchorStyles.None;
            txtTheatreTel.BackColor = SystemColors.Menu;
            txtTheatreTel.BorderStyle = BorderStyle.None;
            txtTheatreTel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheatreTel.Location = new Point(156, 48);
            txtTheatreTel.Name = "txtTheatreTel";
            txtTheatreTel.PlaceholderText = "Telefon";
            txtTheatreTel.Size = new Size(446, 27);
            txtTheatreTel.TabIndex = 6;
            txtTheatreTel.TextAlign = HorizontalAlignment.Center;
            txtTheatreTel.Enter += txtTheatreTel_Enter;
            txtTheatreTel.Leave += txtTheatreTel_Leave;
            // 
            // pnltxt3
            // 
            pnltxt3.Anchor = AnchorStyles.None;
            pnltxt3.BackColor = Color.FromArgb(30, 30, 30);
            pnltxt3.Location = new Point(155, 24);
            pnltxt3.Name = "pnltxt3";
            pnltxt3.Size = new Size(446, 2);
            pnltxt3.TabIndex = 5;
            // 
            // txtTheatreAdress
            // 
            txtTheatreAdress.Anchor = AnchorStyles.None;
            txtTheatreAdress.BackColor = SystemColors.Menu;
            txtTheatreAdress.BorderStyle = BorderStyle.None;
            txtTheatreAdress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheatreAdress.Location = new Point(155, -9);
            txtTheatreAdress.Name = "txtTheatreAdress";
            txtTheatreAdress.PlaceholderText = "Manzil";
            txtTheatreAdress.Size = new Size(446, 27);
            txtTheatreAdress.TabIndex = 4;
            txtTheatreAdress.TextAlign = HorizontalAlignment.Center;
            txtTheatreAdress.Enter += txtTheatreAdress_Enter;
            txtTheatreAdress.Leave += txtTheatreAdress_Leave;
            // 
            // pnltxt2
            // 
            pnltxt2.Anchor = AnchorStyles.None;
            pnltxt2.BackColor = Color.FromArgb(30, 30, 30);
            pnltxt2.Location = new Point(155, -31);
            pnltxt2.Name = "pnltxt2";
            pnltxt2.Size = new Size(446, 2);
            pnltxt2.TabIndex = 3;
            // 
            // txtTheatreCity
            // 
            txtTheatreCity.Anchor = AnchorStyles.None;
            txtTheatreCity.BackColor = SystemColors.Menu;
            txtTheatreCity.BorderStyle = BorderStyle.None;
            txtTheatreCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheatreCity.Location = new Point(155, -64);
            txtTheatreCity.Name = "txtTheatreCity";
            txtTheatreCity.PlaceholderText = "Shaxar";
            txtTheatreCity.Size = new Size(446, 27);
            txtTheatreCity.TabIndex = 2;
            txtTheatreCity.TextAlign = HorizontalAlignment.Center;
            txtTheatreCity.Enter += txtTheatreCity_Enter;
            txtTheatreCity.Leave += txtTheatreCity_Leave;
            // 
            // pnltxt1
            // 
            pnltxt1.Anchor = AnchorStyles.None;
            pnltxt1.BackColor = Color.FromArgb(30, 30, 30);
            pnltxt1.Location = new Point(155, -88);
            pnltxt1.Name = "pnltxt1";
            pnltxt1.Size = new Size(446, 2);
            pnltxt1.TabIndex = 1;
            // 
            // txtTheatreName
            // 
            txtTheatreName.Anchor = AnchorStyles.None;
            txtTheatreName.BackColor = SystemColors.Menu;
            txtTheatreName.BorderStyle = BorderStyle.None;
            txtTheatreName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTheatreName.Location = new Point(155, -121);
            txtTheatreName.Name = "txtTheatreName";
            txtTheatreName.PlaceholderText = "Nom";
            txtTheatreName.Size = new Size(446, 27);
            txtTheatreName.TabIndex = 0;
            txtTheatreName.TextAlign = HorizontalAlignment.Center;
            txtTheatreName.Enter += txtTheatreName_Enter;
            txtTheatreName.Leave += txtTheatreName_Leave;
            // 
            // close2
            // 
            close2.Dock = DockStyle.Bottom;
            close2.Location = new Point(0, -28);
            close2.Name = "close2";
            close2.Size = new Size(1146, 28);
            close2.TabIndex = 1;
            close2.Text = "↩️";
            close2.UseVisualStyleBackColor = true;
            close2.Click += close2_Click;
            close2.MouseLeave += close1_MouseLeave;
            close2.MouseHover += close1_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 673);
            Controls.Add(pnlMain);
            Controls.Add(btnTeatrAdd);
            Controls.Add(Theatres);
            Controls.Add(pnlMenu);
            MinimumSize = new Size(1190, 720);
            Name = "Form1";
            Text = "Teatr admin";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlTeatrInfo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnlSeanse.ResumeLayout(false);
            pnlAddSeanse.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlTheatreAdd.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private System.Windows.Forms.Timer forClr;
        private Label label1;
        private Button button1;
        private ComboBox Theatres;
        private Panel pnlTeatrInfo;
        private Button btnTeatrAdd;
        private Panel pnlMain;
        private Panel pnlTheatreAdd;
        private Button close1;
        private Button close2;
        private GroupBox groupBox1;
        private TextBox txtTheatreName;
        private Panel pnltxt1;
        private Button btnSaqlash;
        private Panel pnltxt4;
        private TextBox txtTheatreTel;
        private Panel pnltxt3;
        private TextBox txtTheatreAdress;
        private Panel pnltxt2;
        private TextBox txtTheatreCity;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Label lblTheatreTel;
        private Label label6;
        private Label lblTheatreAdress;
        private Label label5;
        private Label lblTheatreCity;
        private Label label4;
        private Label lblTheatreName;
        private Label label2;
        private Panel panel1;
        private Panel pnlAddSeanse;
        private Panel pnlSeanse;
        private Panel panel2;
        private ComboBox seances;
        private Button btnSeanseAdd;
        private Panel panel3;
        private Button close3;
        private Button close4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox5;
        private Button button2;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}