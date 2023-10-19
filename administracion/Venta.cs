namespace administracion
{
    internal class Venta
    {
        int id;
        String mail;
        String productos;
        DateTime fecha;
        float total;

        public Venta() { 
        
        
        }

        public int Id { get => id; set => id = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Productos { get => productos; set => productos = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Total { get => total; set => total = value; }
    }
}