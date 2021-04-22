using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
namespace FacturacionBD
{
    class Acceso_Datos
    {
        SqlConnection cn;
        SqlCommand cmd;
      
        public void AbrirBD()
        {
            try
            {
                cn = new SqlConnection("");
            } catch(Exception ex)
            {
                MessageBox.Show("Fallò conexiòn " + ex);
            }
        }
    }
}
