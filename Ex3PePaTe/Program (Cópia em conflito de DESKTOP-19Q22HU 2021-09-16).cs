using System;

namespace Ex3PePaTe
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo game = new Jogo();
            bool status = true;
            Console.WriteLine("- PEDRA PAPEL TESOURA EM C# -");
            do
            {
                Console.WriteLine("Deseja jogar? [1: Sim / 2: Não]");
                Console.Write("-> ");
                int op = int.Parse(Console.ReadLine());
                if(op == 1){
                    game.jogar();
                } else if(op == 2){
                    status = false;
                } else {
                    Console.WriteLine("=- OPÇAO INVALIDA! -=");
                }
            } while (status);
            Console.WriteLine("-= OBRIGADO POR JOGAR! <3 -=");
        }
    }
}
