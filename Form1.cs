namespace ev_tapsirigi16
{
    public partial class Form1 : Form
    {
        private void OyunuBaslat()
        {
            addimSayi = 0;
            lblAddim.Text = "Addım: 0";

            picSolAdam.Left = 195;
            picSagAdam.Left = 195;

            picSolAdam.Visible = false;
            picSagAdam.Visible = false;

            picBomba.Left = random.Next(0, this.ClientSize.Width - picBomba.Width);
            picBomba.Top = 0;

            picBomba2.Left = random.Next(0, this.ClientSize.Width - picBomba2.Width);
            picBomba2.Top = -250;

            picBomba.Visible = true;
            picBomba2.Visible = true;

            oyunAktivdir = true;
            timerOyun.Start();
        }

        private void OyunuBitir()
        {
            timerOyun.Stop();
            oyunAktivdir = false;

            MessageBox.Show(
                "Oyun bitdi! Sizin nəticə: " + addimSayi,
                "Məlumat",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            DialogResult cavab = MessageBox.Show(
                "Yeni oyun başlasınmı?",
                "Məlumat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            if (cavab == DialogResult.Yes)
            {
                OyunuBaslat();
            }
            else
            {
                Application.Exit();
            }
        }

        int addimSayi = 0;
        int bombaSureti = 8;
        int suret = 20;

        Random random = new Random();

        bool oyunAktivdir = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int suret = 20;

            picSolAdam.Visible = false;
            picSagAdam.Visible = false;

            if (e.KeyCode == Keys.Left)
            {
                if (picSolAdam.Left >= suret)
                {
                    picSolAdam.Left -= suret;
                    picSagAdam.Left -= suret;
                }

                picSolAdam.Visible = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (picSagAdam.Right + suret <= this.ClientSize.Width)
                {
                    picSolAdam.Left += suret;
                    picSagAdam.Left += suret;
                }

                picSagAdam.Visible = true;
            }
        }

        private void timerOyun_Tick(object sender, EventArgs e)
        {
            if (!oyunAktivdir)
                return;

            // Birinci bomba
            picBomba.Top += bombaSureti;

            if (picBomba.Bounds.IntersectsWith(picSolAdam.Bounds) ||
                picBomba.Bounds.IntersectsWith(picSagAdam.Bounds))
            {
                OyunuBitir();
                return;
            }

            if (picBomba.Top >= this.ClientSize.Height)
            {
                addimSayi++;
                lblAddim.Text = "Addım: " + addimSayi;

                picBomba.Top = -picBomba.Height;
                picBomba.Left = random.Next(0, this.ClientSize.Width - picBomba.Width);
            }

            // İkinci bomba
            picBomba2.Top += bombaSureti;

            if (picBomba2.Bounds.IntersectsWith(picSolAdam.Bounds) ||
                picBomba2.Bounds.IntersectsWith(picSagAdam.Bounds))
            {
                OyunuBitir();
                return;
            }

            if (picBomba2.Top >= this.ClientSize.Height)
            {
                addimSayi++;
                lblAddim.Text = "Addım: " + addimSayi;

                picBomba2.Top = -picBomba2.Height;
                picBomba2.Left = random.Next(0, this.ClientSize.Width - picBomba2.Width);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OyunuBaslat();
        }
    }
}
