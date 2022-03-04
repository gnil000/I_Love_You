namespace Lera2
{
    public partial class Form1 : Form
    {
        private int ticks =0;

        string[] nameImage = {
            @"..\..\..\Resources\99kfh7iBIwc.jpg",
            @"..\..\..\Resources\bcs_UjazTRw.jpg",
            @"..\..\..\Resources\Bn7ci5L-9ZU.jpg",
            @"..\..\..\Resources\gI03DRs0Wz4.jpg",
            @"..\..\..\Resources\HFwVfVNtl2A.jpg",
            @"..\..\..\Resources\Lzki6viCZc0.jpg",
            @"..\..\..\Resources\mMIbkoMF_qc.jpg",
            @"..\..\..\Resources\N0uLup1uPgc.jpg",
            @"..\..\..\Resources\Nk-BXMmqOq0.jpg",
            @"..\..\..\Resources\s06gzra-gyc.jpg",
            @"..\..\..\Resources\S28A-9NmER4.jpg",
            @"..\..\..\Resources\t9RNV-z8DJs.jpg",
            @"..\..\..\Resources\UGgIx5fQlZc.jpg",
            @"..\..\..\Resources\XFnrpPQy1wo.jpg",
            @"..\..\..\Resources\xgCSZ2wN9I8.jpg",
            @"..\..\..\Resources\Без имени.png",
            @"..\..\..\Resources\3gf536P743c.jpg",
            @"..\..\..\Resources\9af513b163607cfc8aec2d7e98e5aff7.jpg",
            @"..\..\..\Resources\Bn7ci5L-9ZU.jpg",
            @"..\..\..\Resources\dB41z99hD0U.jpg",
            @"..\..\..\Resources\DtzhFZFyTYI.jpg",
            @"..\..\..\Resources\g2p_XGg5wPE.jpg",
            @"..\..\..\Resources\KjrnIjmqZzM.jpg",
            @"..\..\..\Resources\KLdgvh3RT3M.jpg",
            @"..\..\..\Resources\Lzki6viCZc0.jpg",
            @"..\..\..\Resources\M3bdNOw08jw.jpg",
            @"..\..\..\Resources\nnZ0XTq7U7A.jpg",
            @"..\..\..\Resources\photo_2021-09-21_01-11-00.jpg",
            @"..\..\..\Resources\pjlx2R-ae-Q.jpg",
            @"..\..\..\Resources\qRqRRpqEJ54.jpg",
            @"..\..\..\Resources\Qspkz1v4Uik.jpg",
            @"..\..\..\Resources\S28A-9NmER4.jpg",
            @"..\..\..\Resources\UGgIx5fQlZc.jpg",
            @"..\..\..\Resources\UGmxzLQTkFU.jpg",
            @"..\..\..\Resources\WjiA_ev8Wr8.jpg",
            @"..\..\..\Resources\XFnrpPQy1wo.jpg",
            @"..\..\..\Resources\xgCSZ2wN9I8.jpg",
            @"..\..\..\Resources\XMFySwhYGWQ.jpg",
 
        };

        public Form1()
        {
            InitializeComponent();
            //Cursor.Current = new Cursor(@"..\..\..\Resources\cursor.cur");
            this.Cursor= new Cursor(@"..\..\..\Resources\nat260.cur");
            button2.Visible = false;
           // WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticks==nameImage.Length-1) {
                timer1.Stop();
                ticks = 0;
                GC.Collect(0);
                button2.Visible = true;
                return;
            }

            ticks++;
            pictureBox1.Image = Image.FromFile(nameImage[ticks]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
        }
    }
}