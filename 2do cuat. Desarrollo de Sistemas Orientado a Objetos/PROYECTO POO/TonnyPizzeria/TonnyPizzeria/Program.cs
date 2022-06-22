using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TonnyPizzeria
{
    class Pizzeria
    {
        string _idPizzeria;
        string _nombre;
        string _direccion;
        string _telefono;
        public Pizzeria(string idPizzeria, string nombre, string direccion, string telefono)
        {
            IdPizzeria = idPizzeria;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
        public string IdPizzeria { get => _idPizzeria; set => _idPizzeria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public override string ToString()
        {
            return $"{Nombre} \nDirección: {Direccion}\nTeléfono: {Telefono}\n";
        }
    }
    abstract class Producto
    {
        protected string _idProducto;
        protected string _nombre;
        protected double _precioUnitario;
        public Producto(string idProducto, string nombre, double precioUnitario)
        {
            _idProducto = idProducto;
            _nombre = nombre;
            _precioUnitario = precioUnitario;
        }
        public abstract double CalcularPrecio(int cantidad);
    }
    class Bebida : Producto
    {
        private bool _alcoholica;
        public Bebida(string idProducto, string nombre, double precioUnitario, bool alcoholica) : base(idProducto, nombre, precioUnitario)
        {
            _alcoholica = alcoholica;
        }
        public string IdProducto { get => _idProducto; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }
        public bool Alcoholica { get => _alcoholica; set => _alcoholica = value; }
        public override string ToString()
        {
            return $"{_nombre}";
        }

        public override double CalcularPrecio(int cantidad)
        {
            double recargo = 1;
            if (_alcoholica)
            {
                recargo = 1.2;
            }
            return _precioUnitario * recargo * cantidad;
        }
    }
    class Pizza : Producto
    {
        bool _vegana;

        public Pizza(string idProducto, string nombre, double precioUnitario, bool vegana) : base(idProducto, nombre, precioUnitario)
        {
            _vegana = vegana;
        }
        public string IdProducto { get => _idProducto; }
        public bool Vegana { get => _vegana; set => _vegana = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }

        public override double CalcularPrecio(int cantidad)
        {
            double recargo = 1;
            if (_vegana)
            {
                recargo = 1.3;
            }
            return _precioUnitario * recargo * cantidad;
        }

        public override string ToString()
        {
            return $"{_nombre}";
        }
    }

    class Pedido
    {
        DateTime _fecha = DateTime.Now;
        int _idPedido;
        List<ItemPedido> _listaPedido;
        string _formaDePago;
        double _totalPedido;

        public Pedido(ItemPedido listaPedido, string formaDePago, double totalPedido)
        {
            _listaPedido = new List<ItemPedido> { listaPedido };
            _formaDePago = formaDePago;
            _totalPedido = totalPedido;
        }

        public int IdPedido { get => _idPedido; }
        public string FormaDePago { get => _formaDePago; set => _formaDePago = value; }
        public double TotalPedido { get => _totalPedido; set => _totalPedido = value; }
        internal List<ItemPedido> ListaPedido { get => _listaPedido; set => _listaPedido = value; }
    }

    class ItemPedido
    {
        int _idItem;
        string _codProducto;
        string _nombreProd;
        string _precioProd;
        string _cantidad;
        string _descuentoItem;
        string _totalItem;

        public int IdItem { get => _idItem; set => _idItem = value; }
        public string CodProducto { get => _codProducto; set => _codProducto = value; }
        public string NombreProd { get => _nombreProd; set => _nombreProd = value; }
        public string PrecioProd { get => _precioProd; set => _precioProd = value; }
        public string Cantidad { get => _cantidad; set => _cantidad = value; }
        public string DescuentoItem { get => _descuentoItem; set => _descuentoItem = value; }
        public string TotalItem { get => _totalItem; set => _totalItem = value; }

    }

    public class Productos
    {
        int _idItem;
        string _codProducto;
        string _nombreProd;
        string _precioProd;
        string _cantidad;
        string _descuentoItem;
        string _totalItem;

        public int IdItem { get => _idItem; set => _idItem = value; }
        public string CodProducto { get => _codProducto; set => _codProducto = value; }
        public string NombreProd { get => _nombreProd; set => _nombreProd = value; }
        public string PrecioProd { get => _precioProd; set => _precioProd = value; }
        public string Cantidad { get => _cantidad; set => _cantidad = value; }
        public string DescuentoItem { get => _descuentoItem; set => _descuentoItem = value; }
        public string TotalItem { get => _totalItem; set => _totalItem = value; }
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
