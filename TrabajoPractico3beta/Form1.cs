using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico3beta
{
    public partial class Form1 : Form
    {
        double precioProducto, precioFinal, iva;  
        string precioIngresado, selectItem, nombre, categoria, tipoIva, mensajeDeGuardado;
        bool resGuardado;


        //GestionProductos gestion = new GestionProductos(10);
        GestionProductos gestion;
        Producto[] productos;
        public Form1( ref GestionProductos gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
            
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_categoriaProducto.Text = cmb_categoria.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Intente nuevamente","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos = gestion.almacenados();

            ProductosGuardados prd = new ProductosGuardados(ref productos);
            prd.Show();
        }

        private void Limpiar()
        {
            txt_PrecioBruto.BackColor = Color.White;
            txt_NombreProducto.BackColor = Color.White;
            txt_categoriaProducto.BackColor = Color.White;

            
            txt_NombreProducto.Text = "";
            txt_PrecioBruto.Text = "";

            labelPrecioFinal.Text = "";

            cmb_iva.SelectedIndex = 0;
            cmb_categoria.SelectedIndex = 0;
            txt_categoriaProducto.Text = "";
        }
        public double calcularIva()
        {
            try
            {
                iva = 1.0;
                precioIngresado = txt_PrecioBruto.Text;

                if (precioIngresado.Contains(","))
                {
                    precioIngresado = precioIngresado.Replace(",", ".");
                    label_prueba.Text = precioIngresado;
                }

                precioProducto = double.Parse(precioIngresado, CultureInfo.InvariantCulture);

                selectItem = cmb_iva.SelectedItem.ToString().Trim();
                switch (selectItem)
                {
                    case "21%":
                        iva = iva + 0.21;
                        break;
                    case "10.5%":
                        iva = iva + 0.105;
                        break;
                    case "4%":
                        iva = iva + 0.04;
                        break;
                    case "27%":
                        iva = iva + 0.27;
                        break;
                    default:
                        iva = iva + 0.21;
                        break;
                }
                precioFinal = precioProducto * iva;
                labelPrecioFinal.Text = precioFinal.ToString();
                txt_PrecioBruto.BackColor = Color.LightGreen;

            }
            catch (Exception)
            {
                if (txt_PrecioBruto.Text.Trim() == "")
                {
                    
                    txt_PrecioBruto.BackColor = Color.OrangeRed;
                    MessageBox.Show("El campo está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    precioFinal = 0;
                }
                else
                {
                   
                    txt_PrecioBruto.BackColor = Color.OrangeRed;
                    MessageBox.Show("¡valor no permitido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    precioFinal = 0; 
                }

                

            }


            return (precioFinal);
        }

        public void ListarProductos()
        {
            productos = gestion.almacenados();
            string listado = "";
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].NombreProducto!=null)
                {
                    listado += productos[i].NombreProducto + " " + productos[i].CategoriaProducto + " " + productos[i].TipoIva +" "+
                    productos[i].PrecioBruto.ToString() + " " + productos[i].PrecioFinal.ToString() + "\n";
                }


            }

            Console.WriteLine(listado);
            
        }


        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmb_iva_SelectionChangeCommited(object sender, EventArgs e)
        {
            calcularIva();
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            double precioFinal = calcularIva();
            if (precioFinal != 0)
            {
                try
                {
                    if (txt_NombreProducto.Text.Trim() != "" && txt_categoriaProducto.Text.Trim() != "")
                    {
                        // guardo los datos en las variables
                        nombre = txt_NombreProducto.Text.ToLower();
                        categoria = txt_categoriaProducto.Text.ToLower();
                        tipoIva = cmb_iva.SelectedItem.ToString();


                        // uso una instancia de la clase gestionarProductos

                        resGuardado = gestion.agregarProducto(nombre,categoria,tipoIva,precioProducto,precioFinal);

                        switch (resGuardado)
                        {
                            case true:
                                mensajeDeGuardado = "Se guardó correctamente";
                                txt_NombreProducto.BackColor = Color.LightGreen;
                                txt_categoriaProducto.BackColor = Color.LightGreen;
                                break;
                            case false:
                                mensajeDeGuardado = "No hay mas espacio en la memoria";
                                txt_NombreProducto.BackColor = Color.Yellow;
                                txt_categoriaProducto.BackColor = Color.Yellow;
                                txt_PrecioBruto.BackColor = Color.Yellow;
                                break;
                            default: mensajeDeGuardado = "Ocurrio algun error. aña ñai";
                                break;
                        }

                        MessageBox.Show(mensajeDeGuardado, "Info de guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();

                        ListarProductos();
                    }
                    else
                    {
                        txt_NombreProducto.BackColor = Color.OrangeRed;
                        txt_categoriaProducto.BackColor = Color.OrangeRed;
                        MessageBox.Show("Debe completar la Info. del producto.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Vuelva a intentarlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_iva.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_iva.SelectedIndex = 0;
            
        }

        private void precioFinal_Click(object sender, EventArgs e)
        {

            calcularIva();

        }

    }
}

