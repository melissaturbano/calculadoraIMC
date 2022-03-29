using System;

namespace calculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? Ex: 1,63");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em kg? Ex: 59,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("{0}, sua altura é {1} e seu peso é {2}", nome, altura, peso);

            Console.WriteLine("Seu IMC é {0}", imc);

            if (imc < 17 ) {
                Console.WriteLine("Muito abaixo do peso");
            }

            if (imc >= 17 && imc < 18.50) {
                Console.WriteLine("Abaixo do peso");
            }

            if (imc >= 18.50 && imc < 25) {
                Console.WriteLine("Peso normal");
            }

            if (imc >= 25 && imc < 30) {
                Console.WriteLine("Acima do peso");
            }

            if (imc >= 30 && imc < 35) {
                Console.WriteLine("Obesidade I");
            }

            if (imc >= 35 && imc < 40) {
                Console.WriteLine("Obesidade II (severa)");
            }

            if (imc > 40) {
                Console.WriteLine("Obesidade III (mórbida)");
            }




        }
    }
}
