using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Xml.Linq;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace administracion
{
    public partial class Form2 : Form
    {
        BD con = new BD();
        List<Producto> listaProductosMinimo = new List<Producto>();
        List<Factura> listaFactura = new List<Factura>();
        List<Proveedor> listaProveedores = new List<Proveedor>();
        List<Venta> listaVentas = new List<Venta>();
        List<Cliente> listaClientes = new List<Cliente>();
        List<Cliente> listaClientesMedia = new List<Cliente>();
        public Form2()
        {
            InitializeComponent();
            listaProductosMinimo = con.obtenerStockMinimo();
            listaProveedores = con.obtenerProveedores();
            cargarPedidos();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            dgv.DataSource = null;
            dgv.DataSource = listaProductosMinimo;
            MessageBox.Show("Atención, Si se muestran productos, haga nuevo pedido de unidades en la sección 'Pedidos' , ya que sus productos bajaron por debajo del stock mínimo");
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            // Pedir cantidad de stock distinta de 0
            // Añadir el contenido a la lista Factura
            String stock = Interaction.InputBox("Seleccione cantidad de stock");
            if (stock.Equals("0") || stock.Equals(""))
            {

                MessageBox.Show("No puedes asignar 0 unidades");
            }
            else
            {
                Factura fac = new Factura();
                fac.Producto = lstfruta.Text;
                fac.Proveedor = listpro.Text;
                fac.Stock = Convert.ToInt16(stock);
                listaFactura.Add(fac);
                // Mandar a datagrid el contenido de la clase factura
                dgv.DataSource = null;
                dgv.DataSource = listaFactura;


            }

        }

        private void cargarPedidos()
        {

            foreach (Producto x in listaProductosMinimo)
            {
                lstfruta.Items.Add(x.Nombre);

            }

            foreach (Proveedor e in listaProveedores)
            {
                listpro.Items.Add(e.Nombre);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstfruta.Visible = false;
            listpro.Visible = false;
            textBox1.Visible = false;
            btnAnadir.Visible = false;
            btnPedidoFac.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dgv.DataSource = null;
            lstfruta.Visible = true;
            listpro.Visible = true;
            btnAnadir.Visible = true;
            btnPedidoFac.Visible = true;

        }

        private void btnPedidoFac_Click(object sender, EventArgs e)
        {
            // Obtener PDF de la factura // OJO no va a actualizar stock. Ya que tendría que haber
            // otra seccion para verificar la recepción de los productos y actualizar su stock.

            //crear objeto pdfTAble a partir del datagrid
            PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
            //separación texto de las celdas del contenido
            pdfTable.DefaultCell.Padding = 3;
            //ancho de la tabla
            pdfTable.WidthPercentage = 80;
            //alineación del texto dentro de las celdas
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            //ancho del borde
            pdfTable.DefaultCell.BorderWidth = 1;
            //encabezamiento de las columnas
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }
            //contenidos de las filas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    try { pdfTable.AddCell(cell.Value.ToString()); }
                    catch { }
                }
            }


            string folderPath = "C:\\FacturasStock\\";
            //si no existe el directorio ticket se genera
            if (!Directory.Exists(folderPath)) { Directory.CreateDirectory(folderPath); }
            //para colocar la fecha actual de impresión
            DateTime dt = DateTime.Now;
            string s = dt.ToString("yyyyMMddHHmmss");
            string cadenaFinal = folderPath + "ticket" + s + ".pdf";
            //crear el documento o fichero físico
            using (FileStream stream = new FileStream(folderPath + "ticket" + s + ".pdf", FileMode.Create))
            {
                //dimensiones del documento
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 20f, 20f, 20f, 20f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                //texto informativo
                pdfDoc.Add(new Paragraph("Frutería David H"));
                pdfDoc.Add(new Paragraph("CIF: A1234567B"));
                pdfDoc.Add(new Paragraph("c/ Joaquín Alcalde s/n"));
                pdfDoc.Add(new Paragraph("10300 Navalmoral de la Mata"));
                pdfDoc.Add(new Paragraph("Cáceres."));
                pdfDoc.Add(new Paragraph("\n\n"));
                //integrar la tabla creada en la parte superior
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(new Paragraph("\n\n"));
                //más información
                pdfDoc.Add(new Paragraph("Fecha/Hora solicitud stock: " + DateTime.Now.ToString("dd-MM-yy, HH:mm:ss")));


                pdfDoc.Close();
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                // mensaje cadena no puede estar vacia
            }
            else
            {

                listaVentas = con.obtenerVentasPorHora(textBox1.Text);
                dgv.DataSource = null;
                dgv.DataSource = listaVentas;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            button6.Visible = true;
            textBox1.Visible = true;
            button7.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DateTime fechaInicial = dateTimePicker1.Value.Date;
            DateTime fechaFinal = dateTimePicker2.Value.Date;
            listaVentas = con.obtenerVentasFecha(fechaInicial, fechaFinal);
            dgv.DataSource = null;
            dgv.DataSource = listaVentas;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstfruta.Visible = false;
            listpro.Visible = false;
            textBox1.Visible = false;
            btnAnadir.Visible = false;
            btnPedidoFac.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            button8.Visible = true;



            MessageBox.Show("RANKING DE CLIENTES");
            listaClientes = con.obtenerClientesRanking();
            dgv.DataSource = null;
            dgv.DataSource = listaClientes;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            double media = 0.0;
            foreach (Cliente x in listaClientes)
            {
                media += x.Puntos;

            }
            // Calcular la media
            media = media / listaClientes.Count;
            // Busco clientes por encima de esa media y los añado a lista auxiliar.
            foreach (Cliente x in listaClientes)
            {
                if (x.Puntos >= media)
                {
                    listaClientesMedia.Add(x);
                }

            }

            // Cargamos en dgv

            dgv.DataSource = null;
            dgv.DataSource = listaClientesMedia;

        }
    }
}
