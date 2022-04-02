using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_AgendaRegistros
    {
        private int _IDREGISTRO;
        private string _NOMBRE;
        private string _APELLIDO;
        private string _DIRECCION;
        private string _FECHA_NACIMIENTO;
        private string _CELULAR;

        public int IDREGISTRO { get => _IDREGISTRO; set => _IDREGISTRO = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string APELLIDO { get => _APELLIDO; set => _APELLIDO = value; }
        public string DIRECCION { get => _DIRECCION; set => _DIRECCION = value; }
        public string FECHA_NACIMIENTO { get => _FECHA_NACIMIENTO; set => _FECHA_NACIMIENTO = value; }
        public string CELULAR { get => _CELULAR; set => _CELULAR = value; }
    }
}
