using Entidades.Model.Derivadas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFactura
{
    public partial class Form1 : Form
    {
        Producto producto1;
        Producto producto2;
        List<Producto> productos;
        List<DetalleFactura> detalleFacturas;
        Categoria categoria;
        public Form1()
        {
            InitializeComponent();
        }        

        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            detalleFacturas = new List<DetalleFactura>();
            productos = new List<Producto>();
            categoria = new Categoria("Cubiertos", productos);

            productos.Add(new Producto("Tenedor", 125, detalleFacturas, categoria));
            productos.Add(new Producto("Cuchillo", 230, detalleFacturas, categoria));
        }

        private void btnMostrarObjetos_Click(object sender, EventArgs e)
        {
            foreach (var item in productos)
            {
                lstProductos.Items.Add($"Nombre Producto : {item.Nombre}");
                lstProductos.Items.Add($"Precio: {item.Precio}");
                lstProductos.Items.Add($"Categoria : {categoria.Nombre}");
                lstProductos.Items.Add("------------------------------------");
            }
        }
    }
}