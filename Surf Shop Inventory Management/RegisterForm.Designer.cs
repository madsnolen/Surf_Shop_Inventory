namespace Surf_Shop_Inventory_Management
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            register_copyPassword = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            login_label = new Label();
            label2 = new Label();
            login_button = new Button();
            register_password = new TextBox();
            register_username = new TextBox();
            label1 = new Label();
            close = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(register_copyPassword);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(login_label);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(login_button);
            panel1.Controls.Add(register_password);
            panel1.Controls.Add(register_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(76, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 410);
            panel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(148, 238);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // register_copyPassword
            // 
            register_copyPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_copyPassword.Location = new Point(177, 236);
            register_copyPassword.Name = "register_copyPassword";
            register_copyPassword.PasswordChar = '*';
            register_copyPassword.Size = new Size(263, 29);
            register_copyPassword.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(148, 189);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(85, 189);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(0, 0);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(147, 146);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 29);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(226, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 89);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Cursor = Cursors.Hand;
            login_label.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_label.ForeColor = Color.RoyalBlue;
            login_label.Location = new Point(329, 346);
            login_label.Name = "login_label";
            login_label.Size = new Size(65, 16);
            login_label.TabIndex = 5;
            login_label.Text = "Sign In here";
            login_label.Click += login_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 346);
            label2.Name = "label2";
            label2.Size = new Size(131, 16);
            label2.TabIndex = 4;
            label2.Text = "Already have an account?";
            // 
            // login_button
            // 
            login_button.BackColor = Color.DodgerBlue;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_button.ForeColor = Color.White;
            login_button.Location = new Point(170, 289);
            login_button.Name = "login_button";
            login_button.Size = new Size(270, 44);
            login_button.TabIndex = 3;
            login_button.Text = "Signup";
            login_button.UseVisualStyleBackColor = false;
            // 
            // register_password
            // 
            register_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(177, 189);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(263, 29);
            register_password.TabIndex = 2;
            // 
            // register_username
            // 
            register_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username.Location = new Point(177, 143);
            register_username.Name = "register_username";
            register_username.Size = new Size(263, 29);
            register_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 108);
            label1.Name = "label1";
            label1.Size = new Size(148, 18);
            label1.TabIndex = 0;
            label1.Text = "Register Account";
            // 
            // close
            // 
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatStyle = FlatStyle.Flat;
            close.ForeColor = Color.White;
            close.Location = new Point(638, 21);
            close.Name = "close";
            close.Size = new Size(75, 23);
            close.TabIndex = 2;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click_1;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(742, 507);
            Controls.Add(panel1);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label login_label;
        private Label label2;
        private Button login_button;
        private TextBox register_password;
        private TextBox register_username;
        private Label label1;
        private Button close;
        private PictureBox pictureBox5;
        private TextBox register_copyPassword;
    }
}