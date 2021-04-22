using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionBD
{
    public partial class Frmbase : Form
    {
        public Frmbase()
        {
            InitializeComponent();
        }

        public virtual void Eliminar() {


        }
        public virtual void Nuevo()
        {


        }
        public virtual void Consultar()
        {


        }
        public virtual Boolean guardar()
        {

            return false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult rta;
            rta = MessageBox.Show("Desea salir de la edicion?","MENSAJE DE ADVERTENCIA",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(rta == DialogResult.OK)
            {
                this.Close();
                
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
