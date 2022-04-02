using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using SpreadsheetLight;

namespace CapaPresentacion
{
    public partial class FrmRegistros : Form
    {
        //instancias
        E_AgendaRegistros Entidad = new E_AgendaRegistros();
        N_AgendaNegocio logica = new N_AgendaNegocio();
        FrmRegistrar FrmRegistrar = new FrmRegistrar(0);
        public FrmRegistros()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmRegistros_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void txt_Search_OnTextChange(object sender, EventArgs e)
        {
            Dashboard_Registros.DataSource = logica.SearchRegistro(txt_Search.text);
            AccionesDashboard();
        }
        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            GetData();
            AccionesDashboard();
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmRegistrar.ShowDialog();
            GetData();
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int id = GetId();
            if (id != 0)
            {
                FrmRegistrar editar = new FrmRegistrar(id);
                editar.ShowDialog();
                GetData();
            }
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //obtiendo el id seleccionado en la tabla de mi metodo getId
            int id = GetId();
            if (id != 0)
            {
                var message = MessageBox.Show("Esta seguro?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    //llamando al metodo delete de la clase de Procedimientos de la capa de Acceso a Datos
                    Entidad.IDREGISTRO = id;
                    logica.DeleteRegistro(Entidad);
                    GetData();
                    AccionesDashboard();
                }
                else
                {
                    MessageBox.Show("El registro esta a salvo!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btn_Excel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }
        //metodo para traer todos los registros
        private void GetData()
        {
            Dashboard_Registros.DataSource = logica.GetData();
            AccionesDashboard();
        }
        //metodo acciones table
        private void AccionesDashboard()
        {
            Dashboard_Registros.Columns[0].Visible = false;
            Dashboard_Registros.ClearSelection();
        }
        //metodo para obtener el id de la fila seleccionada
        private int GetId()
        {
            int id;
            if (Dashboard_Registros.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(Dashboard_Registros.CurrentRow.Cells[0].Value.ToString());
                return id;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        //metodo para exportar el dashBoard a Excel
        private void ExportarExcel()
        {
            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            style.Font.Bold = true;
            style.Font.FontSize = 12;
            int IC = 1;
            //recorriendo las columnas del DashboardCategoria
            foreach (DataGridViewColumn column in Dashboard_Registros.Columns)
            {
                sl.SetCellValue(1, IC, column.HeaderText.ToString());
                sl.SetCellStyle(1, IC, style);
                IC++;
            }

            int IR = 2;
            //recorriendo los row del DashboardCategoria
            foreach (DataGridViewRow row in Dashboard_Registros.Rows)
            {
                sl.SetCellValue(IR, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(IR, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(IR, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(IR, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(IR, 5, row.Cells[4].Value.ToString());
                sl.SetCellValue(IR, 6, row.Cells[5].Value.ToString());
                IR++;
            }
            string ruta = @"\\JRUBI\Users\rubi\Documents\DashboardRegistrosExcel\DashboardRegistros.xlsx";
            sl.SaveAs(ruta);
            MessageBox.Show("Excel exportado!! " + "ruta: " + ruta, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
