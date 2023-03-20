namespace JogoAdivinhacao {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("*************** BEM-VINDO AO JOGO DA ADIVINHAÇÃO TOP 2023 ****************");
            Console.WriteLine("\r\n(1) Fácil = 15 chances\r\n(2) Médio = 10 chances\r\n(3) Difícil = 5 chances");
            Console.Write("\nDados as informações acima, escolha a dificuldade: ");
            int dificuldade = int.Parse(Console.ReadLine());
            int chances = 1, tentativas = 1;

            switch (dificuldade) {
                case 1: chances = 15; break;
                case 2: chances= 10; break;
                case 3: chances= 5; break;
            }
            
            Console.WriteLine("Tente adivinhar o valor entre 1 e 20.");
            

            Random random = new Random();
            int numeroSecreto = random.Next(1, 21);
            int palpite = 99999;
            int pontuacao = 1000;

            while ((palpite != numeroSecreto) && (tentativas <= chances)) {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"Tentativa {tentativas} de {chances}");
                Console.Write("\nDigite o palpite: ");
                palpite = int.Parse(Console.ReadLine());
               
                tentativas++;
                
                
                if (palpite < 0 || palpite > 20) {
                    System.Console.WriteLine($"\nO número {palpite} está fora da faixa de valor permitida!");
                } else if (palpite < numeroSecreto) {
                    System.Console.WriteLine($"\nErrou! O número secreto é MAIOR do que {palpite}");
                    pontuacao = (pontuacao) - 50;
                } else if (palpite > numeroSecreto) {
                    System.Console.WriteLine($"\nErrou! O número secreto é MENOR do que {palpite}");
                    pontuacao = (pontuacao) - 50;
                } else {
                    System.Console.WriteLine($"\nParabéns! Você acertou o número! Sua pontuação: {pontuacao}");
                    break;
                }
            }
            
            if(tentativas >= chances){
                Console.WriteLine("\nTentativas esgotadas!");
            }
            

        }
    }
}