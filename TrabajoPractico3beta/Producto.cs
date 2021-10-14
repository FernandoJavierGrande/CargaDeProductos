﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3beta
{
    public class  Producto
    {
        private string nombreProducto;
        private string categoriaProducto;
        private string tipoIva;
        private double precioBruto;
        private double precioFinal;

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string CategoriaProducto { get => categoriaProducto; set => categoriaProducto = value; }
        public string TipoIva { get => tipoIva; set => tipoIva = value; }
        public double PrecioBruto { get => precioBruto; set => precioBruto = value; }
        public double PrecioFinal { get => precioFinal; set => precioFinal = value; }
    }
}
