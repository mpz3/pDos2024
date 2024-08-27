using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace pDos2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salioJuego = false;

            while (!salioJuego)
            {
                Console.WriteLine("Selecciona el juego que desees jugar");
                Console.WriteLine("1- Adivina el numero oculto");
                Console.WriteLine("2- Mostrar tabla");
                Console.WriteLine("3- Buscar pares intermedios");
                Console.WriteLine("4- Verificar si se encuentra en el intervalo");
                Console.WriteLine("5- Suma de numero");
                Console.WriteLine("6- Contador de Vocales");
                Console.WriteLine("7- Invertir palabra");
                Console.WriteLine("8- Verificar Palindromo");
                Console.WriteLine("0- Salir de la aplicacion");

                string opcionElegida = Console.ReadLine();

                if (opcionElegida != "0")
                {
                    switch (opcionElegida)
                    {
                        case "1":
                            AdivinaElnumero();
                            break;
                        case "2":
                            MostrarTabla();
                            break;
                        case "3":
                            BuscarPares();
                            break;
                        case "4":
                            VerificarIntermedio();
                            break;
                        case "5":
                            SumaDeNumeros();
                            break;
                        case "6":
                            MostrarVocales();
                            break;
                        case "7":
                            InvertirPalabras();
                            break;
                        case "8":
                            ValidarPalindromo();
                            break;


                        default:
                            mostrarTexto("Debes de seleccionar una opcion valida");
                            break;


                    }
                }
                else
                {
                    salioJuego = true;
                }
            }
        }


        static void AdivinaElnumero()
        {
            Random rdn = new Random();

            int nRandom = rdn.Next(0, 11);

            mostrarTexto("ingresa un numero entre el 1 y 10");
            bool adivino = false;

            do
            {
                int nElegido = int.Parse(Console.ReadLine());
                if (nRandom == nElegido)
                {
                    Console.Clear();
                    mostrarTexto("Felicitaciones adivinaste el numero correctamente");
                    adivino = true;
                }
                else
                {
                    mostrarTexto("ingresa un nuevo numero");
                }
            } while (!adivino);

            Suspenso();

        }
        static void MostrarTabla()
        {
            mostrarTexto("Ingrese el numero del cual desea saber su tabla:");
            int valorIngresado = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{valorIngresado} * {i} = {valorIngresado * i}");
            }
            Suspenso();
        }

        static void BuscarPares()
        {
            mostrarTexto("ingrese un numero:");
            int num1 = int.Parse(Console.ReadLine());
            mostrarTexto("Ingrese otro numero:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                int x = num1;
                num1 = num2;
                num2 = x;
            }

            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Suspenso();

        }



        static void VerificarIntermedio()
        {
            mostrarTexto("Ingrese un valor:");
            int num1 = int.Parse(Console.ReadLine());
            mostrarTexto("Ingrese un numero mayor al anterior:");
            int num2 = int.Parse(Console.ReadLine());
            mostrarTexto("Ingresa un nuevo numero:");
            int num3 = int.Parse(Console.ReadLine());


            for (int i = num1; i <= num2; i++)
            {
                if (i == num3)
                {
                    mostrarTexto("El numero que ingresaste se encuentre dentro de los numeros seleccionados.");
                }
            }

        }

        static void SumaDeNumeros()
        {
            bool valOpcion = false;
            int valorTotal = 0;
            do
            {
                mostrarTexto("Ingrese el numero que desea sumar: ");
                //Console.WriteLine("Ingresa el numero que deseas sumar");
                int numeroSuma = int.Parse(Console.ReadLine());
                if (numeroSuma != 0)
                {
                    valorTotal += numeroSuma;
                    Console.Clear();
                }
                else
                {
                    valOpcion = true;
                }

            } while (!valOpcion);

            Console.WriteLine($"La suma total de los valor ingresados es: {valorTotal}");

            Suspenso();
        }

        static void MostrarVocales()
        {
            mostrarTexto("Ingrese una palabra: ");
            //Console.WriteLine("Ingresa una palabra:");
            string palabraIngresada = Console.ReadLine();
            int contadorVocales = 0;
            string contenedorVocales = "aeiou";

            foreach (char vocal in palabraIngresada)
            {
                if (contenedorVocales.Contains(vocal))
                {
                    contadorVocales++;
                }

            }
            Console.Clear();
            Console.WriteLine($"La cantidad de vocales que contiene la palabra es: {contadorVocales}");
            Suspenso();
        }


        static void InvertirPalabras()
        {
            mostrarTexto("Ingrese una palabra: ");
            //Console.WriteLine("Ingrese una palabra");
            string selPalabra = Console.ReadLine();
            string palabraInv = "";
            //int count = 1;


            for (int i = selPalabra.Length - 1; i >= 0; i--)
            {
                palabraInv = palabraInv + selPalabra[i];
            }
            Console.Clear();
            Console.WriteLine($"Ingresaste la palabra: {selPalabra} y su inversa es: {palabraInv} ");
            Suspenso();
        }

        static void ValidarPalindromo()
        {
            mostrarTexto("Ingresa la palabra que deseas validar: ");
            //Console.WriteLine("Ingresa la palabra que deseas validar:");
            string palabraVal = Console.ReadLine();
            string palabraInv = "";

            for (int i = palabraVal.Length - 1; i >= 0; i--)
            {
                palabraInv = palabraInv + palabraVal[i];
            }

            if (palabraVal == palabraInv)
            {
                Console.WriteLine($"La palabra {palabraVal} es palindromo ya que su inversa es: {palabraInv}");
            }
            else
            {
                Console.WriteLine($"Lo siento la palabra {palabraVal} no es palindromo, ya que su inversa es: {palabraInv}");
            }
            Suspenso();
        }

        static void Suspenso()
        {
            Console.WriteLine("Presiona enter para volver a la pagina inicial");
            Console.ReadLine();
            Console.Clear();
        }

        static void mostrarTexto (string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
