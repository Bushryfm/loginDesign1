namespace LoginDesign
{
    partial class Home
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(148, 85);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 779);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumPurple;
            button3.Location = new Point(85, 549);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(452, 87);
            button3.TabIndex = 0;
            button3.Text = "CloudPos";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumPurple;
            button2.Location = new Point(85, 298);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(452, 87);
            button2.TabIndex = 0;
            button2.Text = "POS";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Location = new Point(85, 64);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(452, 87);
            button1.TabIndex = 0;
            button1.Text = "ERP";
            button1.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1364, 732);
            Controls.Add(panel1);
            Cursor = Cursors.SizeAll;
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}