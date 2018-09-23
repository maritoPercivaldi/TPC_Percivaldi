using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ksrPanel
{
    public partial class Form1 : ksrPanel.frmModelo
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 800);
            cambiarUbicacionLogo(680, 600);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu form = new frmMainMenu();
            form.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
