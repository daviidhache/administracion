using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace administracion
{
    
    internal class BD
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public BD() {
            con = new MySqlConnection();
            con.ConnectionString = "server=127.0.0.1;Database=gestionfruteria;Uid=root;pwd='';old guids=true";
        }

        internal bool comprobarCredenciales(string usuario, string contraseña)
        {
            Boolean validar = false;
            con.Open();
            String sql = "select * from login";
            cmd = new  MySqlCommand(sql,con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0).Equals(usuario)) {
                    if (reader.GetString(1).Equals(contraseña)) {
                        validar = true;
                    }
                }

            }

            con.Close();


            return validar;
        }

        internal List<Cliente> obtenerClientesRanking()
        {
            List<Cliente> cli = new List<Cliente>();
            con.Open();
            String sql = "select * from clientes ORDER BY puntos desc";
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Cliente c = new Cliente();
                c.Dni = reader.GetString(0);
                c.Nombre = reader.GetString(1);
                c.Mail = reader.GetString(2);
                c.Puntos = Convert.ToInt16(reader[3]);
                cli.Add(c);
            }

            con.Close();

            return cli;
        }

        internal List<Proveedor> obtenerProveedores()
        {
            List<Proveedor> pro = new List<Proveedor>();
            con.Open();
            String sql = "select * from proveedores";
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Proveedor p = new Proveedor();
                p.Cif = reader.GetString(0);
                p.Nombre = reader.GetString(1);
                p.Direccion = reader.GetString(2);
                pro.Add(p);
            }

            con.Close();

            return pro;
        }

        internal List<Producto> obtenerStockMinimo()
        {
           List<Producto> stockminimo = new List<Producto>();
            con.Open();
            String sql = "select * from frutas where (stock < stockMinimo) and activo = 1";
            cmd = new MySqlCommand(sql,con);
            reader = cmd.ExecuteReader(); 
            while(reader.Read())
            {
                Producto p = new Producto();
                p.Id = reader.GetInt16(0);
                p.Nombre = reader.GetString(1);
                p.Precio = reader.GetFloat(2);
                p.Imagen = (byte[]) reader[3];
                p.Procedencia = reader.GetString(4);
                p.StockMinimo = reader.GetInt16(5);
                p.Stock = reader.GetInt16(6);
                p.Activo = 1;
                stockminimo.Add(p);
            }

            con.Close();

            return stockminimo;
        }

        internal List<Venta> obtenerVentasFecha(DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Venta> ventas = new List<Venta>();
            con.Open();
            String sql = "select * from facturacion WHERE DATE(Fecha) between ?inicio and ?final";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("?inicio", fechaInicial);
            cmd.Parameters.AddWithValue("?final", fechaFinal);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Venta v = new Venta();
                v.Id = reader.GetInt16(0);
                v.Mail = reader.GetString(1);
                v.Productos = reader.GetString(2);
                v.Fecha = reader.GetDateTime(3);
                v.Total = reader.GetFloat(4);
                ventas.Add(v);
            }

            con.Close();

            return ventas;

        }

        internal List<Venta> obtenerVentasPorHora(string text)
        {
            List<Venta> ventas = new List<Venta>();
            con.Open();
            String sql = "select * from facturacion WHERE HOUR(Fecha) = ?hora";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("?hora", text);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Venta v = new Venta();
                v.Id = reader.GetInt16(0);
                v.Mail = reader.GetString(1);
                v.Productos = reader.GetString(2);
                v.Fecha = reader.GetDateTime(3);
                v.Total = reader.GetFloat(4);
                ventas.Add(v);
            }

            con.Close();

            return ventas;
        }
    }
}
