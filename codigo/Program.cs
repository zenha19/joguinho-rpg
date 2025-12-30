using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_pf
{
    internal class Program
    {
        public static Player jogador1 = new Player();
        public static Player jogador2 = new Player();
        public static void Main(string[] args)
        {
           
            
            // jogadores escolhendo seus nomes
            


           Console.WriteLine("primeiro jogador, escolha o seu nome.");
           jogador1.nome = Console.ReadLine();
           if (jogador1.nome == "")
           {
               Console.WriteLine("o seu nome é nada.");
               jogador1.nome = "nada";

           }
           Console.WriteLine("segundo jogador, escolha o seu nome.");

           jogador2.nome = Console.ReadLine();
           if (jogador2.nome == "")
           {
               Console.WriteLine("o seu nome é nada.");
               jogador2.nome = "nada";
               Console.ReadLine();
           }

           if (jogador1.nome == jogador2.nome | jogador2.nome == jogador1.nome)
           {
               Console.WriteLine("copiando o amiguinho, vou adicionar um 2 pa diferenciar");
               jogador2.nome = jogador2.nome + "2";
               Console.ReadLine();

           }

           
            //fim da escolha dos nomes

            //começo da escolha dos personagens 😎😀😀😀😀


            

            
            Console.WriteLine($"{jogador1.nome}, escolha os seus personagens.");
            Console.ReadLine();

            string a = "";
            string b = "";
            string c = "";




            Console.WriteLine("1 mago experiente em magia; ");
            Console.WriteLine("2 assassino é rapido; ");
            Console.WriteLine("3 tanque tem mais vida; ");
            do
            {
                Console.WriteLine("primeiro personagem:selecione o número do personagem desejado.");
                a = Console.ReadLine();
            }
            while (a != "1" && a != "2" && a != "3");

            if (a == "1")
            {
                Mago mago1 = new Mago();
                jogador1.personagens.Add(mago1);
                mago1.numeros = "11";
                
            }
            else if (a == "2")
            {
                Assassino assassino1 = new Assassino();
                jogador1.personagens.Add(assassino1);
                assassino1.numeros = "11";
            }
            else
            {
                Tanque tanque1 = new Tanque();
                jogador1.personagens.Add(tanque1);
                tanque1.numeros = "11";
            }

            do
            {
                Console.WriteLine("segundo personagem:selecione o número do personagem desejado.");
                b = Console.ReadLine();
            }
            while (b != "1" && b != "2" && b != "3");

            if (b == "1")
            {
                Mago mago2 = new Mago();
                jogador1.personagens.Add(mago2);
                mago2.numeros = "12";
                Program.jogador1.personagens[1].name = "mago1";
            }
            else if (b == "2")
            {
                Assassino assassino2 = new Assassino();
                jogador1.personagens.Add(assassino2);
                assassino2.numeros = "12";
                Program.jogador1.personagens[1].name = "Assassino1";
            }
            else
            {
                Tanque tanque2 = new Tanque();
                jogador1.personagens.Add(tanque2);
                tanque2.numeros = "12";
                Program.jogador1.personagens[1].name = "tanque1";
            }

            do
            {
                Console.WriteLine("terceiro personagem:selecione o número do personagem desejado.");
                c = Console.ReadLine();
            }
            while (c != "1" && c != "2" && c != "3");

            if (c == "1")
            {
                Mago mago3 = new Mago();
                jogador1.personagens.Add(mago3);
                mago3.numeros = "13";
                Program.jogador1.personagens[2].name = "mago2";
            }
            else if (c == "2")
            {
                Assassino assassino3 = new Assassino();
                jogador1.personagens.Add(assassino3);
                assassino3.numeros = "13";
                Program.jogador1.personagens[2].name = "Assassino2";
            }
            else
            {
                Tanque tanque3 = new Tanque();
                jogador1.personagens.Add(tanque3);
                tanque3.numeros = "13";
                Program.jogador1.personagens[2].name = "tanque2";
            }

            Console.Clear();
            //fim da escolha do personagem 1

            //começo da parte do personagem 2
            Console.WriteLine($"{jogador2.nome}, escolha os seus personagens.");
            Console.ReadLine();

            string a2 = "";
            string b2 = "";
            string c2 = "";




            Console.WriteLine("1 mago experiente em magia;");
            Console.WriteLine("2 assassino é rapido;");
            Console.WriteLine("3 tanque tem mais vida;");
            do
            {
                Console.WriteLine("primeiro personagem:selecione o número do personagem desejado.");
                a2 = Console.ReadLine();
            }
            while (a2 != "1" && a2 != "2" && a2 != "3");

            if (a2 == "1")
            {

                Mago mago12 = new Mago();
                jogador2.personagens.Add(mago12);
                mago12.numeros = "21";
               

            }
            else if (a2 == "2")
            {
                Assassino assassino12 = new Assassino();
                jogador2.personagens.Add(assassino12);
                assassino12.numeros = "21";
            }
            else
            {
                Tanque tanque12 = new Tanque();
                jogador2.personagens.Add(tanque12);
                tanque12.numeros = "21";
            }


            do
            {
                Console.WriteLine("segundo personagem:selecione o número do personagem desejado.");
                b2 = Console.ReadLine();
            }
            while (b2 != "1" && b2 != "2" && b2 != "3");

            if (b2 == "1")
            {
                Mago mago22 = new Mago();
                jogador2.personagens.Add(mago22);
                mago22.numeros = "22";
                Program.jogador2.personagens[1].name = "mago1";
            }
            else if (b2 == "2")
            {
                Assassino assassino22 = new Assassino();
                jogador2.personagens.Add(assassino22);
                assassino22.numeros = "22";
                Program.jogador2.personagens[1].name = "Assassino1";
            }
            else
            {
                Tanque tanque22 = new Tanque();
                jogador2.personagens.Add(tanque22);
                tanque22.numeros = "22";
                Program.jogador2.personagens[1].name = "tanque1";
            }
            do
            {
                Console.WriteLine("terceiro personagem:selecione o número do personagem desejado.");
                c2 = Console.ReadLine();
            }
            while (c2 != "1" && c2 != "2" && c2 != "3");

            if (c2 == "1")
            {
                Mago mago32 = new Mago();
                jogador2.personagens.Add(mago32);
                mago32.numeros = "23";
                Program.jogador2.personagens[2].name = "mago2";
            }
            else if (c2 == "2")
            {
                Assassino assassino32 = new Assassino();
                jogador2.personagens.Add(assassino32);
                assassino32.numeros = "23";
                Program.jogador2.personagens[2].name = "Assassino2";
            }
            else
            {
                Tanque tanque32 = new Tanque();
                jogador2.personagens.Add(tanque32);
                tanque32.numeros = "23";
                Program.jogador2.personagens[2].name = "tanque2";
            }
          
            Player.turno();
        
        }
    }
}
