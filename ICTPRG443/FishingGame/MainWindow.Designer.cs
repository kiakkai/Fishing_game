namespace FishingGame
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            button6 = new Button();
            button2 = new Button();
            numGenLabel = new Label();
            numberGenDisplay = new TextBox();
            label1 = new Label();
            label2 = new Label();
            fishNameDisplay = new TextBox();
            pointsEarnedDisplay = new TextBox();
            logoutButton = new Button();
            label9 = new Label();
            label4 = new Label();
            label5 = new Label();
            TotalFishCaught = new TextBox();
            TotalPointsEarned = new TextBox();
            button3 = new Button();
            ViewFishCaught = new ListView();
            Points = new ColumnHeader();
            KeptReleased = new ColumnHeader();
            fishname = new ColumnHeader();
            ButtonKeep = new Button();
            button_release = new Button();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            textBox1 = new TextBox();
            label10 = new Label();
            label3 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            CurrentLoadedFile = new TextBox();
            label8 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.RosyBrown;
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(503, 482);
            button6.Margin = new Padding(5, 4, 5, 4);
            button6.Name = "button6";
            button6.Size = new Size(84, 46);
            button6.TabIndex = 2;
            button6.Text = "LOAD";
            button6.UseVisualStyleBackColor = false;
            button6.Click += ButtonUserLoad;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(503, 425);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(84, 51);
            button2.TabIndex = 1;
            button2.Text = "SAVE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ButtonUserSave;
            // 
            // numGenLabel
            // 
            numGenLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            numGenLabel.AutoSize = true;
            numGenLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            numGenLabel.Location = new Point(17, 185);
            numGenLabel.Margin = new Padding(5, 0, 5, 0);
            numGenLabel.Name = "numGenLabel";
            numGenLabel.Size = new Size(71, 18);
            numGenLabel.TabIndex = 1;
            numGenLabel.Text = "NUMBER";
            numGenLabel.Click += label1_Click;
            // 
            // numberGenDisplay
            // 
            numberGenDisplay.BackColor = SystemColors.GradientActiveCaption;
            numberGenDisplay.Enabled = false;
            numberGenDisplay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numberGenDisplay.ForeColor = SystemColors.InactiveCaptionText;
            numberGenDisplay.Location = new Point(14, 206);
            numberGenDisplay.Margin = new Padding(5, 4, 5, 4);
            numberGenDisplay.Name = "numberGenDisplay";
            numberGenDisplay.Size = new Size(79, 27);
            numberGenDisplay.TabIndex = 2;
            numberGenDisplay.TextChanged += tf_NumGen;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(244, 184);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 3;
            label1.Text = "FISH NAME";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(503, 185);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 4;
            label2.Text = "POINTS";
            // 
            // fishNameDisplay
            // 
            fishNameDisplay.BackColor = SystemColors.GradientActiveCaption;
            fishNameDisplay.Enabled = false;
            fishNameDisplay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fishNameDisplay.ForeColor = SystemColors.InactiveCaptionText;
            fishNameDisplay.Location = new Point(117, 206);
            fishNameDisplay.Margin = new Padding(5, 4, 5, 4);
            fishNameDisplay.Name = "fishNameDisplay";
            fishNameDisplay.Size = new Size(341, 27);
            fishNameDisplay.TabIndex = 5;
            fishNameDisplay.TextChanged += tf_FishType;
            // 
            // pointsEarnedDisplay
            // 
            pointsEarnedDisplay.BackColor = SystemColors.GradientActiveCaption;
            pointsEarnedDisplay.Enabled = false;
            pointsEarnedDisplay.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pointsEarnedDisplay.ForeColor = SystemColors.InactiveCaptionText;
            pointsEarnedDisplay.Location = new Point(489, 206);
            pointsEarnedDisplay.Margin = new Padding(5, 4, 5, 4);
            pointsEarnedDisplay.Name = "pointsEarnedDisplay";
            pointsEarnedDisplay.Size = new Size(98, 27);
            pointsEarnedDisplay.TabIndex = 6;
            pointsEarnedDisplay.TextChanged += tf_PointsEarned;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.LightBlue;
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            logoutButton.ForeColor = Color.Black;
            logoutButton.Location = new Point(14, 2);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(88, 25);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "LOG OUT";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += ButtonUserLogOut;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(299, 24);
            label9.Name = "label9";
            label9.Size = new Size(73, 23);
            label9.TabIndex = 7;
            label9.Text = "label9";
            label9.Click += label9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(478, 33);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 17);
            label4.TabIndex = 3;
            label4.Text = "TOTAL CATCH";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(477, 101);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 17);
            label5.TabIndex = 4;
            label5.Text = "POINTS EARNED";
            label5.Click += label5_Click;
            // 
            // TotalFishCaught
            // 
            TotalFishCaught.BackColor = SystemColors.GradientActiveCaption;
            TotalFishCaught.Enabled = false;
            TotalFishCaught.ForeColor = SystemColors.InactiveCaptionText;
            TotalFishCaught.Location = new Point(479, 50);
            TotalFishCaught.Margin = new Padding(5, 3, 5, 3);
            TotalFishCaught.Name = "TotalFishCaught";
            TotalFishCaught.Size = new Size(108, 27);
            TotalFishCaught.TabIndex = 5;
            // 
            // TotalPointsEarned
            // 
            TotalPointsEarned.BackColor = SystemColors.GradientActiveCaption;
            TotalPointsEarned.Enabled = false;
            TotalPointsEarned.ForeColor = SystemColors.InactiveCaptionText;
            TotalPointsEarned.Location = new Point(479, 122);
            TotalPointsEarned.Margin = new Padding(5, 3, 5, 3);
            TotalPointsEarned.Name = "TotalPointsEarned";
            TotalPointsEarned.Size = new Size(108, 27);
            TotalPointsEarned.TabIndex = 6;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.DarkBlue;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(14, 425);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(479, 53);
            button3.TabIndex = 5;
            button3.Text = "CAST";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ViewFishCaught
            // 
            ViewFishCaught.BackColor = Color.SlateGray;
            ViewFishCaught.Columns.AddRange(new ColumnHeader[] { Points, KeptReleased, fishname });
            ViewFishCaught.ForeColor = SystemColors.InactiveBorder;
            ViewFishCaught.GridLines = true;
            ViewFishCaught.Location = new Point(17, 241);
            ViewFishCaught.Margin = new Padding(5, 4, 5, 4);
            ViewFishCaught.Name = "ViewFishCaught";
            ViewFishCaught.Size = new Size(573, 170);
            ViewFishCaught.TabIndex = 4;
            ViewFishCaught.UseCompatibleStateImageBehavior = false;
            ViewFishCaught.View = View.Details;
            // 
            // Points
            // 
            Points.Tag = "pointsColumnDisplay";
            Points.Text = "POINTS";
            Points.Width = 100;
            // 
            // KeptReleased
            // 
            KeptReleased.Tag = "keptRelColumnDisplay";
            KeptReleased.Text = "KEEP / RELEASE";
            KeptReleased.TextAlign = HorizontalAlignment.Center;
            KeptReleased.Width = 150;
            // 
            // fishname
            // 
            fishname.Tag = "nameColumnDisplay";
            fishname.Text = "NAME";
            fishname.TextAlign = HorizontalAlignment.Center;
            fishname.Width = 330;
            // 
            // ButtonKeep
            // 
            ButtonKeep.BackColor = Color.SeaGreen;
            ButtonKeep.Cursor = Cursors.Hand;
            ButtonKeep.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonKeep.Location = new Point(12, 485);
            ButtonKeep.Name = "ButtonKeep";
            ButtonKeep.Size = new Size(239, 44);
            ButtonKeep.TabIndex = 4;
            ButtonKeep.Text = "KEEP";
            ButtonKeep.UseVisualStyleBackColor = false;
            ButtonKeep.Click += button1_Click_1;
            // 
            // button_release
            // 
            button_release.BackColor = Color.Teal;
            button_release.Cursor = Cursors.Hand;
            button_release.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_release.Location = new Point(257, 485);
            button_release.Name = "button_release";
            button_release.Size = new Size(238, 43);
            button_release.TabIndex = 6;
            button_release.Text = "RELEASE";
            button_release.UseVisualStyleBackColor = false;
            button_release.Click += ButtonRelease;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.95062F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.04938F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel9.Controls.Add(label3, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(200, 100);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.95062F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.04938F));
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel11, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(90, 4);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel2.Size = new Size(107, 92);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 0);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(35, 60);
            label6.TabIndex = 3;
            label6.Text = "Caught Fish";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel11.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel11.Controls.Add(label10, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(50, 4);
            tableLayoutPanel11.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(54, 84);
            tableLayoutPanel11.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Enabled = false;
            textBox1.Location = new Point(3, 46);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(48, 27);
            textBox1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(42, 42);
            label10.TabIndex = 1;
            label10.Text = "Loaded File";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 0);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 40);
            label3.TabIndex = 3;
            label3.Text = "Caught Fish";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel10.Controls.Add(CurrentLoadedFile, 0, 1);
            tableLayoutPanel10.Controls.Add(label8, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(90, 4);
            tableLayoutPanel10.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(107, 92);
            tableLayoutPanel10.TabIndex = 4;
            // 
            // CurrentLoadedFile
            // 
            CurrentLoadedFile.Dock = DockStyle.Fill;
            CurrentLoadedFile.Enabled = false;
            CurrentLoadedFile.Location = new Point(3, 50);
            CurrentLoadedFile.Margin = new Padding(3, 4, 3, 4);
            CurrentLoadedFile.Name = "CurrentLoadedFile";
            CurrentLoadedFile.Size = new Size(101, 27);
            CurrentLoadedFile.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 1;
            label8.Text = "Loaded File";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(136, 21);
            label7.Name = "label7";
            label7.Size = new Size(137, 26);
            label7.TabIndex = 9;
            label7.Text = "WELCOME!!!";
            label7.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(330, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            AccessibleRole = AccessibleRole.ScrollBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(615, 549);
            Controls.Add(button3);
            Controls.Add(logoutButton);
            Controls.Add(button6);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(ViewFishCaught);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(TotalPointsEarned);
            Controls.Add(TotalFishCaught);
            Controls.Add(pointsEarnedDisplay);
            Controls.Add(label2);
            Controls.Add(numberGenDisplay);
            Controls.Add(fishNameDisplay);
            Controls.Add(numGenLabel);
            Controls.Add(label1);
            Controls.Add(button_release);
            Controls.Add(ButtonKeep);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fishing Game";
            Load += LoadWindow;
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button6;
        private Label numGenLabel;
        private TextBox numberGenDisplay;
        private Label label1;
        private Label label2;
        private TextBox fishNameDisplay;
        private TextBox pointsEarnedDisplay;
        private Label label4;
        private Label label5;
        private TextBox TotalFishCaught;
        private TextBox TotalPointsEarned;
        private Button logoutButton;
        private Label label9;

        private Button ButtonKeep;
        private Button button_release;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox textBox1;
        private Label label10;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel10;
        private TextBox CurrentLoadedFile;
        private Label label8;
        private Button button3;
        private ColumnHeader Points;
        private ColumnHeader KeptReleased;
        private ColumnHeader fishname;
        private ListView ViewFishCaught;
        private Label label7;
        private ColumnHeader FishName;
        private PictureBox pictureBox1;
    }
}