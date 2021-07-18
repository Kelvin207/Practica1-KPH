using EntityFramework_ADONET.DAO;
using EntityFramework_ADONET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            string rpta = "N";
            do
            {
                Console.Clear();
                Console.WriteLine("Mantenimiento BD");
                Console.WriteLine("\n1 - CRUD Cliente");
                Console.WriteLine("2 - CRUD Tarjeta");
                Console.WriteLine("3 - CRUD Pais");                
                Console.WriteLine("\n Ingrese Opción: ");
                int opcion;
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {                    
                    case 1:
                        ClienteDAO cliDAO_EF = new ClienteDAO();
                        Console.Clear();
                        Console.WriteLine("Mantenimiento Cliente");
                        Console.WriteLine("\n1 - Registrar Cliente");
                        Console.WriteLine("2 - Listar Cliente");
                        Console.WriteLine("3 - Actualizar Cliente");
                        Console.WriteLine("\n Ingrese Opción: ");
                        int opcion1;
                        opcion1 = Convert.ToInt32(Console.ReadLine());
                        switch (opcion1)
                        {
                            case 1:
                                cliDAO_EF.RegistrarClienteEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 2:
                                cliDAO_EF.ListarClienteEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 3:
                                cliDAO_EF.ListarClienteEF();
                                cliDAO_EF.ActualizarClienteEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        TarjetaDAO tarjDAO_EF = new TarjetaDAO();
                        ClienteDAO cliDAO_EF1 = new ClienteDAO();
                        Console.Clear();
                        Console.WriteLine("Mantenimiento Tarjeta");
                        Console.WriteLine("\n1 - Registrar Tarjeta");
                        Console.WriteLine("2 - Listar Tarjeta");
                        Console.WriteLine("3 - Actualizar Tarjeta");
                        Console.WriteLine("\n Ingrese Opción: ");
                        int opcion2;
                        opcion2 = Convert.ToInt32(Console.ReadLine());
                        switch (opcion2)
                        {
                            case 1:
                                cliDAO_EF1.ListarClienteEF();
                                tarjDAO_EF.RegistrarTarjetaEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 2:
                                tarjDAO_EF.ListarTarjetaEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 3:
                                tarjDAO_EF.ListarTarjetaEF();
                                cliDAO_EF1.ListarClienteEF();
                                tarjDAO_EF.ActualizarTarjetaEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        PaisDAO paisDAO_EF = new PaisDAO();
                        Console.Clear();
                        Console.WriteLine("Mantenimiento País");
                        Console.WriteLine("\n1 - Registrar País");
                        Console.WriteLine("2 - Listar País");
                        Console.WriteLine("3 - Actualizar País");
                        Console.WriteLine("\n Ingrese Opción: ");
                        int opcion3;
                        opcion3 = Convert.ToInt32(Console.ReadLine());
                        switch (opcion3)
                        {
                            case 1:
                                paisDAO_EF.RegistrarPaisEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 2:
                                paisDAO_EF.ListarPaisEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            case 3:
                                paisDAO_EF.ListarPaisEF();
                                paisDAO_EF.ActualizarPaisEF();
                                Console.WriteLine("\n¿Desea Continuar? (S/N) ");
                                rpta = Console.ReadLine();
                                break;
                            default:
                                break;
                        }

                        break;
                    default:
                        break;
                }

            } while (rpta == "S" || rpta == "s");
        }
    }
}
