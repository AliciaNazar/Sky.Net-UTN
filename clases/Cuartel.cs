using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Integrador.clases;
using static TP_Integrador.clases.GeneradorDeMapa;

namespace TP_Integrador
{
    public class Cuartel
    {

        List<Operador> operadores = new List<Operador>();
        GeneradorDeMapa generador = new GeneradorDeMapa();

        string[,] mapa;

        int id = 1;
        int operadoresCreados = 0;
        int operadoresActivos = 0;
        int operadoresInactivos = 0;

        private Dictionary<int, K9> operadoresK9 = new Dictionary<int, K9>();
        private Dictionary<int, UAV> operadoresUAV = new Dictionary<int, UAV>();
        private Dictionary<int, M8> operadoresM8 = new Dictionary<int, M8>();

        public Cuartel()
        {
            mapa = generador.ObtenerMapa();
            generador.CrearMapaVacio();
            generador.ActualizarPosicion(generador.coordenadasUbicaciones[Ubicaciones.Cuartel].x, generador.coordenadasUbicaciones[Ubicaciones.Cuartel].y, "Cuartel");
        }
        public void CrearOperador()
        {

            Console.WriteLine("�Que tipo de operador quiere crear?");
            Console.WriteLine("1: para UAV");
            Console.WriteLine("2: para K9");
            Console.WriteLine("3: para M8");
            int seleccionUsuario = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de operadores a crear: ");
            int cantOperadores = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= cantOperadores; i++)
            {

                if (seleccionUsuario == 1)
                {
                    Operador operador = new UAV();
                    operador.id = i.ToString();
                    operadores.Add(operador);
                }
                else if (seleccionUsuario == 2)
                {
                    Operador operador = new K9();
                    operador.id = i.ToString();
                    operadores.Add(operador);
                }
                else if (seleccionUsuario == 3)
                {
                    Operador operador = new M8();
                    operador.id = i.ToString();
                    operadores.Add(operador);
                }
                else
                {
                    Console.WriteLine("opcion incorrecta");
                }
            }
            foreach (var operador in operadores)
            {
                MostrarDetallesOperador(operador);
            }
        }

        public void MostrarDetallesOperador(Operador operador)
        {
            Console.WriteLine(operador.GetType().Name);
            Console.WriteLine("id: " + operador.id);
            Console.WriteLine("estado: " + operador.estado);
            Console.WriteLine("cargaMaxima: " + operador.cargaMaxima + " kg");
            Console.WriteLine("velocidad optima: " + operador.velocidadOptima);
            Console.WriteLine("coordenada actual: " + operador.coordActual[0, 0]);
            Console.WriteLine("");
            Console.WriteLine("BATERIA");
            Console.WriteLine("carga maxima: " + operador.bateria.MostrarCargaMaxima() + " mAh");
            Console.WriteLine("carga actual: " + operador.bateria.MostrarCargaActual() + " mAh");
            Console.WriteLine("---------------------------------------------------------");

        }

        public void MostrarDetallesOperadoresCreados()
        {
            foreach (var operador in operadores)
            {
                MostrarDetallesOperador(operador);
            }
        }

        public void CantidadOperadoresActivos()
        {
/*            Console.WriteLine($"Cantidad de operadores activos: {operadoresActivos} operadores");*/
        }

        public void CantidadOperadoresInactivos()
        {
/*            Console.WriteLine($"Cantidad de operadores en STANDBY: {operadoresInactivos} operadores");*/
        }

        public void CantidadDeOperadoresTotales()
        {
/*            int total = operadoresActivos + operadoresInactivos;
            Console.WriteLine($"Actualmente hay {total} operadores en servicio.");*/
        }

        public void AgregarOperador()
        {
/*            operadoresCreados++;*/
        }

        public void EliminarOperador()
        {
/*            operadoresActivos--;*/
        }

        public void CambiarEstadoOperador()
        {
        }

        public void EnviarOperadorALocalizacion()
        {

        }

        public void TotalRecall()
        {
            // Aqui deberia poder acceder a las coordenadas del cuartel
            var coordenadasCuartel = generador.coordenadasUbicaciones[Ubicaciones.Cuartel];

            // Y con un foreach itero en todos los operadores, y actualizo su coordenada actual por las coordenadas del cuartel
            foreach (var operador in operadores)
            {
                operador.CambiarPosicionACuartel(coordenadasCuartel);
            }
        }
    }
}
