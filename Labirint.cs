using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace labirint
{
    public partial class Labirint : Form
    {
        PictureBox[,] lab = new PictureBox[10, 10];
        int[,] pole = new int[10, 10];
        public int[] m = new int[5];
        Random rnd = new Random();
        int pl_x = 0;
        int pl_y = 0;
        Boolean flag = true;
        int wallet = 0;
        int inv = 0;
        int i = 0;
        int b_x, b_y;
        bool chit = false;

        public Labirint()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            pnlLabir.Controls.Clear();
            int x, y;
            x = 2; y = 2;
            for(int i = 0; i<10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Height = 39;
                    pic.Width = 39;
                    pic.Left = x;
                    pic.Top = y;
                    pic.Visible = true;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    pic.BackgroundImage = Properties.Resources.grass1;
                    //pic.BackColor = Color.Blue;
                    lab[i, j] = pic;
                    pnlLabir.Controls.Add(lab[i, j]);
                    pole[i, j] = 0;
                    x += 40;
                }
                y += 40;
                x = 2;
            }
            btnStart.Visible = false;
            pnlCont.Visible = true;
            btnAgain.Visible = true;
            BtnAgain_Click(sender, e);
        }



        private void BtnAgain_Click(object sender, EventArgs e)
        {
            flag = true;
            pl_x = 0;
            pl_y = 0;
            if (chit)
            {
                wallet = 9990;
                inv = 1000;
            }
            lblwal.Text = wallet.ToString() + "$";
            lblinv.Text = inv.ToString() + " шт";

            //заполнение поля
            okras(0, 0, 9, 9, 0, Color.Blue,"grass");
            lab[0, 0].BackgroundImage = Properties.Resources.finish;
            lab[9,9].BackgroundImage = Properties.Resources.finish;
            pole[0, 0] = -1;
            pole[9, 9] = 6;
            int x, y, k,xl,yl,h;

          

            //случайный путь в k-h + 1 изгибов
              x = 0; y = 0; xl = 0; yl = 0;
            k = rnd.Next(3, 6);
            h = rnd.Next(0, 2);
            for (int i = h; i <= k && (x != 10 || y != 10); i++)
            {
                xl = x;
                yl = y;
                if (i % 2 == 0)
                {
                    x = pereh(x);
                }
                else
                {
                    y = pereh(y);
                }

                okras(x, y, xl, yl, -1, Color.Green, "grass");
            }

            //////////////доведение пути до конца
            xl = x;
            yl = y;
            if (k % 2 == 1)
            {
                x = 9;
            }
            else
            {
                y = 9;
            }

            okras(x, y, xl, yl,-1,Color.Green,"grass");

            xl = x;
            yl = y;
            x = 9;
            y = 9;

            okras(x, y, xl, yl,-1,Color.Green,"grass");


            //стены
            k = rnd.Next(4, 7) + 40;
            h = rnd.Next(2);
            RndTchk(k - h, "kir", 1, true);


            //расстановка объектов
            RndTchk(4, "money", 2, true);
            RndTchk(4, "bomb", 3, true);
            RndTchk(2, "gift", 5, false);

           //обозначение игрока и финиша
            lab[0, 0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("hero" + m[4]);
            lab[9,9].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("finish");
            pole[9, 9] = 6;
        }


        private void okras(int x,int y,int xl,int yl,int n,Color c,string s)
        {
            int k=n;
            for (int u = Math.Min(y, yl); u <= Math.Max(y, yl); u++)
            {
                for (int j = Math.Min(x, xl); j <= Math.Max(x, xl); j++)
                {
                    pole[j,u] = n;
                    if (n == -1) { n = 0; }
                    //lab[u, j].BackColor = c;
                    int a = rnd.Next(1, 4);
                    string sssr = s + m[n].ToString();
                    if (n == 0) { n = k; }
                    Bitmap b = (Bitmap)Properties.Resources.ResourceManager.GetObject(sssr);
                    lab[j,u].BackgroundImage = b;
                }
            }
        }

        private void RndTchk(int k,string s,int n,bool flag)
        {
            int w = 1;
            int x, y;
            while (w <= k)
            {
                x = rnd.Next(10);
                y = rnd.Next(10);
                if (pole[x, y] == 0 && (x != 0 || y != 0) && (x != 9 || y != 9))
                {
                    string sssr = s;
                    if (flag)
                    {
                        sssr += m[n];
                    }
                    Bitmap b = (Bitmap)Properties.Resources.ResourceManager.GetObject(sssr);
                    pole[x, y] = n;
                    //lab[x, y].BackColor = Color.Yellow;
                    lab[x, y].BackgroundImage = b;
                    w++;
                }
            }
        }


        private int pereh(int x)
        {
            int a;
            a = rnd.Next(0, 10);
            if (a == x)
            {
                if (x != 9) { a++; }
                else { a--; }
            }
            return a;
        }

        


        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void boom1()
        {
            if (inv >= 1)
            {
                lab[pl_x, pl_y].BackgroundImage = Properties.Resources.mine;
                b_x = pl_x;
                b_y = pl_y;
                tmrBomb.Enabled = true;
                inv--;
            }
        }

        private void Labirint_Load(object sender, EventArgs e)
        {
            FrmHello frmHello = new FrmHello();
            frmHello.ShowDialog();
            chit = frmHello.chit;
            frmHello.Dispose();
            FrmMenu frmmenu = new FrmMenu();
            frmmenu.ShowDialog();
            m = frmmenu.m;
            frmmenu.Dispose();
        }

        private void gift()
        {
            int v = rnd.Next(100);
            int k = 2;
            if (v < 80) { k = 1; }
            if (v < 40) { k = 0; }
            v = rnd.Next(200,501);
            switch (k)
            {
                case 0: MessageBox.Show("Вы подорвались на подарке(там была бомба). Конец игры.");flag=false ;break;
                case 1: MessageBox.Show("Вы нашли деньги - " + v.ToString() + "$");wallet += v;break;
                default: MessageBox.Show("Вы нашли редкость - контролируемую бомбу. Она добавлена в инвентарь.");inv+=1 ;break;
            }

            Bitmap gr = (Bitmap)Properties.Resources.ResourceManager.GetObject("grass" + m[0].ToString());
            pole[pl_x, pl_y] = 0;
            lab[pl_x, pl_y].BackgroundImage = gr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream myFile;
            myFile = new FileStream("save.kolya", FileMode.OpenOrCreate);
            StreamWriter myfile_1;
            myfile_1 = new StreamWriter(myFile);
            string abc;
            abc = wallet.ToString() + " " + inv.ToString();
            myfile_1.WriteLine(abc);

            myfile_1.Close();
        }

        private void tmrBomb_Tick(object sender, EventArgs e)
        {
            i += 1;
            if (i == 3)
            {
                lab[b_x, b_y].BackgroundImage = Properties.Resources.boom;
            }
            if (i == 4)
            {
                int a, b,c,d;
                a = cont(b_x + 1);
                b = cont(b_x - 1);
                c = cont(b_y + 1);
                d = cont(b_y - 1);
                okras(a, c, b, d, 0, Color.White, "grass");
                tmrBomb.Enabled = false;
                i = 0;
            }
        }

        int cont(int a)
        {
            if (a > 9) { a = 9; }
            if (a < 0) { a = 0; }
            return a;
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            FrmHello frmHello = new FrmHello();
            frmHello.ShowDialog();
            frmHello.Dispose();
            BtnAgain_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmmenu = new FrmMenu();
            frmmenu.m = m;
            frmmenu.ShowDialog();
            m = frmmenu.m;
            frmmenu.Dispose();
            BtnAgain_Click(sender, e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (wallet >= 999)
            {
                wallet -= 999;
                inv += 1;
                lblwal.Text = wallet.ToString() + "$";
                lblinv.Text = inv.ToString() + " шт";
            }
            else
            {
                MessageBox.Show("Недостаточно средств", "Денег нет,но Вы держитесь", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Labirint_KeyDown(object sender, KeyEventArgs e)
        {
            bool flag1 = true;
            if (flag)
            {
                lab[pl_x, pl_y].Image = null;
                switch (e.KeyCode)
                {
                    case Keys.NumPad8: pl_x--; break;
                    case Keys.NumPad2: pl_x++; break;
                    case Keys.NumPad4: pl_y--; break;
                    case Keys.NumPad6: pl_y++; break;
                    case Keys.M: flag1 = false; boom1(); break;
                    default: break;
                }
                if (flag1)
                {
                    if (pl_x >= 0 && pl_x <= 9 && pl_y >= 0 && pl_y <= 9)
                    {
                        int a = pole[pl_x, pl_y];
                        switch (a)
                        {
                            case 1: MessageBox.Show("Вы врезались в стену. Конец игры."); flag = false; break;
                            case 2: MessageBox.Show("Вы собрали 100$!"); wallet += 100;okras(pl_x,pl_y,pl_x,pl_y,0,Color.Black,"grass") ; break;
                            case 3: MessageBox.Show("Вы подорвались на бомбе. Конец игры."); flag = false; lab[pl_x, pl_y].BackgroundImage = Properties.Resources.boom; break;
                            case 5: MessageBox.Show("Вы подобрали  подарок."); gift(); okras(pl_x, pl_y, pl_x, pl_y, 0, Color.Black, "grass"); break;
                            case 6: MessageBox.Show("Поздравляю! Вы прошли уровень."); BtnAgain_Click(sender,e); break;

                        default:
                                {
                                    string s = "hero" + m[4].ToString();
                                    object o = Properties.Resources.ResourceManager.GetObject(s);
                                    lab[pl_x, pl_y].Image = (Bitmap)o;
                                }
                                break;
                        }
                        //okras(pl_x, pl_y, pl_x, pl_y, 0, Color.White, "grass");
                        lblinv.Text = inv.ToString() + " шт";
                        lblwal.Text = wallet.ToString() + "$";
                    }
                    else
                    {
                        MessageBox.Show("Вы вышли за поле. Конец игры.");
                        flag = false;
                    }
                    if (!flag)
                    {
                        wallet = 0;
                        inv = 0;
                    }
                }
                if (flag) { lab[pl_x, pl_y].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("hero" + m[4]); }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            StreamReader myfile;
            myfile = new StreamReader("save.kolya");
            string klmn = "";
            string abc;
            while ((abc = myfile.ReadLine()) != null)
            {

                klmn += abc + "\r\n";
            }
            int n = klmn.IndexOf(" ");
            wallet =int.Parse( klmn.Substring(0, n));
            inv = int.Parse(klmn.Substring(n + 1, klmn.Length - n - 1));
            lblwal.Text = wallet.ToString() + "$";
            lblinv.Text = inv.ToString() + " шт";
            myfile.Close();
        }


        //путь без пересечений(недоделанный)

        //int x, y;
        //x = 0;y = 0;
        //int w = 0;
        //int len = 0;
        //int[] way = new int[4];
        //while( x != 10 || y!=10)
        //{
        //    w = rnd.Next(4);
        //    int a, b, c;
        //    a = 0;
        //    if (w <= 1) { a = 10; }
        //    b = x;
        //    if (w % 2 == 1) { b = y; }
        //    c = Math.Abs(a - b);
        //    way[w] = 1;

        //    if (c != 0)
        //    {
        //        len = rnd.Next(1, c + 1);

        //    }
        //}

        //длинные стены


        //xl = x;
        //yl = y;
        //if (i % 2 == 0)
        //{
        //    x = rnd.Next(10);
        //}
        //else
        //{
        //    y = rnd.Next(10);
        //}
        //okras(x, y, xl, yl, 3, Color.Red);



        //путь без пересечений(недоделанный) версия 2

        //x = 0; y = 0;
        //int w = 0;
        //int len = 4;
        //int[] way = new int[4];
        //while (x != 10 || y != 10)
        //{
        //    w = rnd.Next(4);
        //    xl = x;yl = y;
        //    int a;
        //    a = 0;
        //    if (w <= 1) { a = 10; }
        //    if (w % 2 == 0) 
        //    {
        //        x = way1(a, x, len); 
        //    }
        //    else
        //    {
        //        y = way1(a, x, len);
        //    }
        //    way[w] = 1;
        //    for(int r=1;)
        //    if (flag) { }

        //}


        //bool prov(int x,int y,int xl,int yl)
        //{

        //    return true;
        //}

        //private int way1(int a,int x,int len)
        //{
        //    int b = rnd.Next(Math.Min(a, x), Math.Max(a, x) + 1);
        //    int c = Math.Abs(b - x);
        //    if (c > len) { x += c % len * c / (b - x); }
        //    return x;
        //}


        //другие стены
        //for (int i = h; i <= k; i++)
        //{
        //    x = rnd.Next(10);
        //    y = rnd.Next(10);
        //    if (pole[x, y] == 0)
        //    {
        //        okras(x, y, x, y, 1, Color.Red, "kir");
        //    }
        //}
    }
}
