﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsConcepts
{
    public class CalculadoraIMC
    {
        public float Calcular(float peso, float altura)
        {
            float imc = peso / (altura * altura);

            return imc;
        }

        public string Status(float imc)
        {
            string status = string.Empty;
            if (imc < 16)
                status = "magreza grave";
            else if (imc <= 16.9)
                status = "magreza moderada";
            else if (imc <= 18.5)
                status = "magreza leve";
            else if (imc <= 24.9)
                status = "peso ideal";
            else if (imc <= 29.9)
                status = "sobrepeso";
            else if (imc <= 34.9)
                status = "obesidade grau 1";
            else if (imc <= 39.9)
                status = "obesidade grau 2";
            else
                status = "obesidade grau 3";

            return status;
        }

        public string StatusComPesoEAltura(float peso, float altura)
        {
            float imc = peso / (altura * altura);
            
            string status = string.Empty;
            if (imc < 16)
                status = "magreza grave";
            else if (imc <= 16.9)
                status = "magreza moderada";
            else if (imc <= 18.5)
                status = "magreza leve";
            else if (imc <= 24.9)
                status = "peso ideal";
            else if (imc <= 29.9)
                status = "sobrepeso";
            else if (imc <= 34.9)
                status = "obesidade grau 1";
            else if (imc <= 39.9)
                status = "obesidade grau 2";
            else
                status = "obesidade grau 3";

            return status;
        }
    }
   
}
