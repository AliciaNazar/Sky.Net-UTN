﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador
{
    public abstract class Operador
    {

        public string id { get; set; }
        public Bateria bateria { get; set; }
        public string estado { get; set; }
        public int cargaMaxima { get; set; }
        public int cargaActual { get; set; }
        public int velocidadOptima { get; set; }
        public int[,] coordActual = new int[13, 13];

        public Operador(int[,] coordActual)
        {
            Random randy = new Random();

            this.id = "0";
            this.bateria = new Bateria();
            this.estado = "enEspera";
            this.cargaMaxima = 0;
            this.cargaActual = 0;
            this.velocidadOptima = 1;
            this.coordActual=coordActual;
        }
        public void ComprobarBateriaActual()
        {
            Console.WriteLine("carga maxima: " + bateria.MostrarCargaMaxima());
            Console.WriteLine("carga actual: " + bateria.MostrarCargaActual());
        }
        public void TransferirCargaBateria(Operador operador1, Operador operador2, int carga)
        {
            operador1.bateria.DescargarBateria(carga);
            operador2.bateria.RecargarBateria(carga);
        }
        public void TransferirCargaFisica(Operador operador1, Operador operador2, int carga)
        {
        }
        public void CargarBateria()
        {

        }

        public void VerificarProximidadConOperador()
        {

        }
        public void VerificarEstado()
        {

        }
        public abstract void Mover(int[,] coordDeDestino, int[,] coordMapa);
    }

}
