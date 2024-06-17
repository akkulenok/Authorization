namespace DiplomApp
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            login = new Button();
            usernameTextBox = new TextBox();
            passswordTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(647, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.вход;
            pictureBox2.Location = new Point(209, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(280, 260);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(166, 157, 244);
            panel1.ForeColor = Color.FromArgb(166, 157, 244);
            panel1.Location = new Point(238, 250);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 1);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(166, 157, 244);
            panel2.ForeColor = Color.FromArgb(166, 157, 244);
            panel2.Location = new Point(238, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 1);
            panel2.TabIndex = 3;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(166, 157, 244);
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            login.ForeColor = Color.White;
            login.Location = new Point(209, 395);
            login.Name = "login";
            login.Size = new Size(280, 40);
            login.TabIndex = 4;
            login.Text = "LOG IN";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            usernameTextBox.ForeColor = Color.FromArgb(166, 157, 244);
            usernameTextBox.Location = new Point(270, 221);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(180, 23);
            usernameTextBox.TabIndex = 5;
            // 
            // passswordTextBox
            // 
            passswordTextBox.BorderStyle = BorderStyle.None;
            passswordTextBox.Font = new Font("Bahnschrift", 14.25F);
            passswordTextBox.ForeColor = Color.FromArgb(166, 157, 244);
            passswordTextBox.Location = new Point(270, 268);
            passswordTextBox.Name = "passswordTextBox";
            passswordTextBox.PasswordChar = '*';
            passswordTextBox.Size = new Size(180, 23);
            passswordTextBox.TabIndex = 6;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 560);
            Controls.Add(passswordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(login);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authorization";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Button login;
        private TextBox usernameTextBox;
        private TextBox passswordTextBox;
    }
}
