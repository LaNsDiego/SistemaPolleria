﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaPolleria.Ayuda
{
    abstract class ClsNRequerido
    {
        public static bool EnteroValido(string texto, int cantidadEsperada = 0)
        {
            bool resultado;
            int numero;
            if (cantidadEsperada == 0)
            {

                resultado = (Int32.TryParse(texto, out numero));
                if (!resultado)
                {
                    Console.WriteLine("No es entero valido:" + texto);
                }
            }
            else
            {
                resultado = Int32.TryParse(texto, out numero) && LongitudValida(texto, cantidadEsperada);
                if (!resultado)
                {
                    Console.WriteLine("No es entero valido:" + texto);
                }
            }
            return resultado;
        }

        public static bool EsDecimal(string NumeroDecimal)
        {
            double price;
            bool EsDecimal = Double.TryParse(NumeroDecimal, out price);
            if (!EsDecimal) { Console.WriteLine("No es Decimal Valido:["+NumeroDecimal+"]"); }
            return EsDecimal;

        }

        public static bool LongitudValida(string texto, int cantidadEsperada)
        {
            int cantidadReal = texto.Length;
            return cantidadEsperada == cantidadReal;
        }

        public static bool AlfabeticoValido(string texto)
        {
            bool permitido = false;
            if (texto.Contains(" "))
            {
                string[] campos = texto.Split(' ');
                for (int i = 0; i < campos.Length; i++)
                {
                    if (!Regex.IsMatch(campos[i], @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Alfabetico Campo No valido : " + campos[i]);
                        return false;
                    }
                }
                return true;
            }
            else
            {
                permitido = Regex.IsMatch(texto, @"^[a-zA-Z]+$");
                if (!permitido)
                {
                    Console.WriteLine("Alfabetico No valido : " + texto);
                }
            }
            return permitido;
        }

    }
}
