namespace LoginDesign
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            PictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            Login = new Button();
            txtExit = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ScrollBar;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Screenshot__13_;
            pictureBox1.Location = new Point(324, 25);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(365, 169);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 60);
            label1.TabIndex = 1;
            label1.Text = "Log In";
            label1.Click += label1_Click;
            // 
            // PictureBox2
            // 
            PictureBox2.BorderStyle = BorderStyle.Fixed3D;
            PictureBox2.Image = Properties.Resources.icons8_username_50;
            PictureBox2.Location = new Point(196, 282);
            PictureBox2.Margin = new Padding(4);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(54, 54);
            PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBox2.TabIndex = 2;
            PictureBox2.TabStop = false;
            PictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Image = Properties.Resources.icons8_password_50;
            pictureBox3.Location = new Point(196, 404);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Location = new Point(196, 335);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 1);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Location = new Point(196, 457);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 1);
            panel2.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Lavender;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = SystemColors.InfoText;
            txtUserName.Location = new Point(258, 287);
            txtUserName.Margin = new Padding(4);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(385, 45);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Lavender;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.InfoText;
            txtPassword.Location = new Point(260, 409);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(385, 45);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // Login
            // 
            Login.BackColor = Color.MediumPurple;
            Login.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.ButtonHighlight;
            Login.Location = new Point(196, 494);
            Login.Margin = new Padding(4);
            Login.Name = "Login";
            Login.Size = new Size(486, 67);
            Login.TabIndex = 8;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // txtExit
            // 
            txtExit.AutoSize = true;
            txtExit.BackColor = Color.GhostWhite;
            txtExit.BorderStyle = BorderStyle.Fixed3D;
            txtExit.ForeColor = Color.MediumPurple;
            txtExit.Location = new Point(283, 609);
            txtExit.Name = "txtExit";
            txtExit.Size = new Size(61, 32);
            txtExit.TabIndex = 9;
            txtExit.Text = "EXIT";
            txtExit.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = Color.MediumPurple;
            label2.Location = new Point(518, 609);
            label2.Name = "label2";
            label2.Size = new Size(127, 32);
            label2.TabIndex = 10;
            label2.Text = "CLEAR TXT";
            label2.Click += label2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(850, 661);
            Controls.Add(label2);
            Controls.Add(txtExit);
            Controls.Add(Login);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(PictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox PictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button Login;
        private Label txtExit;
        private Label label2;
    }
}
