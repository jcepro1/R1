using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examensb
{
    class Vector
    {
        const int MAX = 50;
        private int[] v;
        private int n;

        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        public void Cargar(int n1, int a, int b)
        {
            Random r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        public void Cargar(int ele)
        {
            n++;
            v[n] = ele;
        }

        public void cargardato(int nele)
        {
            n = nele;
            int num = n;
            for (int i = 1; i <= num; i++)
            {
                v[i] = Conversions.ToInteger(Interaction.InputBox(" ", " "));
            }
        }

        public string Descargar()
        {
            string s = "";
            int i;
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }


        //pregunta 2
        private void insertar(int ele)
        {
            n++;
            v[n] = ele;
        }
        public void ordenar()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = i + 1; j <= n; j++)
                {
                    if (v[i] > v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
                }
            }
        }

        public void ejercicio2(int m)
        {
            Vector pares = new Vector();
            Vector impares = new Vector();

           
            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0) 
                {
                    if (v[i] % 2 == 0) 
                    {
                        pares.insertar(v[i]);
                    }
                    else 
                    {
                        impares.insertar(v[i]);
                    }
                }
            }
            
            pares.ordenar();
            impares.ordenar();

            int ipares = 1;    
            int iimpares = 1;  

            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0) 
                {
                    if (ipares <= pares.n) 
                    {
                        v[i] = pares.v[ipares];
                        ipares++;
                    }
                    else if (iimpares <= impares.n) 
                    {
                        v[i] = impares.v[iimpares];
                        iimpares++;
                    }
                }
            }
        }






    }
}
