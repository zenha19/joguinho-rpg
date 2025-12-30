using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_pf
{
    internal class VivoMorto
    {
        //está função serve inteiramente pra vereficar quais personagens estão vivos
        //pra evitar coisas como atacar mortos ou reviver mortos
        public static string Jogador1() 
           
        {
            string a = "";
            if (Program.jogador1.personagens[0].vida > 0 && Program.jogador1.personagens[1].vida > 0 && Program.jogador1.personagens[2].vida > 0)
            {
                do
                {
                    Console.WriteLine("0 " + Program.jogador1.personagens[0].name + "." + Program.jogador1.personagens[0].vida + "HP");
                    Console.WriteLine("1 " + Program.jogador1.personagens[1].name + "." + Program.jogador1.personagens[1].vida + "HP");
                    Console.WriteLine("2 " + Program.jogador1.personagens[2].name + "." + Program.jogador1.personagens[2].vida + "HP");
                    a = Console.ReadLine();
                } while (a != "0" && a != "1" && a != "2");
                return a;

            }
            else if (Program.jogador1.personagens[0].vida > 0 && Program.jogador1.personagens[1].vida > 0)
            {
                do
                {
                    Console.WriteLine("0 " + Program.jogador1.personagens[0].name + "." + Program.jogador1.personagens[0].vida + "HP");
                    Console.WriteLine("1 " + Program.jogador1.personagens[1].name + "." + Program.jogador1.personagens[1].vida + "HP");

                    a = Console.ReadLine();
                } while (a != "0" && a != "1");
                return a;

            }
            else if (Program.jogador1.personagens[0].vida > 0 && Program.jogador1.personagens[2].vida > 0)
            {
                do
                {
                    Console.WriteLine("0 " + Program.jogador1.personagens[0].name + "." + Program.jogador1.personagens[0].vida + "HP");
                    Console.WriteLine("2 " + Program.jogador1.personagens[2].name + "." + Program.jogador1.personagens[2].vida + "HP");

                    a = Console.ReadLine();
                } while (a != "0" && a != "2");
                return a;

            }
            else if (Program.jogador1.personagens[1].vida > 0 && Program.jogador1.personagens[2].vida > 0)
            {
                do
                {
                    Console.WriteLine("1 " + Program.jogador1.personagens[1].name + "." + Program.jogador1.personagens[1].vida + "HP");
                    Console.WriteLine("2 " + Program.jogador1.personagens[2].name + "." + Program.jogador1.personagens[2].vida + "HP");

                    a = Console.ReadLine();
                } while (a != "1" && a != "2");
                return a;
            }
            else if (Program.jogador1.personagens[0].vida > 0)
            {
                Console.WriteLine("0 " + Program.jogador1.personagens[0].name + "." + Program.jogador1.personagens[0].vida + "HP");
                Console.ReadLine();
                a = "0";
                return a;
            }
            else if (Program.jogador1.personagens[1].vida > 0)
            {
                Console.WriteLine("1 " + Program.jogador1.personagens[1].name + "." + Program.jogador1.personagens[1].vida + "HP");
                Console.ReadLine();
                a = "1";
                return a;
            }
            else if (Program.jogador1.personagens[2].vida > 0)
            {
                Console.WriteLine("2 " + Program.jogador1.personagens[2].name + "." + Program.jogador1.personagens[2].vida + "HP");
                Console.ReadLine();
                a = "2";
                return a;
            }
            else 
            {
                Program.jogador1.personagens[0].velocidade = 0;
                Program.jogador1.personagens[1].velocidade = 0;
                Program.jogador1.personagens[2].velocidade = 0;
                Program.jogador2.personagens[0].velocidade = 0;
                Program.jogador2.personagens[1].velocidade = 0;
                Program.jogador2.personagens[2].velocidade = 0;
                a = "";
                Player.turno();
                return a;
                
            }
        }
        public static string Jogador2()
        {
            string a = "";
            if (Program.jogador2.personagens[0].vida > 0 && Program.jogador2.personagens[1].vida > 0 && Program.jogador2.personagens[2].vida > 0)
            {
                do
                {
                    Console.WriteLine("0 " + Program.jogador2.personagens[0].name + "." + Program.jogador2.personagens[0].vida + "HP");
                    Console.WriteLine("1 " + Program.jogador2.personagens[1].name + "." + Program.jogador2.personagens[1].vida + "HP");
                    Console.WriteLine("2 " + Program.jogador2.personagens[2].name + "." + Program.jogador2.personagens[2].vida + "HP");
                    a = Console.ReadLine();
                } while (a != "0" && a != "1" && a != "2");
                return a;

            }
            else if (Program.jogador2.personagens[0].vida > 0 && Program.jogador2.personagens[1].vida > 0)
            {
                do
                {
                    Console.WriteLine("0 " + Program.jogador2.personagens[0].name + "." + Program.jogador2.personagens[0].vida + "HP");
                    Console.WriteLine("1 " + Program.jogador2.personagens[1].name + "." + Program.jogador2.personagens[1].vida + "HP");

                    a = Console.ReadLine();
                } while (a != "0" && a != "1");
                return a;

            }
            else if (Program.jogador2.personagens[0].vida > 0 && Program.jogador2.personagens[2].vida > 0)
            {
                do
                {
                    Console.WriteLine("0 " + Program.jogador2.personagens[0].name + "." + Program.jogador2.personagens[0].vida + "HP");
                    Console.WriteLine("2 " + Program.jogador2.personagens[2].name + "." + Program.jogador2.personagens[2].vida + "HP");

                    a = Console.ReadLine();
                } while (a != "0" && a != "2");
                return a;

            }
            else if (Program.jogador2.personagens[1].vida > 0 && Program.jogador2.personagens[2].vida > 0)
            {
                do
                {
                    Console.WriteLine("1 " + Program.jogador2.personagens[1].name + "." + Program.jogador2.personagens[1].vida + "HP");
                    Console.WriteLine("2 " + Program.jogador2.personagens[2].name + "." + Program.jogador2.personagens[2].vida + "HP");

                    a = Console.ReadLine();
                } while (a != "1" && a != "2");
                return a;
            }
            else if (Program.jogador2.personagens[0].vida > 0)
            {
                Console.WriteLine("0 " + Program.jogador2.personagens[0].name + "." + Program.jogador2.personagens[0].vida + "HP");
                Console.ReadLine();
                a = "0";
                return a;
            }
            else if (Program.jogador2.personagens[1].vida > 0)
            {
                Console.WriteLine("1 " + Program.jogador2.personagens[1].name + "." + Program.jogador2.personagens[1].vida + "HP");
                Console.ReadLine();
                a = "1";
                return a;
            }
            else if (Program.jogador2.personagens[2].vida > 0)
            {
                Console.WriteLine("2 " + Program.jogador2.personagens[2].name + "." + Program.jogador2.personagens[2].vida + "HP");
                Console.ReadLine();
                a = "2";
                return a;
            }
            else
            {
                Program.jogador1.personagens[0].velocidade = 0;
                Program.jogador1.personagens[1].velocidade = 0;
                Program.jogador1.personagens[2].velocidade = 0;
                Program.jogador2.personagens[0].velocidade = 0;
                Program.jogador2.personagens[1].velocidade = 0;
                Program.jogador2.personagens[2].velocidade = 0;
                a = "";
                Player.turno();
                return a;
            }
        }
    }
}
