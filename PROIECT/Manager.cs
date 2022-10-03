using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT
{
    public partial class Manager : Form
    {
        public Manager()
        {
            
            InitializeComponent();
            nou();
            g.FillRectangle(new SolidBrush(Color.White), p.DisplayRectangle);

            shapes.DropDownItems.Add("Linie", imageList.Images[0]);
            shapes.DropDownItems.Add("Triunghi", imageList.Images[1]);
            shapes.DropDownItems.Add("Elipsa", imageList.Images[2]);
            shapes.DropDownItems.Add("Dreptunghi", imageList.Images[3]);
            shapes.DropDownItems.Add("Curba Bezier", imageList.Images[4]);

            form.ButtonClicked += ButtonClicked;
        }

       
        Figura f = null;
        Bitmap img;
        Graphics g;
        int apasat = 0;
        public Color color_target;

        public struct culori
        {
            public Color c;
            public int nrPixeli;

        };

        public List<culori> lista_culori = new List<culori>();

        void nou()
        {
            img = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(img);

        }

        //----------DESENARE FIGURI-----------
        private void shapes_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (Convert.ToString(e.ClickedItem))
            {
                case "Linie":
                    f = new Linie();
                    break;
                case "Triunghi":
                    f = new Triunghi();
                    break;
                case "Elipsa":
                    f = new Elipsa();
                    break;
                case "Dreptunghi":
                    f = new Dreptunghi();
                    break;
                case "Curba Bezier":
                    f = new CurbaBezier();
                    break;
            }
        }
        private void play_Click(object sender, EventArgs e)
        {
            try
            {
                int nr = Convert.ToInt32(number.Text);
                while (nr > 0)
                {

                    f.deseneaza(g);
                    nr--;
                }
            }
            catch
            { MessageBox.Show("Introduceti un numar!"); }            
            p.Invalidate();


        }
       

        //----------COLORARE-----------
        private void color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            color_target = cd.Color;
        }

        void umplere(int l, int c, Color cprimita)
        {

            culori cul_temp = new culori();
            cul_temp.nrPixeli = 4 * (img.Width + img.Height - 4);
            cul_temp.c = cprimita;


            Stack<Point> pixels = new Stack<Point>();
            Color cavuta = img.GetPixel(l, c);
            Point point = new Point(l, c);
            pixels.Push(point);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X <= img.Width && a.X >= 0 &&
                a.Y <= img.Height && a.Y >= 0)
                {
                    if (img.GetPixel(a.X, a.Y) == cavuta)
                    {
                        cul_temp.nrPixeli++;
                        img.SetPixel(a.X, a.Y, cprimita);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }

            lista_culori.Add(cul_temp);
            return;
        }

        private void p_MouseDown(object sender, MouseEventArgs e)
        {
            if (apasat % 2 == 1)
                umplere(e.X, e.Y, color_target);
            p.Invalidate();

        }

        private void fill_Click(object sender, EventArgs e)
        {
            apasat++;
        }


        //----------CALCUL CERNEALA-------


       public double cC = 0, cM = 0, cY = 0, cK = 0;
       Form1 form = new Form1();

        public void calcul()
        {

            int l = Convert.ToInt32(form.lungime.Text);
            int L = Convert.ToInt32(form.latime.Text);
            int c = Convert.ToInt32(form.consum.Text);
           
            int p = 0;
            double S = 0;
            
            foreach (culori i in lista_culori)
            {

                p = (i.nrPixeli * 100) / (img.Width * img.Height);

                S = l * L * p / 100;
               
                Byte R = i.c.R;
                Byte G = i.c.G;
                Byte B = i.c.B;

                double R1 = i.c.R / 255;
                double G1 = i.c.G / 255;
                double B1 = i.c.B / 255;

                double C = 0, M = 0, Y = 0;

                double K = 1 - Math.Max(R1, Math.Max(G1, B1));

                if (K != 1)
                {
                    C = (1 - R1 - K) / (1 - K);
                    M = (1 - G1 - K) / (1 - K);
                    Y = (1 - B1 - K) / (1 - K);
                }

                double cT = S / c;
                
                cC = cC + (cT * C / (C + M + Y + K));
                cM = cM + (cT * M / (C + M + Y + K));
                cY = cY + (cT * Y / (C + M + Y + K));
                cK = cK + (cT * K / (C + M + Y + K));
            
            }
          
        }

        private void ink_Click(object sender, EventArgs e)
        {
            form.Show();    
        }

        public void ButtonClicked(object sender,EventArgs e)
        {
            calcul();
            form.val_C.Text = Convert.ToString(cC);
            form.val_M.Text = Convert.ToString(cM);
            form.val_Y.Text = Convert.ToString(cY);
            form.val_B.Text = Convert.ToString(cK);

        }

        private void p_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0, p.Width, p.Height);
        }

        //------------SALVARE--------------
        void salveaza()
        {
            Image img1 = new Bitmap(p.Width, p.Height);
            Graphics g1 = Graphics.FromImage(img1);
            g1.DrawImage(img, 0, 0, p.Width, p.Height);
            try
            {
                sf.DefaultExt = "png";
                sf.FileName = "Figura.png";
                sf.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
                sf.FilterIndex = 1;
                sf.RestoreDirectory = true;
                sf.ShowDialog();
                img1.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception) { }
        }

        private void save_Click(object sender, EventArgs e)
        {
            salveaza();
        }

        //------------IMPRIMARE--------------

        void imprimare()
        {
            if (pd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            imprimare();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show("Imprimare terminata.", "Imprimare");
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            nou();
            p.Refresh();
            
        }

    }

    //------------CLASA FIGURA--------------
    public abstract class Figura : Manager
    {
        public Pen pen = new Pen(Color.Black, 3);
        public Random r = new Random();
        public Point[] points = new Point[4];
       
        public abstract void deseneaza(Graphics g);
    }

    public class Linie : Figura
    {
        public override void deseneaza(Graphics g)
        {
            for (int i = 0; i < 2; i++)
            {
                points[i].X = r.Next(0, p.Width);
                points[i].Y = r.Next(0, p.Height);
            }
            g.DrawLine(pen, points[0], points[1]);
           
        }
    }

    public class Triunghi : Figura
    {

        public override void deseneaza(Graphics g)
        {

            for (int i = 0; i < 3; i++)
            {
                points[i].X = r.Next(0, p.Width);
                points[i].Y = r.Next(0, p.Height);
            }
            points[3].X = points[0].X;
            points[3].Y = points[0].Y;
            g.DrawLines(pen, points);

        }
    }

    public class Elipsa : Figura
    {
        public override void deseneaza(Graphics g)
        {

            int x1 = r.Next(0, p.Width);
            int y1 = r.Next(0, p.Height);
            int w = r.Next(0, p.Width);
            int h = r.Next(0, p.Height);
            while (x1 + w > p.Width)
                w = r.Next(0, p.Width);
            while (y1 + h > p.Height)
                h = r.Next(0, p.Height);
            g.DrawEllipse(pen, new Rectangle(x1, y1, w, h));
        }
    }
    public class Dreptunghi : Figura
    {
        public override void deseneaza(Graphics g)
        {

            int x1 = r.Next(0, p.Width);
            int y1 = r.Next(0, p.Height);
            int w = r.Next(0, p.Width);
            int h = r.Next(0, p.Height);
            while (x1 + w > p.Width)
                w = r.Next(0, p.Width);
            while (y1 + h > p.Height)
                h = r.Next(0, p.Height);
            g.DrawRectangle(pen, x1, y1, w, h);

        }
    }

    public class CurbaBezier : Figura
    {
        public override void deseneaza(Graphics g)
        {
            for (int i = 0; i < 4; i++)
            {
                points[i].X = r.Next(0, p.Width);
                points[i].Y = r.Next(0, p.Height);
            }

            g.DrawBezier(pen, points[0], points[1], points[2], points[3]);

        }
    }

   
}







