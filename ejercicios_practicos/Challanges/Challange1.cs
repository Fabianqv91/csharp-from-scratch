namespace scharp.basic
{

    //Descripción: Solicita al usuario un número y eleva este número al cuadrado solo si es positivo.
    public class Challenge1
    {
        public void Run()
        {
            double numero=0, resultado;



            Console.WriteLine("Por favor, ingresa un número:");



            if (numero > 0)
            {
                // el número al cuadrado si es positivo
                resultado = numero * 2;
                Console.WriteLine($"El resultado es: {resultado}");
            }
            else
                //el número no es positivo, muestra un mensaje
                Console.WriteLine("El número no es positivo, por lo que no se ha elevado al cuadrado.");
        }

    }



    //Descripción: Solicita al usuario dos números. Si el primero es mayor, devuelva 
    //su doble, de lo contrario devuelva el triple del segundo. 
    public class Challenge2
    {
        public void Run()
        {

            double resultado;
            Console.WriteLine("Ingrese el primer número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double num2 = double.Parse(Console.ReadLine());


            if (num1 > num2)
            {
                resultado = num1 * 2;
            }
            else
            {
                resultado = num2 * 3;
            }

            Console.WriteLine($"El resultado es: {resultado}");

        }
    }


    //Descripción: Pide al usuario un número. Si es positivo, devuelve su raíz 
    //cuadrada, de lo contrario, devuelve su cuadrado. 
    public class Challenge3
    {
        public void Run()
        {
            double resultado;
            Console.WriteLine("Ingrese un número:");
            double numero = double.Parse(Console.ReadLine());
            
            

    
            
                if (numero >= 0)
                {
                   resultado= Math.Sqrt(numero); // Devuelve la raíz cuadrada si el número es positivo
                }
                else
                {
                    resultado=Math.Pow(numero, 2); // Devuelve el cuadrado si el número es negativo
                }

                Console.WriteLine($"El resultado es: {resultado}");


            }
        }


        //Descripción: Pide al usuario el radio de un círculo y calcula su perímetro.
        public class Challenge4
        {
            public void Run()
            {
                Console.WriteLine("Ingrese el radio del círculo:");
                double radio = double.Parse(Console.ReadLine());
                double perimetro = CalcularPerimetroCirculo(radio);
                Console.WriteLine($"El perímetro del círculo es: {perimetro}");
            }


            static double CalcularPerimetroCirculo(double radio)
            {
                return 2 * Math.PI * radio;
            }

        }




        //Solicita al usuario un número entre 1 y 7 y muestra el día de la 
        //semana correspondiente, pero solo considerando los días laborables. 
        public class Challenge5
        {
            public void Run()
            {

                Console.WriteLine("Ingrese un número entre 1 y 7:");
                int numero = int.Parse(Console.ReadLine());

                string diaSemana = ObtenerDiaSemana(numero);

               

                //metodo para calcular dia habil
                static string ObtenerDiaSemana(int numero)
                {
                    switch (numero)
                    {
                        case 1:
                            return "Lunes";
                        case 2:
                            return "Martes";
                        case 3:
                            return "Miércoles";
                        case 4:
                            return "Jueves";
                        case 5:
                            return "Viernes";
                        default:
                            return "No es un día laborable";
                    }
                }

                 Console.WriteLine($"El día de la semana correspondiente al número {numero} es: {diaSemana}");

            }
        }


        //Solicita al usuario su salario anual y, si este excede los 12000, 
        //muestra el impuesto a pagar que es el 15% del excedente. 
        public class Challenge6
        {
            public void Run()
            {

                Console.Write("Por favor, ingresa tu salario: ");
                double salario = double.Parse(Console.ReadLine());

                if (salario > 12000)
                {
                    double excedente = salario - 1000;
                    double impuesto = excedente * 0.15;
                    Console.WriteLine("El impuesto a pagar es: {0}", impuesto);
                }
            }
        }


        //Solicita dos números y muestra el residuo de la división del primero entre el segundo. 
        public class Challenge7
        {
            public void Run()
            {
                try
                {
                    Console.WriteLine("numero a dividir");
                    double num = double.Parse(Console.ReadLine());
                    Console.WriteLine("numero divisor");
                    double div = double.Parse(Console.ReadLine());
                    if (div == 0)
                    {
                        throw new DivideByZeroException();
                    }


                    Console.WriteLine($"el resultado  es:{num / div} ");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"no se puede dividir por cero ");
                }
                catch (Exception)
                {
                    Console.WriteLine($"Error ");

                }
            }
        }



        //Calcula y muestra la suma de los números pares entre 1 y 50. 

        public class Challenge8
        {
            public void Run()
            {

                    int suma = 0;
                    for (int i = 2; i <= 50; i += 2)
                    {
                        suma += i;
                    }
                    
                
                
                Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {suma}");
        }
        }


        //Solicita al usuario los valores para dos fracciones y muestra la diferencia entre esas fracciones. 
        public class Challenge9
        {
            public void Run()
            {
                Console.WriteLine("Ingrese el numerador de la primera fracción:");
              int numerador1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el denominador de la primera fracción:");
                int numerador2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el numerador de la segunda fracción:");
               int denominador1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el denominador de la segunda fracción:");
                int denominador2 = int.Parse(Console.ReadLine());

   
                static double CalcularDiferencia(int numerador1, int denominador1, int numerador2, int denominador2)
                {
                    double fraccion1 = (double)numerador1 / denominador1;
                    double fraccion2 = (double)numerador2 / denominador2;
                    return fraccion1 - fraccion2;
                }


                 Console.WriteLine($"La diferencia es {numerador1}/{denominador1} y {numerador2}/{denominador2} es: {CalcularDiferencia(numerador1, denominador1, numerador2, denominador2)}");
            }

        }



        //Pide una palabra al usuario y muestra la longitud de esa palabra.
        public class Challenge10
        {
            public void Run()
            {

                Console.WriteLine("Ingrese una palabra:");
                string palabra = Console.ReadLine();

              
                Console.WriteLine($"La longitud de  \"{palabra}\" es: {palabra.Length}");

            }
        }


        // Pide al usuario cuatro números y muestra el promedio. 
        public class Challenge11
        {
            public void Run()
            {

                Console.WriteLine("Ingrese el primer número:");
                  double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
               double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer número:");
                double numero3 = double.Parse(Console.ReadLine());;

                Console.WriteLine("Ingrese el cuarto número:");
               double numero4 = double.Parse(Console.ReadLine());;

                double promedio = CalcularPromedio(numero1, numero2, numero3, numero4);


                Console.WriteLine($"El promedio de los números ingresados es: {promedio}");


                static double CalcularPromedio(double n1, double n2, double n3, double n4)
                {
                    return (n1 + n2 + n3 + n4) / 4;
                }

                Console.WriteLine($"El promedio de los números  es: {promedio}");
                
            }
        }


        //   Pide al usuario cinco números y muestra el más pequeño. 
        public class Challenge12
        {
            public void Run()
            {

                Console.WriteLine("Ingrese cinco números:");
                double[] num = new double[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    num[i] = LeerNumero();
                }

                double menorNumero = EncontrarMenor(num);

                Console.WriteLine($"El número más pequeño es: {menorNumero}");

                //METODO PARA CALCULAR EL NUMERO MENOR
                 static double EncontrarMenor(double[] numeros)
                {
                    double menor = numeros[0];
                    for (int i = 1; i < numeros.Length; i++)
                    {
                        if (numeros[i] < menor)
                        {
                            menor = numeros[i];
                        }
                    }
                    return menor;
                }
                static double LeerNumero()
                {
                    double numero;
                    while (!double.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine("Por favor, ingrese un número válido:");
                    }
                    return numero;
                }

                
            }

        }


        //Pide una palabra al usuario y devuelve el número de vocales en  esa palabra.

        public class Challenge13
        {
            public void Run()
            {

                Console.WriteLine("Ingrese una palabra:");
                string palabra = Console.ReadLine();

              
                
                    int cont = 0;
                    foreach (char letra in palabra)
                    {
                        if (EsVocal(letra))
                        {
                            cont++;
                        }
                    }
                   
                

                static bool EsVocal(char letra)
                {
                    // Convertimos la letra a minúscula para hacer las comparaciones
                    char letraMinusc = char.ToLower(letra);

                    // Verificamos si la letra es una vocal
                    return letraMinusc == 'a' || letraMinusc == 'e' || letraMinusc == 'i' || letraMinusc == 'o' || letraMinusc == 'u';
                }

                Console.WriteLine($"El número de vocales en la palabra \"{palabra}\" es: {cont}");
            }

        }



        // Pide un número al usuario y devuelve el factorial de ese número. 
        public class Challenge14
        {
            public void Run()
            {

                Console.WriteLine("Ingrese un número para calcular su factorial:");
                 int numero = int.Parse(Console.ReadLine());

                long factorial = CalcularFactorial(numero);

                Console.WriteLine($"El factorial de {numero} es: {factorial}");

             
                static long CalcularFactorial(int numero)
                {
                    if (numero == 0)
                    {
                        return 1;
                    }

                    long resultado = 1;
                    for (int i = 1; i <= numero; i++)
                    {
                        resultado *= i;
                    }
                    return resultado;
                }

            }
        }



        //Pide un número al usuario y verifica si está en el rango de 10 a 20 (ambos incluidos). 
        public class Challenge15
        {
            public void Run()
            {

                Console.WriteLine("Ingrese un número para verificar si está en el rango de 10 a 20:");
                int numero = int.Parse(Console.ReadLine());

                static bool EstaEnRango(int numero, int limiteInferior, int limiteSuperior)
                {
                    return numero >= limiteInferior && numero <= limiteSuperior;
                }

                if (EstaEnRango(numero, 10, 20))
                {
                    Console.WriteLine($"El número {numero} está en el rango de 10 a 20.");
                }
                else
                {
                    Console.WriteLine($"El número {numero} NO está en el rango de 10 a 20.");
                }


            }

        }

    }
