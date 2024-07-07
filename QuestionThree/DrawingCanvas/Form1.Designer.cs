namespace DrawingCanvas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveBtn = new ToolStripMenuItem();
            openBtn = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            blackBtn = new ToolStripButton();
            redBtn = new ToolStripButton();
            greenBtn = new ToolStripButton();
            blueBtn = new ToolStripButton();
            yellowBtn = new ToolStripButton();
            penSizeBtn = new ToolStripDropDownButton();
            smallBtn = new ToolStripMenuItem();
            mediumBtn = new ToolStripMenuItem();
            largeBtn = new ToolStripMenuItem();
            picBoard = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            toolStripButton1 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoard).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveBtn, openBtn });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveBtn
            // 
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(180, 22);
            saveBtn.Text = "Save";
            saveBtn.Click += saveToolStripMenuItem_Click;
            // 
            // openBtn
            // 
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(180, 22);
            openBtn.Text = "Open";
            openBtn.Click += openBtn_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { blackBtn, redBtn, greenBtn, blueBtn, yellowBtn, penSizeBtn, toolStripButton1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // blackBtn
            // 
            blackBtn.AutoSize = false;
            blackBtn.BackColor = Color.Black;
            blackBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            blackBtn.ForeColor = SystemColors.ButtonFace;
            blackBtn.ImageTransparentColor = Color.Magenta;
            blackBtn.Name = "blackBtn";
            blackBtn.Size = new Size(22, 22);
            blackBtn.Click += blackBtn_Click;
            // 
            // redBtn
            // 
            redBtn.AutoSize = false;
            redBtn.BackColor = Color.Red;
            redBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redBtn.ImageTransparentColor = Color.Magenta;
            redBtn.Name = "redBtn";
            redBtn.Size = new Size(22, 22);
            redBtn.Text = "toolStripButton2";
            redBtn.Click += redBtn_Click;
            // 
            // greenBtn
            // 
            greenBtn.AutoSize = false;
            greenBtn.BackColor = Color.Green;
            greenBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            greenBtn.ImageTransparentColor = Color.Magenta;
            greenBtn.Name = "greenBtn";
            greenBtn.Size = new Size(22, 22);
            greenBtn.Text = "toolStripButton3";
            greenBtn.Click += greenBtn_Click;
            // 
            // blueBtn
            // 
            blueBtn.AutoSize = false;
            blueBtn.BackColor = Color.Blue;
            blueBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            blueBtn.ImageTransparentColor = Color.Magenta;
            blueBtn.Name = "blueBtn";
            blueBtn.Size = new Size(23, 22);
            blueBtn.Text = "toolStripButton4";
            blueBtn.Click += blueBtn_Click;
            // 
            // yellowBtn
            // 
            yellowBtn.AutoSize = false;
            yellowBtn.BackColor = Color.Yellow;
            yellowBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            yellowBtn.ImageTransparentColor = Color.Magenta;
            yellowBtn.Name = "yellowBtn";
            yellowBtn.Size = new Size(22, 22);
            yellowBtn.Text = "toolStripButton5";
            yellowBtn.Click += yellowBtn_Click;
            // 
            // penSizeBtn
            // 
            penSizeBtn.AutoSize = false;
            penSizeBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            penSizeBtn.DropDownItems.AddRange(new ToolStripItem[] { smallBtn, mediumBtn, largeBtn });
            penSizeBtn.Image = (Image)resources.GetObject("penSizeBtn.Image");
            penSizeBtn.ImageTransparentColor = Color.Magenta;
            penSizeBtn.Name = "penSizeBtn";
            penSizeBtn.Size = new Size(70, 22);
            penSizeBtn.Text = "Pen size";
            // 
            // smallBtn
            // 
            smallBtn.Name = "smallBtn";
            smallBtn.Size = new Size(119, 22);
            smallBtn.Text = "Small";
            smallBtn.Click += smallBtn_Click;
            // 
            // mediumBtn
            // 
            mediumBtn.Name = "mediumBtn";
            mediumBtn.Size = new Size(119, 22);
            mediumBtn.Text = "Medium";
            mediumBtn.Click += mediumBtn_Click;
            // 
            // largeBtn
            // 
            largeBtn.Name = "largeBtn";
            largeBtn.Size = new Size(119, 22);
            largeBtn.Text = "Large";
            largeBtn.Click += largeBtn_Click;
            // 
            // picBoard
            // 
            picBoard.Dock = DockStyle.Fill;
            picBoard.Location = new Point(0, 49);
            picBoard.Name = "picBoard";
            picBoard.Size = new Size(800, 401);
            picBoard.TabIndex = 2;
            picBoard.TabStop = false;
            picBoard.MouseDown += picBoard_MouseDown;
            picBoard.MouseMove += picBoard_MouseMove;
            picBoard.MouseUp += picBoard_MouseDown;
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(70, 22);
            toolStripButton1.Text = "Clear board";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(picBoard);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Drawing Board";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveBtn;
        private ToolStripMenuItem openBtn;
        private ToolStrip toolStrip1;
        private ToolStripButton blackBtn;
        private ToolStripButton redBtn;
        private ToolStripButton greenBtn;
        private ToolStripButton blueBtn;
        private ToolStripButton yellowBtn;
        private ToolStripDropDownButton penSizeBtn;
        private ToolStripMenuItem smallBtn;
        private ToolStripMenuItem mediumBtn;
        private ToolStripMenuItem largeBtn;
        private PictureBox picBoard;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton toolStripButton1;
    }
}
