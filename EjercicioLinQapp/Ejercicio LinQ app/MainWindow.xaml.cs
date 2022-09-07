using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio_LinQ_app
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<int> aleatorio()
        {
            var listan = new List<int>();

            Random rnumero = new Random();
            while (listan.Count < 100)
            {
                int num = rnumero.Next(1, 100);

                //if (!listan.Any(x => x == num)) //evita que se repitan los numeros
                //{
                    listan.Add(num);
                //}
            }
            return listan;

        }
        public List<int> Listado()
        {
            int b = 0;
            var lista2 = LstAleatorio1;
            var lista1 = new List<int>();
            for (b = 0; b <= lista2.Items.Count - 1; b ++)
            {
                lista1.Add(Convert.ToInt32(lista2.Items[b].ToString()));
            }
            return lista1;
        }

        public void Aleatorio1()
        {
            int b = 0;
            var lista2 = aleatorio().OrderByDescending(x => x).ToList();

            for (b = 0; b <= lista2.Count - 1; b++)
            {
                 LstAleatorio1.Items.Add(lista2[b].ToString());
            }

        }
        public void Aleatorio2()
        {
            int b = 0;

            var lista2 = Listado().OrderBy(x => x).ToList();

            for (b = 0; b <= lista2.Count - 1; b++)
            {
                LstAleatorio2.Items.Add(lista2[b].ToString());
            }

        }

        public List<int> Primos()
        {
            int b = 1;
            int num = 1;
            int numero = 0;

            var listap = new List<int>();
            bool esprimo = true;

            var lista2 = Listado().OrderBy(x => x).ToList();

            for (num = 0; num <= lista2.Count - 1; num++)
            {
                numero = lista2[num];
                for (b = 2; b < numero; b++)
                {

                    if (numero % b == 0 && numero >= 1)
                    {
                        esprimo = false;
                        break;
                    }
                }
                if (esprimo)
                {
                    listap.Add(numero);
                }

                esprimo = true;

            }
            return listap;
        }

        public void Primos1()
        {
            int b = 0;

            var lista2 = Primos().OrderBy(x => x).ToList();

            for (b = 0; b <= lista2.Count - 1; b++)
            {
                LstPrimos.Items.Add(lista2[b].ToString());
            }

        }

        public void Promedio(int prome1)
        {
            int b = 0;

            var lista2 = Listado().OrderBy(x => x).ToList();

            for (b = 0; b <= lista2.Count - 1; b++)
            {
                if (lista2[b] >= prome1)
                {
                    LstPromedio.Items.Add(lista2[b].ToString() );
                }
            }

        }

        public void Parinpar()
        {
            int b = 0;

            var lista2 = Listado().OrderBy(x => x).ToList();

            for (b = 0; b <= lista2.Count - 1; b++)
            {
                if (lista2[b] % 2 == 0)
                {
                    LstParInpar.Items.Add(lista2[b].ToString() + " es Par");
                }
                else
                {
                    LstParInpar.Items.Add(lista2[b].ToString() + " es Inpar");
                }

            }

        }
        public void Repetido1()
        {
            int b = 0;

            var lista2 = Listado().OrderBy(x => x).GroupBy(x => x).Where(x => x.Count() > 0).Select(x => new { Numero = x.Key, Veces = x.Count() }).ToList();

            for (b = 0; b <= lista2.Count - 1; b++)
            {
                LstRepetido1.Items.Add(lista2[b].ToString());
            }


        }
        public void Repetido2()
        {
            int b = 0;

            var lista2 = Listado().OrderBy(x => x).GroupBy(x => x).Where(x => x.Count() > 1).Select(x => new { Numero = x.Key}).ToList();

            for (b = 0; b <= lista2.Count - 1; b++)
            {
                LstRepetido2.Items.Add(lista2[b].ToString());
            }


        }

        public List<int> Repetido()
        {
            int b = 0;
            var lista2 = Listado().OrderBy(x => x).GroupBy(x => x).Where(x => x.Count() <= 1).Select(x => new { Numero = x.Key }).ToList(); ;
            var listap = new List<int>();

            for (b = 1; b <= lista2.Count - 1; b++)
            {

                listap.Add(lista2[b].Numero);
               
            }
            return listap;

        }

        public void Unico1()
        {
            int b = 0;

            var lista2 = Repetido().OrderBy(x => x).ToList();

            for (b = 0; b <= lista2.Count - 1; b++)
            {
                LstUnico.Items.Add(lista2[b].ToString());
            }


        }

        public MainWindow()
        {
            InitializeComponent();
            
            Aleatorio1();
            Primos1();
            LblSuma.Content = "3.- Suma de Numeros Aleatorios : " + Listado().Sum().ToString() ;
            Aleatorio2();
            LblPromedio.Content = "5.- Numeros mayores al valor promedio :" + Math.Round(Listado().Average(x => x), 2).ToString();
            Promedio(Convert.ToInt32(Listado().Average(x => x)));
            Parinpar();
            Repetido1();
            Repetido2();
            LblUnicos.Content = "9.- Sumatoria de Numeros Unicos : " + Repetido().Sum(x => x);
            Unico1();
        }
    }
}
