using System;
using System.Collections.Generic;
using System.Text;

namespace CalcularNomina
{
    public class Nomina
    {
        private int diasLaborados;

        public int DiasLaborados { get; set; }

        //Metos para calcualr la nomina
        public decimal CalcularNomina (int diasLab, decimal valorDia)
        {
            decimal totalSalario = diasLab * valorDia;
            return totalSalario;
        }
    }
}
