using EntityFramework_ADONET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ADONET.DAO
{
    public class PaisDAO
    {
        public void ListarPaisEF()
        {
            List<tbPais> lista = new List<tbPais>();
            using (var db = new connBD_EF())
            {
                lista = db.tbPais.ToList();
            }
            Console.WriteLine("\nLista de Países");
            foreach (var item in lista)
            {
                Console.WriteLine("idPais \t codigoPais \t nombrePais");
                Console.WriteLine(item.idPais + "\t" + item.codigoPais + "\t" + item.nombrePais);
            }
        }

        public void RegistrarPaisEF()
        {
            Console.WriteLine("\nIngrese nombre País: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("\nIngrese Código de País: ");
            string codigo = Console.ReadLine();
            
            tbPais pais = new tbPais { nombrePais = nombre, codigoPais = codigo};
            using (var db = new connBD_EF())
            {
                db.tbPais.Add(pais);
                db.SaveChanges();
            }
            Console.WriteLine("\nSe registró correctamente");
        }
        public void ActualizarPaisEF()
        {
            Console.WriteLine("\nIngrese el ID de País a actualizar:");
            int idpais = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese nombre País: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("\nIngrese Código de País: ");
            string codigo = Console.ReadLine();

            using (var db = new connBD_EF())
            {
                tbPais pais = db.tbPais.Find(idpais);
                pais.nombrePais = nombre;
                pais.codigoPais = codigo;
                
                db.SaveChanges();
            }
        }
    }
}
