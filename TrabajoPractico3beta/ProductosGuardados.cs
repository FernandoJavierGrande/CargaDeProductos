using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico3beta
{
    public partial class ProductosGuardados : Form
    {
        Producto[] productos;
      

        public ProductosGuardados( ref Producto[] productos )
        {
            this.productos = productos;
            InitializeComponent();
            
        }


        private void ProdctosGuardados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                vistaDatos.Rows.Clear();
                for (int i = 0; i < productos.Length; i++)
                {
                    if (productos[i].NombreProducto!= null && productos[i].CategoriaProducto!=null)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(vistaDatos);
                        fila.Cells[0].Value = productos[i].NombreProducto;
                        fila.Cells[1].Value = productos[i].CategoriaProducto;
                        fila.Cells[2].Value = productos[i].TipoIva;
                        fila.Cells[3].Value = productos[i].PrecioBruto;
                        fila.Cells[4].Value = productos[i].PrecioFinal;

                        vistaDatos.Rows.Add(fila);
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problema en la carga de los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       

        }


        private void vistaDatos_DoubleClick(object sender, EventArgs e)
        {

            productos[0].CategoriaProducto = "ninguna";

        }

        private void BotonActTabla_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
