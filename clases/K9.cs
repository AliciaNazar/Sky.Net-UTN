﻿// Gastón Camú, Alicia Nazar


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Integrador.clases;

namespace TP_Integrador
{
    public class K9 : Operador
    {
        BateriaOperadores valorBateria;
        CargaFisicaOperadores valorCargaFisica;
        public K9(string id, int coordX, int coordY, int cargaBateria, int cargaFisica)
            : base(id, coordX, coordY, cargaBateria, cargaFisica)
        {
        }

        
    }
}
