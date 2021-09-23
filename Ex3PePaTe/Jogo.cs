using System;
namespace Ex3PePaTe
{
    public class Jogo{
        //public int x1;
        //public int x2;
        public Jogo(){
            //Random rand = new Random();
            //this.x1 = rand.Next(1, 3);
            //this.x2 = rand.Next(1, 3);
        }

        public void criarJogadores(){
            Random rand = new Random();
            int x1 = rand.Next(1, 3);
            int x2 = rand.Next(1, 3);
            // Cria jogador 1
            if(x1 == 1){
                Coisa j1 = new Pedra();
            } else if(x1 == 2){
                Coisa j1 = new Papel();
            } else {
                Coisa j1 = new Tesoura();
            }
            // Cria jogador 2
            if(x2 == 1){
                Coisa j2 = new Pedra();
            } else if(x2 == 2){
                Coisa j2 = new Papel();
            } else {
                Coisa j2 = new Tesoura();
            }
            
        }

        public void compararJogadores(Coisa j1, Coisa j2){
            if( (j1 as Pedra).id == 1 || (j1 as Papel).id == 2){
                Console.WriteLine("JOGADOR 1 GANHOU");
            }


        }
        
        public void jogar(){
            criarJogadores();
            compararJogadores(j1, j2);
            Console.WriteLine("JOGADOR 1 GANHOU");
        }

    }
}