using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3beta
{
    public class GestionProductos
    {
        Producto productos = new Producto();
        Producto[] PAlmacenados;


        string nombreProducto;
        private int espaciosVacios=5, esp_Memoria=5;
        string nombre, categoria, tipoIva;
        double precioBruto, precioFinal;

        /// constructores

        public GestionProductos(int cantidad)
        {
            espaciosVacios = cantidad;
            esp_Memoria = cantidad;
            PAlmacenados = new Producto[cantidad];
            for (int i = 0; i < esp_Memoria; i++)
            {
                PAlmacenados[i] = new Producto();
            }
        }

        public GestionProductos()
        {
            espaciosVacios = 5;
            esp_Memoria = 5;
            PAlmacenados = new Producto[5];
            for (int i = 0; i < esp_Memoria; i++)
            {
                PAlmacenados[i] = new Producto();
            }
            
        }


        /// metodos


        public bool agregarProducto(string nombre, string categoria, string tipoIva, double precioBruto, double precioFinal)
        {
            bool ctrl = false;

            this.nombre = nombre.Trim();
            this.categoria = categoria.Trim();
            this.tipoIva = tipoIva.Trim();
            this.precioBruto = precioBruto;
            this.precioFinal = precioFinal;

            if (espaciosVacios > 0)
            {

                for (int i = 0; i < esp_Memoria; i++)
                {

                    //Producto aux = PAlmacenados[i];
                    if (PAlmacenados[i].NombreProducto == null)
                    {
                        PAlmacenados[i].NombreProducto = this.nombre;
                        PAlmacenados[i].CategoriaProducto = this.categoria;
                        PAlmacenados[i].TipoIva = this.tipoIva;
                        PAlmacenados[i].PrecioBruto = this.precioBruto;
                        PAlmacenados[i].PrecioFinal = this.precioFinal;

                        ctrl = true;

                        espaciosVacios--;

                        i = esp_Memoria;
                        Console.WriteLine("aca ya cargo los atributos");
                    }
                    else
                    {
                        Console.WriteLine("falla en el if antes de los atributos- salta un lugar ocupado " + i.ToString());
                    }
                }//cierre for
            }
            else
            {
                ctrl = false;
                Console.WriteLine("falla en el if de espacios vacios " + espaciosVacios.ToString());
            }
            

            return ctrl;
        }

        public int espaciosLibres()
        {

            return espaciosVacios;

        }

        public string eliminarProducto(string nombreProducto)
        {
            
            string retorno="";
            this.nombreProducto = nombreProducto.Trim();

            if (espaciosVacios==esp_Memoria)
            {
                retorno = "No hay Productos almacenados";
            }
            else
            {
                //try
                //{
                    for (int i = 0; i < esp_Memoria ; i++)
                    {
                        if (PAlmacenados[i].NombreProducto != null)
                        {
                            if (PAlmacenados[i].NombreProducto.Trim() == nombreProducto)
                            {
                                
                                retorno = "Nombre: " + PAlmacenados[i].NombreProducto + " Categoria: "
                                    + PAlmacenados[i].CategoriaProducto + " Iva: "+ PAlmacenados[i].TipoIva + " Precio bruto: $" + PAlmacenados[i].PrecioBruto
                                    + "Precio Final: $" + PAlmacenados[i].PrecioFinal;
                                PAlmacenados[i] = null;
                                espaciosVacios++;
                                break;
                            }
                        }

                    }
                    if (retorno == "")
                    {
                        retorno = "No se encontró el producto: "; 
                    }

                //}
                //catch (Exception)
                //{
                //    return= "ocurrio algun problema "
                    
                //}
            }

            return retorno;
        }
        public Producto[] almacenados()
        {
            return   PAlmacenados;
        } 

    }

}
