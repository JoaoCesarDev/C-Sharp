using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace APRESENTAÇÃO
{
    public partial class frmrentbike : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        Form _Objform1;

        public frmrentbike()
        {
            InitializeComponent();
        }

        private void panelCabecalho_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
                    }
        private void button1_Click(object sender, EventArgs e)
        {
                   }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelconteudo_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnclientes_Click(object sender, EventArgs e)
        {
            _Objform1?.Close();
            _Objform1 = new Formclientes
            {
                TopLevel = false,
                FormBorderStyle =  FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panelconteudo.Controls.Add(_Objform1);
            _Objform1.Show();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
            _Objform1 = new frmconfig();
            _Objform1.Show();
        }
    }
}
