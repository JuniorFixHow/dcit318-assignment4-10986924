namespace LoginSystem
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
            button1 = new Button();
            panel1 = new Panel();
            loginBtn = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pwdText = new TextBox();
            userText = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.icons8_close_48;
            button1.Location = new Point(748, -1);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(52, 47);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(200, 112, 126);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pwdText);
            panel1.Controls.Add(userText);
            panel1.Location = new Point(234, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 286);
            panel1.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Teal;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(184, 198);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(88, 33);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Location = new Point(32, 177);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 1);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(32, 130);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 1);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 50);
            label1.TabIndex = 1;
            label1.Text = "Sign in";
            // 
            // pwdText
            // 
            pwdText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pwdText.BackColor = Color.FromArgb(200, 112, 126);
            pwdText.BorderStyle = BorderStyle.None;
            pwdText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pwdText.ForeColor = Color.White;
            pwdText.Location = new Point(32, 150);
            pwdText.Name = "pwdText";
            pwdText.PlaceholderText = "Enter password";
            pwdText.Size = new Size(240, 26);
            pwdText.TabIndex = 0;
            pwdText.UseSystemPasswordChar = true;
            // 
            // userText
            // 
            userText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userText.BackColor = Color.FromArgb(200, 112, 126);
            userText.BorderStyle = BorderStyle.None;
            userText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userText.ForeColor = Color.White;
            userText.Location = new Point(32, 103);
            userText.Name = "userText";
            userText.PlaceholderText = "Enter username";
            userText.Size = new Size(240, 26);
            userText.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 517);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private TextBox userText;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox pwdText;
        private Button loginBtn;
    }
}
