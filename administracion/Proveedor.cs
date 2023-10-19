namespace administracion
{
    internal class Proveedor
    {
        String cif;
        String nombre;
        String mail;
        String direccion;

        public Proveedor() { 
        
        
        }

        public string Cif { get => cif; set => cif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}