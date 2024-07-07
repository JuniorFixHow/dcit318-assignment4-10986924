namespace DrawingCanvas
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = new Bitmap(1920, 1080);
        Pen pen = new Pen(Color.Black, 5);
        bool drawMode = false;
        int penSize = 5;
        Image openedImage;
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.White);
                }
            }
        }

        private void picBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if (drawMode)
            {
                drawMode = false;
            }
            else
            {
                drawMode = true;
            }
        }

        private void picBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawMode)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawRectangle(pen, e.X, e.Y, penSize, penSize);
                picBoard.Image = bitmap;
            }
        }

        private void blackBtn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void blueBtn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void yellowBtn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
        }

        private void smallBtn_Click(object sender, EventArgs e)
        {
            penSize = 5;
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            penSize = 10;
        }

        private void largeBtn_Click(object sender, EventArgs e)
        {
            penSize = 15;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg Image|*.jpg|Btimap Image *.bmp|";
            saveFileDialog.Title = "Save your work";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        this.picBoard.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        return;
                    case 2:
                        this.picBoard.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        return;
                }
                fs.Close();
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult openResult = openFile.ShowDialog();
            if (openResult == DialogResult.OK)
            {
                openedImage = Image.FromFile(openFile.FileName);
                picBoard.Image = openedImage;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(picBoard.BackColor);
            }
            picBoard.Image = bitmap;
            picBoard.Invalidate();
        }
    }
}
