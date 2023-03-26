namespace FishingGame
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            buttonclear = new Button();
            buttonlogin = new Button();
            txtUsername = new TextBox();
            checkBoxShowPassword = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            picbox = new PictureBox();
            txtpassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(102, 523);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 28;
            label5.Text = "Create Account";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Location = new Point(75, 500);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 27;
            label4.Text = "Don't Have an Account ?";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(66, 500);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 20);
            textBox3.TabIndex = 26;
            textBox3.Text = " ";
            // 
            // buttonclear
            // 
            buttonclear.BackColor = Color.White;
            buttonclear.Cursor = Cursors.Hand;
            buttonclear.FlatAppearance.BorderSize = 0;
            buttonclear.FlatStyle = FlatStyle.Flat;
            buttonclear.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonclear.ForeColor = Color.FromArgb(116, 86, 174);
            buttonclear.Location = new Point(52, 399);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(216, 40);
            buttonclear.TabIndex = 25;
            buttonclear.Text = "CLEAR";
            buttonclear.UseVisualStyleBackColor = false;
            buttonclear.Click += buttonclear_Click;
            // 
            // buttonlogin
            // 
            buttonlogin.BackColor = Color.FromArgb(116, 86, 174);
            buttonlogin.Cursor = Cursors.Hand;
            buttonlogin.FlatAppearance.BorderSize = 0;
            buttonlogin.FlatStyle = FlatStyle.Flat;
            buttonlogin.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonlogin.ForeColor = SystemColors.ButtonHighlight;
            buttonlogin.Location = new Point(52, 353);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(216, 40);
            buttonlogin.TabIndex = 22;
            buttonlogin.Text = "LOGIN";
            buttonlogin.UseVisualStyleBackColor = false;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.DarkSlateBlue;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = SystemColors.InactiveBorder;
            txtUsername.Location = new Point(54, 221);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 27);
            txtUsername.TabIndex = 21;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.FlatStyle = FlatStyle.Flat;
            checkBoxShowPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxShowPassword.Location = new Point(151, 314);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(117, 21);
            checkBoxShowPassword.TabIndex = 20;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(51, 261);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 18;
            label2.Text = "PASSWORD";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(52, 198);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 17;
            label1.Text = "USERNAME";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // picbox
            // 
            picbox.Enabled = false;
            picbox.ErrorImage = (Image)resources.GetObject("picbox.ErrorImage");
            picbox.Image = (Image)resources.GetObject("picbox.Image");
            picbox.InitialImage = (Image)resources.GetObject("picbox.InitialImage");
            picbox.Location = new Point(23, 12);
            picbox.Name = "picbox";
            picbox.Size = new Size(281, 155);
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox.TabIndex = 16;
            picbox.TabStop = false;
            picbox.Click += picbox_Click;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.DarkSlateBlue;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.ForeColor = SystemColors.InactiveBorder;
            txtpassword.Location = new Point(54, 281);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(214, 27);
            txtpassword.TabIndex = 29;
            txtpassword.TextChanged += textBoxlogin_TextChanged;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(330, 561);
            Controls.Add(txtpassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(buttonclear);
            Controls.Add(buttonlogin);
            Controls.Add(txtUsername);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginform";
            Load += loginform_Load;
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private Button buttonclear;
        private Button buttonlogin;
        private TextBox txtUsername;
        private CheckBox checkBoxShowPassword;
        private Label label2;
        private Label label1;
        private PictureBox picbox;
        private TextBox txtpassword;
    }
}