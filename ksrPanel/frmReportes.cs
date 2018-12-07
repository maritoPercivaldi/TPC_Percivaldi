using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;
using Excel = Microsoft.Office.Interop.Excel;



namespace ksrPanel
{
    public partial class frmReportes : frmModelo
    {
        private List<ConductorPorVehiculo> listaConductores;
        private List<KilometrosPorVehiculos> listaKM;

        public frmReportes()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1024, 1024);
            cambiarUbicacionLogo(904, 824);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            cargarKm();
            cargarConductor();
           
        }

        private void cargarConductor()
        {
            ConductorPorVehiculoBusiness negocioConductor = new ConductorPorVehiculoBusiness();
            try
            {
                listaConductores = (List<ConductorPorVehiculo>)negocioConductor.listar();
                dgvConductoresReporte.DataSource = listaConductores;
                dgvConductoresReporte.Columns[0].Visible = false;
                dgvConductoresReporte.Columns[4].Visible = false;
                dgvConductoresReporte.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error!");
            }

        }

        private void cargarKm()
        {
            kmPorVehiculosBusiness negocioKm = new kmPorVehiculosBusiness();
            try
            {
                listaKM = (List<KilometrosPorVehiculos>)negocioKm.listar();
                dgvKmReporte.DataSource = listaKM;
                dgvKmReporte.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error!");
            }
        }

        private void copyAlltoClipboard(DataGridView dgv)
        {
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnExportarConductor_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard(dgvConductoresReporte);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }

        private void btnExportarKM_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard(dgvKmReporte);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }
    }
}
