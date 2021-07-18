using EntityFramework_ADONET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ADONET.DAO
{
    public class TarjetaDAO
    {
        public void ListarTarjetaEF()
        {
            List<tbTarjeta> lista = new List<tbTarjeta>();
            using (var db = new connBD_EF())
            {
                lista = db.tbTarjeta.ToList();
            }
            Console.WriteLine("\nLista de Tarjetas");
            foreach (var item in lista)
            {
                Console.WriteLine(item.idTarjeta + "\t" + item.numeroTarjeta + "\t" + item.tipoTarjeta + "\t" + item.modoPago + "\t" + item.fechaVencimiento + "\t" + item.idCliente);
            }
        }

        public void RegistrarTarjetaEF()
        {
            Console.WriteLine("\nIngrese Número Tarjeta: ");
            string numero = Console.ReadLine();

            Console.WriteLine("\nIngrese Tipo de Tarjeta: ");
            string tipo = Console.ReadLine();

            Console.WriteLine("\nIngrese Modo Pago: ");
            string modo = Console.ReadLine();

            Console.WriteLine("\nIngrese Fecha de Vencimiento: ");
            string fecha = Console.ReadLine();

            Console.WriteLine("\nIngrese IdCliente: ");
            int idcli = Convert.ToInt32(Console.ReadLine());

            tbTarjeta tarjeta = new tbTarjeta { numeroTarjeta = numero, tipoTarjeta = tipo, modoPago = modo, fechaVencimiento = fecha, idCliente = idcli };
            using (var db = new connBD_EF())
            {
                db.tbTarjeta.Add(tarjeta);
                db.SaveChanges();
            }
            Console.WriteLine("\nSe registró correctamente");
        }
        public void ActualizarTarjetaEF()
        {
            Console.WriteLine("\nIngrese el ID de Tarjeta a actualizar:");
            int idtarjeta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese Número Tarjeta: ");
            string numero = Console.ReadLine();

            Console.WriteLine("\nIngrese Tipo de Tarjeta: ");
            string tipo = Console.ReadLine();

            Console.WriteLine("\nIngrese Modo Pago: ");
            string modo = Console.ReadLine();

            Console.WriteLine("\nIngrese Fecha de Vencimiento: ");
            string fecha = Console.ReadLine();

            Console.WriteLine("\nIngrese IdCliente: ");
            int idcli = Convert.ToInt32(Console.ReadLine());

            using (var db = new connBD_EF())
            {
                tbTarjeta tarjeta = db.tbTarjeta.Find(idtarjeta);
                tarjeta.numeroTarjeta = numero;
                tarjeta.tipoTarjeta = tipo;
                tarjeta.modoPago = modo;
                tarjeta.fechaVencimiento = fecha;
                tarjeta.idCliente = idcli;

                db.SaveChanges();
            }
        }
    }
}
