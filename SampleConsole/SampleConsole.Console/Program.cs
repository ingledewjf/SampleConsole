namespace SampleConsole.Console
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;
    using BusinessLogic;

    class Program
    {
        private static const int width = 500;
        private static const int height = 500;
    
        static void Main(string[] args)
        {
            // Create a form to display
            Form form = new Form {Width = width, Height = height};
            PictureBox box = new PictureBox { BackColor = Color.White, Dock = DockStyle.Fill};
            Bitmap image = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(image);
            SolidBrush brush = new SolidBrush(Color.FromArgb(0,0,0));

            box.Image = image;
            form.Controls.Add(box);

            // draw a recursive tree
            Tree tree = new Tree(graphics, brush);
            tree.Branch(0, 250.0, 50.0, (Math.PI * 0.5), 90.0, 10.0, height, 8);
            // todo add modification from the console to produce different trees

            form.ShowDialog();
        }
    }
}
