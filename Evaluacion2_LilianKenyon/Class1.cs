using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2_LilianKenyon
{
    class promedio
    {
        private string nombre;
        private int numerodecuenta;
        private int nota1;
        private int nota2;
        private int nota3;
        private int nota4;
        private int prom;

        public string Nombre

        {
        get { return nombre; }
        set { nombre = value; }

         }
        public int Numerodecuenta

        {
            get { return numerodecuenta;}
            set { numerodecuenta = value;}
        }

        public int Nota1

        {
            get { return nota1; }
            set { nota1 = value; }
        }


        public int Nota2

        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public int Nota3

        {
            get { return nota3; }
            set { nota3 = value; }
        }
        public int Nota4

        {
            get { return nota4; }
            set { nota4 = value; }
        }

        public int Prom

        {
            get { return prom; }
            set { prom = (nota1+nota2+nota3+nota4)/2; }
        }

        

        public promedio(){}

        public promedio(string _nombre,int _numerodecuenta)
        {
            Nombre = _nombre;
            Numerodecuenta = _numerodecuenta;
        }

        public promedio(string _nombre, int _numerodecuenta, int _nota1, int _nota2, int _nota3,int _nota4, int _prom)
        {
            Nombre = _nombre;
            Numerodecuenta = _numerodecuenta;
            Nota1 = _nota1;
            Nota2 = _nota2;
            Nota3 = _nota3;
            Nota4 = _nota4;
            prom = _prom;



        }

        public string devolverpromedio()

        {
            if (prom>70) { return "Aprobado"; }
            else
            { return "Reprobado"; }
        }

    }

}
