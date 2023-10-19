namespace administracion
{
    internal class Producto
    {
        int id;
        String nombre;
        float precio;
        byte[] imagen;
        String procedencia;
        int stockMinimo;
        int stock;
        int activo;

        public Producto() {
        
        
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public string Procedencia { get => procedencia; set => procedencia = value; }
        public int StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Activo { get => activo; set => activo = value; }
    }
}