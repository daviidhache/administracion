namespace administracion
{
    internal class Cliente
    {
        String dni;
        String nombre;
        String mail;
        int puntos;

        public Cliente()
        {


        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }
}