namespace FishingGame
{
    partial class registerform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerform));
            picbox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBoxShowPassword = new CheckBox();
            txtUsername = new TextBox();
            buttonRegistration = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtcompassword = new TextBox();
            txtpassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            SuspendLayout();
            // 
            // picbox
            // 
            picbox.Enabled = false;
            picbox.ErrorImage = (Image)resources.GetObject("picbox.ErrorImage");
            picbox.Image = (Image)resources.GetObject("picbox.Image");
            picbox.InitialImage = (Image)resources.GetObject("picbox.InitialImage");
            picbox.Location = new Point(39, 8);
            picbox.Name = "picbox";
            picbox.Size = new Size(266, 128);
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox.TabIndex = 0;
            picbox.TabStop = false;
            picbox.Click += picbox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(61, 153);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "USERNAME";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(60, 216);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(61, 273);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 3;
            label3.Text = "COMFIRM PASSWORD";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Cursor = Cursors.Hand;
            checkBoxShowPassword.FlatStyle = FlatStyle.Flat;
            checkBoxShowPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxShowPassword.Location = new Point(157, 326);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(117, 21);
            checkBoxShowPassword.TabIndex = 4;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.DarkSlateBlue;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = SystemColors.Window;
            txtUsername.Location = new Point(61, 173);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 27);
            txtUsername.TabIndex = 5;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = Color.FromArgb(116, 86, 174);
            buttonRegistration.Cursor = Cursors.Hand;
            buttonRegistration.FlatAppearance.BorderSize = 0;
            buttonRegistration.FlatStyle = FlatStyle.Flat;
            buttonRegistration.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistration.ForeColor = SystemColors.ButtonHighlight;
            buttonRegistration.Location = new Point(61, 374);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(216, 40);
            buttonRegistration.TabIndex = 8;
            buttonRegistration.Text = "REGISTER";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(116, 86, 174);
            button1.Location = new Point(61, 420);
            button1.Name = "button1";
            button1.Size = new Size(216, 40);
            button1.TabIndex = 11;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(78, 509);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 20);
            textBox3.TabIndex = 13;
            textBox3.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Location = new Point(87, 509);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 14;
            label4.Text = "Already Have an Account ?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(114, 532);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 15;
            label5.Text = "Back to LOGIN";
            label5.Click += label5_Click;
            // 
            // txtcompassword
            // 
            txtcompassword.BackColor = Color.DarkSlateBlue;
            txtcompassword.BorderStyle = BorderStyle.None;
            txtcompassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtcompassword.ForeColor = SystemColors.Window;
            txtcompassword.Location = new Point(60, 293);
            txtcompassword.Name = "txtcompassword";
            txtcompassword.PasswordChar = '*';
            txtcompassword.Size = new Size(214, 27);
            txtcompassword.TabIndex = 16;
            txtcompassword.TextChanged += txtcompassword_TextChanged_1;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.DarkSlateBlue;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.ForeColor = SystemColors.Window;
            txtpassword.Location = new Point(60, 236);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(214, 27);
            txtpassword.TabIndex = 16;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // registerform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(330, 561);
            Controls.Add(txtpassword);
            Controls.Add(txtcompassword);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(buttonRegistration);
            Controls.Add(txtUsername);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registerform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxShowPassword;
        private TextBox txtUsername;
        private Button buttonRegistration;
        private Button button1;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox txtcompassword;
        private TextBox txtpassword;
    }
}