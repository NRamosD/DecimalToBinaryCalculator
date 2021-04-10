using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazV1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            btnOperar_Click(null, e);
        }

        #region Parte Superior
        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void AbrirFormHija(object formhijo)
        {
            if (this.panelContenido.Controls.Count > 0) { this.panelContenido.Controls.RemoveAt(0); }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();


        }

        

        private void btnSM_Click(object sender, EventArgs e)
        {
            btnSM.BackColor = Color.Black;
            btnAyuda.BackColor = Color.Transparent;
            btnOperar.BackColor = Color.Transparent;
            AbrirFormHija(new formSM());
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            btnAyuda.BackColor = Color.Black;
            btnSM.BackColor = Color.Transparent;
            btnOperar.BackColor = Color.Transparent;
            AbrirFormHija(new formAyuda());
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            btnOperar.BackColor= Color.Black;
            btnSM.BackColor = Color.Transparent;
            btnAyuda.BackColor = Color.Transparent;
            AbrirFormHija(new Operaciones());
        }

        
    }
}
