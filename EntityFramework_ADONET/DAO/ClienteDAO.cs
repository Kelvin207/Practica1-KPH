using EntityFramework_ADONET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ADONET.DAO
{
    public class ClienteDAO
    {
        public void ListarClienteEF()
        {
            List<tbCliente> lista = new List<tbCliente>();
            using (var db = new connBD_EF())
            {                
                lista = db.tbCliente.ToList();
            }
            Console.WriteLine("\nLista de Clientes");
            foreach (var item in lista)
            {
                Console.WriteLine(item.idCliente + "\t" + item.nombreCliente + "\t" + item.apellidosCliente + "\t" + item.fechaNacimiento + "\t" + item.dniCliente);
            }
        }

        public void RegistrarClienteEF()
        {
            Console.WriteLine("\nIngrese nombre Cliente: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("\nIngrese Apellidos Cliente: ");
            string apellidos = Console.ReadLine();

            Console.WriteLine("\nIngrese DNI Cliente: ");
            string dni = Console.ReadLine();

            Console.WriteLine("\nIngrese Fecha Nacimiento Cliente: ");
            string fechaNac = Console.ReadLine();

            tbCliente cli = new tbCliente { nombreCliente = nombre, apellidosCliente = apellidos, dniCliente = dni, fechaNacimiento = Convert.ToDateTime(fechaNac) };
            using (var db = new connBD_EF())
            {
                db.tbCliente.Add(cli);
                db.SaveChanges();
            }
            Console.WriteLine("\nSe registró correctamente");
        }
        public void ActualizarClienteEF()
        {
            Console.WriteLine("\nIngrese el ID de Cliente a actualizar:");
            int idCli = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese nombre Cliente: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("\nIngrese Apellidos Cliente: ");
            string apellidos = Console.ReadLine();

            Console.WriteLine("\nIngrese DNI Cliente: ");
            string dni = Console.ReadLine();

            Console.WriteLine("\nIngrese Fecha Nacimiento Cliente: ");
            string fechaNac = Console.ReadLine();

            using (var db = new connBD_EF())
            {
                tbCliente cli = db.tbCliente.Find(idCli);
                cli.nombreCliente = nombre;
                cli.apellidosCliente = apellidos;
                cli.dniCliente = dni;
                cli.fechaNacimiento = Convert.ToDateTime(fechaNac);
                db.SaveChanges();
            }
        }
    }
}
