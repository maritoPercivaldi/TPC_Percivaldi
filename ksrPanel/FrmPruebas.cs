using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ksrPanel
{
    public partial class FrmPruebas : Form
    {
        public FrmPruebas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUsuarios pepe = new clsUsuarios();
            UsuarioBusiness prueba = new UsuarioBusiness();
            pepe = prueba.cargarData(1);
            MessageBox.Show(pepe.ToString());

        }
    }
}
