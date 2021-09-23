using System;
namespace Ex3PePaTe
{
    public class Jogo{
        public Coisa j2;
        public Coisa j1;
        public Jogo(){
            //Random rand = new Random();
            //this.x1 = rand.Next(1, 3);
            //this.x2 = rand.Next(1, 3);
        }

        public void criarJogadores(){
            Random rand = new Random();
            int x1 = rand.Next(1, 4);
            int x2 = rand.Next(1, 4);
            // Cria jogador 1
            if(x1 == 1){
                j1 = new Pedra();
            } else if(x1 == 2){
                j1 = new Papel();
            } else {
                j1 = new Tesoura();
            }
            // Cria jogador 2
            if(x2 == 1){
                j2 = new Pedra();
            } else if(x2 == 2){
                j2 = new Papel();
            } else {
                j2 = new Tesoura();
            }  
        }

        public void compararJogadores(){
            // PEDRA
            if(j1.id == 1){
                compararPedra();
            } else if(j1.id == 2){
                compararPapel();
            } else if (j1.id == 3){
                compararTesoura();
            }
        }

        public void compararTesoura(){
            if(j2.id == 1){
                Console.WriteLine("JOGADOR 2 GANHOU");
            } else if(j2.id == 2){
                Console.WriteLine("JOGADOR 1 GANHOU");
            } else if(j2.id == 3){
                Console.WriteLine("EMPATE");
            }
        }
        public void compararPedra(){
            if(j2.id == 1){
                Console.WriteLine("EMPATE");
            } else if(j2.id == 2){
                Console.WriteLine("JOGADOR 2 GANHOU");
            } else if(j2.id == 3){
                Console.WriteLine("JOGADOR 1 GANHOU");
            }
        }
        public void compararPapel(){
            if(j2.id == 1){
                Console.WriteLine("JOGADOR 1 GANHOU");
            } else if(j2.id == 2){
                Console.WriteLine("EMPATE");
            } else if(j2.id == 3){
                Console.WriteLine("JOGADOR 2 GANHOU");
            }
        }
        
        
        public void jogar(){
            criarJogadores();
            Console.WriteLine($"JOGADOR 1: {j1.nome}");
            Console.WriteLine($"JOGADOR 2: {j2.nome}\n"); 
            compararJogadores();
        }

    }
}