using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRegistrar : Form
    {
        //variables
        int id;
        //instancias
        E_AgendaRegistros Entidad = new E_AgendaRegistros();
        N_AgendaNegocio logica = new N_AgendaNegocio();
        public FrmRegistrar(int id)
        {
            InitializeComponent();
            if (id != 0)
            {
                this.id = id;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {
            this.txt_Nombre.Focus();
            LlenarCampos();
        }
        //llenar campos
        private void LlenarCampos()
        {
            if (id != 0)
            {
                this.Text = "Formulario de Edicion";
                this.btn_Guardar.Text = "Editar";
                SqlDataReader reader = logica.GetDataById(id);
                if (reader.Read())
                {
                    txt_Nombre.Text = reader.GetString(1);
                    txt_Apellido.Text = reader.GetString(2);
                    txt_Direccion.Text = reader.GetString(3);
                    txt_fecha.Text = reader.GetDateTime(4).ToString();
                    mskTxt_Celular.Text = reader.GetString(5);
                }
                reader.Close();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Validacion();
        }
        //validacion
        private void Validacion()
        {
            int idMessage = 0;

            if (txt_Nombre.Text == "")
            {
                idMessage = 1;
            }
            else if (txt_Apellido.Text == "")
            {
                idMessage = 2;
            }
            else if (txt_Direccion.Text == "")
            {
                idMessage = 3;
            }
            else if (txt_fecha.Text == "")
            {
                idMessage = 4;
            }
            else if (!mskTxt_Celular.MaskCompleted)
            {
                idMessage = 5;
            }
            else if (id == 0)
            {
                idMessage = 6;
            }
            else if (id != 0)
            {
                idMessage = 7;
            }

            //desplegando mensajes dependiendo la el valor de idMessage
            switch (idMessage)
            {
                case 1:
                    MessageBox.Show("EL campo Nombre esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("El campo Apellido esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("El campo Direccion esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("El campo Fecha de Nacimiento esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    MessageBox.Show("El campo Celular esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    InsertarRegistro();
                    break;
                case 7:
                    EditarRegistro();
                    break;
            }
        }
        //metodo para ingresar un registro
        private void InsertarRegistro()
        {
            Entidad.NOMBRE = txt_Nombre.Text;
            Entidad.APELLIDO = txt_Apellido.Text;
            Entidad.DIRECCION = txt_Direccion.Text;
            Entidad.FECHA_NACIMIENTO = txt_fecha.Text;
            Entidad.CELULAR = mskTxt_Celular.Text;

            logica.AddRegistro(Entidad);

            MessageBox.Show("Se guardo el registro", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //metodo para editar un registro
        private void EditarRegistro()
        {
            Entidad.IDREGISTRO = this.id;
            Entidad.NOMBRE = txt_Nombre.Text;
            Entidad.APELLIDO = txt_Apellido.Text;
            Entidad.DIRECCION = txt_Direccion.Text;
            Entidad.FECHA_NACIMIENTO = txt_fecha.Text;
            Entidad.CELULAR = mskTxt_Celular.Text;

            logica.UpdateRegistro(Entidad);

            MessageBox.Show("Se edito el registro", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
