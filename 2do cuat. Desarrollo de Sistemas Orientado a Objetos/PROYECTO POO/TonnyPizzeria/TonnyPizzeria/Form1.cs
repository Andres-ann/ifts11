using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TonnyPizzeria
{
    public partial class Form1 : Form
    {
        Pizzeria TonysPizzeria = new Pizzeria("001", "Tony Pizzeria", "Av. Concordia 4215", "(+54) 11 4589 1222");

        Pizza Muzzarella = new Pizza("002", "Pizza de muzzarella", 950, false);
        Pizza MuzzarellaVeg = new Pizza("003", "Pizza de muzzarella vegana", 1200, true);

        Bebida Bebida = new Bebida("004", "Agua", 220, false);
        Bebida BebidaAlcholica = new Bebida("005", "Cerveza", 350, true);

        List<Productos> ListaProductos = new List<Productos>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TonysPizzeria.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductos.Text == Muzzarella.ToString())
            {
                txtPrecio.Text = Convert.ToString(Muzzarella.PrecioUnitario);
                txtCodigoProducto.Text = Muzzarella.IdProducto;
            }

            if (cboProductos.Text == MuzzarellaVeg.ToString())
            {
                txtPrecio.Text = Convert.ToString(MuzzarellaVeg.PrecioUnitario);
                txtCodigoProducto.Text = MuzzarellaVeg.IdProducto;
            }

            if (cboProductos.Text == Bebida.ToString())
            {
                txtPrecio.Text = Convert.ToString(Bebida.PrecioUnitario);
                txtCodigoProducto.Text = Bebida.IdProducto;
            }

            if (cboProductos.Text == BebidaAlcholica.ToString())
            {
                txtPrecio.Text = Convert.ToString(BebidaAlcholica.PrecioUnitario);
                txtCodigoProducto.Text = BebidaAlcholica.IdProducto;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(txtCantidad.Text);
            cant = cant + 1;
            txtCantidad.Text = Convert.ToString(cant);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(txtCantidad.Text);
            cant = cant - 1;
            txtCantidad.Text = Convert.ToString(cant);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(txtPrecio.Text);
            double cant = Convert.ToDouble(txtCantidad.Text);
            double resultado = precio * cant;

            if (txtDescuento.Text != "")
            {
                double desc = Convert.ToDouble(txtDescuento.Text) / 100;
                resultado = (precio - (precio * desc)) * cant;
            }

            txtTotal.Text = Convert.ToString(resultado);          

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstvItemsPedido.Items.Clear();

            foreach (Productos producto in ListaProductos)
            {
                ListViewItem item = new ListViewItem();
                item = lstvItemsPedido.Items.Add(producto.IdItem.ToString());
                item.SubItems.Add(producto.CodProducto);
                item.SubItems.Add(producto.NombreProd);
                item.SubItems.Add(producto.PrecioProd);
                item.SubItems.Add(producto.Cantidad);
                item.SubItems.Add(producto.DescuentoItem);
                item.SubItems.Add(producto.TotalItem);

                txtCodigoProducto.Text = string.Empty;
                cboProductos.Text = string.Empty;
                txtPrecio.Text = string.Empty;
                txtDescuento.Text = string.Empty;
                txtTotal.Text = string.Empty;

                MessageBox.Show("Producto agregado correctamente");
            }            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.IdItem = 1;
            producto.CodProducto = txtCodigoProducto.Text;
            producto.NombreProd = cboProductos.Text;
            producto.PrecioProd = txtPrecio.Text;
            producto.Cantidad = txtCantidad.Text;
            producto.DescuentoItem = txtDescuento.Text;
            producto.TotalItem = txtTotal.Text;

            ListaProductos.Add(producto);                      
        }

        private void lblDescuento_Click(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
         
            txtCodigoProducto.Text = string.Empty;
            cboProductos.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtDescuento.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }
    }
}
