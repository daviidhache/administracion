namespace administracion
{
    public partial class Form1 : Form
    {
        BD con = new BD();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Debes rellenar ambos campos para iniciar sesión", "ADVENTENCIA");
            }
            else
            {
                // Primero procedemos a realizar la búsqueda del usuario en la BD
                if (con.comprobarCredenciales(txtUsuario.Text, txtPassword.Text))
                {
                    Form2 gestion = new Form2();
                    gestion.Show();
                    
                }
                else {
                    MessageBox.Show("Compruebe de nuevo los datos del login","ERROR");
                }
                
               

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}