namespace ball
{
    public partial class Form1 : Form
    {
        Bitmap bmp;

        Graphics g;
        Ball pelota;

        int x,y,radio,Velocidad_x, Velocidad_y;
        Brush colorPelota;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            

            
            pelota = new Ball(pictureBox1.Size);
            pelota.Dibujar(g);

            pictureBox1.Invalidate();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            pelota.Mover();

            pictureBox1.Invalidate();
            

        }
    }
}