using System;

namespace ValidaçãoInformações
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de dados");
            Console.WriteLine("------------");

            Console.WriteLine("Digite o nome de usuário:");
            string nome = Console.ReadLine();

            while (nome == "")
            {
                Console.WriteLine("O nome não pode ser vazio.");
                Console.WriteLine("Digite o novo nome de usuário:");
                Console.ReadLine();
            }

            Console.WriteLine("Digite a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            while (idade < 0 || idade > 150)
            {
                Console.WriteLine("A idade deve ser entre 0 e 150");
                Console.WriteLine("Digite a sua idade novamente");
                int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o seu salário:");
            float salario = float.Parse(Console.ReadLine());
            

            while (salario <= 0)
            {
                Console.Write("O salário deve ser maior que 0.");
                salario = float.Parse(Console.ReadLine());
            }
            
            
                Console.WriteLine("Selecione uma das opções de estado civil");
                Console.WriteLine("s - solteiro");
                Console.WriteLine("c - casado");
                Console.WriteLine("v - viúvo");
                Console.WriteLine("d - divorciado");
                string estado = Console.ReadLine();
            
            if (estado != "s" && estado != "c" && estado != "v" && estado != "d")
            {
                Console.WriteLine("Opção inválida. Por favor, digite novamente.");
                estado = Console.ReadLine();
            }

            switch (estado)
            {
                case "s":
                Console.WriteLine("Você selecionou solteiro.");
                break;

                case "c":
                Console.WriteLine("Você selecionou casado.");
                break;

                case "v":
                Console.WriteLine("Você selecionou viúvo.");
                break;

                case "d":
                Console.WriteLine("Você selecionou divorciado.");
                break;
                
            }
            

        }
    }
}
