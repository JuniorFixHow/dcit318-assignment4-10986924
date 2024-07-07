namespace AddressBook
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
            errorLbl = new Label();
            clearBtn = new Button();
            saveBtn = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            phoneTxt = new TextBox();
            label4 = new Label();
            emailTxt = new TextBox();
            label3 = new Label();
            nameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            button1.Location = new Point(742, -2);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(60, 46);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(errorLbl);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(phoneTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(emailTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nameTxt);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(75, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 352);
            panel1.TabIndex = 1;
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLbl.Location = new Point(207, 232);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(0, 21);
            errorLbl.TabIndex = 5;
            errorLbl.Visible = false;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Orange;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(303, 259);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(111, 37);
            clearBtn.TabIndex = 4;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Teal;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(420, 259);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(111, 37);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Location = new Point(207, 220);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(324, 1);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(207, 161);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 1);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(207, 108);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 1);
            panel2.TabIndex = 2;
            // 
            // phoneTxt
            // 
            phoneTxt.BorderStyle = BorderStyle.None;
            phoneTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneTxt.Location = new Point(207, 192);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.PlaceholderText = "enter phone number";
            phoneTxt.Size = new Size(324, 26);
            phoneTxt.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(120, 192);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 0;
            label4.Text = "Phone: ";
            // 
            // emailTxt
            // 
            emailTxt.BorderStyle = BorderStyle.None;
            emailTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.Location = new Point(207, 133);
            emailTxt.Name = "emailTxt";
            emailTxt.PlaceholderText = "enter email";
            emailTxt.Size = new Size(324, 26);
            emailTxt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(120, 133);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 0;
            label3.Text = "Email: ";
            // 
            // nameTxt
            // 
            nameTxt.BorderStyle = BorderStyle.None;
            nameTxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxt.Location = new Point(207, 80);
            nameTxt.Name = "nameTxt";
            nameTxt.PlaceholderText = "enter name";
            nameTxt.Size = new Size(324, 26);
            nameTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 80);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 0;
            label2.Text = "Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(283, 27);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(245, 50);
            label1.TabIndex = 2;
            label1.Text = "New Contact";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private TextBox nameTxt;
        private Panel panel4;
        private Panel panel3;
        private TextBox phoneTxt;
        private Label label4;
        private TextBox emailTxt;
        private Label label3;
        private Button clearBtn;
        private Button saveBtn;
        private Label errorLbl;
    }
}
