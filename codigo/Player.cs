using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_pf
{
    public class Player
    {
        public string nome="";

        public  List<classedepersonagem> personagens;

        public static void turno()
        {
            int h = 1;
            do
            {

                //teste de velocidade do primeiro personagem

                List<int> number = new List<int> { };

                Random random = new Random();
                int p=0;
                int x = random.Next(0,6);
               

                number.Add(x);
                do
                {
                    Random rando = new Random();
                    int l = rando.Next(0,6);
                    int j=0;
                    
                     foreach (int a in number) 
                     {
                        if (l == a) 
                        {
                            j++;
                        }
                     }
                     if(j >0)
                     {
                        j = 0;
                     }
                    else 
                    {
                        number.Add(l); 
                        p++; 
                    }
                } while (p < 5);
                int d = 0;

              

                do
                {
                    //lista com os personagens com vida positiva e velocidade positiva
                    List<(double,int, string)> numeros = new List<(double a,int c, string b)>
                    {
                    };
                    int y=0;
                    //parametros pra entrar na lista acima
                    do
                    {
                        //remover quando terminar
                        if (d < 3)
                        {
                            if (Program.jogador1.personagens[d].velocidade >= 1 && Program.jogador1.personagens[d].vida > 0)
                            {
                                numeros.Add((Program.jogador1.personagens[d].velocidade,number[y], Program.jogador1.personagens[d].numeros));
                                y++;
                            }
                            else 
                            {
                                Program.jogador1.personagens[d].velocidade = 0;
                            }
                        }
                        d++;
                    } while (d < 3);
                    d = 0;
                    do
                    {
                        //remover quando terminar

                        if (d<3)
                        { 
                             if (Program.jogador2.personagens[d].velocidade >= 1 && Program.jogador2.personagens[d].vida > 0)
                             {
                                 numeros.Add((Program.jogador2.personagens[d].velocidade, number[y], Program.jogador2.personagens[d].numeros));
                                y++;
                             }
                            else 
                            {
                                Program.jogador2.personagens[d].velocidade = 0;
                            }
                        }
                        d++;
                    } while (d < 3);

                    y = 0;

                    //fim dos parametros

                    //organizar as ordens dos numeros
                    numeros.Sort();

                    numeros.Reverse();

                   

                    //fim da organização

                    //variaveis pra dizer qual é o personagem a atacar e de qual jogador é
                    int i = 0;
                    object jogador = Program.jogador1;
                   
                    //pra cada personagem na lista numeros vai fazer uma vereficção pra saber qual o primeiro segundo etc da lista

                    foreach ((double a,int c, string b) in numeros)
                    {
                        switch (b)
                        {
                            case "11":
                                if (Program.jogador1.personagens[0].vida > 0)
                                {
                                    jogador = Program.jogador1;
                                    i = 0;

                                    escolhas.escolha(jogador, i);
                                }
                                break;
                            case "12":
                                if (Program.jogador1.personagens[1].vida > 0)
                                {
                                    jogador = Program.jogador1;
                                    i = 1;

                                    escolhas.escolha(jogador, i);
                                }
                                break;
                            case "13":
                                if (Program.jogador1.personagens[2].vida > 0)
                                {
                                    jogador = Program.jogador1;
                                    i = 2;

                                    escolhas.escolha(jogador, i);
                                }
                                break;
                            case "21":
                                if (Program.jogador2.personagens[0].vida > 0)
                                { 
                                 jogador = Program.jogador2;
                                 i = 0;

                                 escolhas.escolha(jogador, i);
                                }
                                break;
                            case "22":
                                if (Program.jogador2.personagens[1].vida > 0) { 
                                    jogador = Program.jogador2;
                                     i = 1;

                                     escolhas.escolha(jogador, i);
                                }
                                break;
                            case "23":
                                if (Program.jogador2.personagens[2].vida > 0)
                                { 
                                    jogador = Program.jogador2;
                                     i = 2;

                                     escolhas.escolha(jogador, i);
                                }
                                break;

                        }


                    }
                } while (Program.jogador1.personagens[0].velocidade >= 1 || Program.jogador1.personagens[1].velocidade >= 1 || Program.jogador1.personagens[2].velocidade >= 1 || Program.jogador2.personagens[0].velocidade >= 1 || Program.jogador2.personagens[1].velocidade >= 1 || Program.jogador2.personagens[2].velocidade >= 1);

                //quando a velocidade de todos os personagens for menor que 1
                int w = 0;

                do
                {
                    if (Program.jogador1.personagens[w].name == "Assassino" || Program.jogador1.personagens[w].name == "Assassino1" || Program.jogador1.personagens[w].name == "Assassino2")
                    {
                        if (Program.jogador1.personagens[w].vida>0)
                        {
                            Program.jogador1.personagens[w].velocidade = Program.jogador1.personagens[w].velocidade + 1.5;
                        }
                       
                    }
                    else
                    {
                        if (Program.jogador1.personagens[w].vida > 0)
                        { Program.jogador1.personagens[w].velocidade = Program.jogador1.personagens[w].velocidade + 1;  }

                    }

                        w++;

                } while (w < 3);
                w= 0;
                do
                {
                    if (Program.jogador2.personagens[w].name == "Assassino" || Program.jogador2.personagens[w].name == "Assassino1" || Program.jogador2.personagens[w].name == "Assassino2")
                    {
                        if (Program.jogador2.personagens[w].vida > 0)
                        {
                            Program.jogador2.personagens[w].velocidade = Program.jogador2.personagens[w].velocidade + 1.5;
                        }
                    }
                    else
                    {
                        if (Program.jogador2.personagens[w].vida > 0)
                        { Program.jogador2.personagens[w].velocidade = Program.jogador2.personagens[w].velocidade + 1; }
                    }

                    w++;

                } while (w < 3);

                w = 0;

                do
                {
                    if (Program.jogador1.personagens[w].name == "mago" || Program.jogador1.personagens[w].name == "mago1" || Program.jogador1.personagens[w].name == "mago2")
                    {
                        if (Program.jogador1.personagens[w].vida > 0)
                        {
                            Program.jogador1.personagens[w].mana = 2;
                        }

                    }
                    else
                    {
                        if (Program.jogador1.personagens[w].vida > 0)
                        { Program.jogador1.personagens[w].mana =  1; }

                    }

                    w++;

                } while (w < 3);
                w = 0;
                do
                {
                    if (Program.jogador2.personagens[w].name == "mago" || Program.jogador2.personagens[w].name == "mago1" || Program.jogador2.personagens[w].name == "mago2")
                    {
                        if (Program.jogador2.personagens[w].vida > 0)
                        {
                            Program.jogador2.personagens[w].mana = 2;
                        }

                    }
                    else
                    {
                        if (Program.jogador2.personagens[w].vida > 0)
                        { Program.jogador2.personagens[w].mana = 1; }

                    }

                    w++;

                } while (w < 3);


                if ((Program.jogador1.personagens[0].vida > 0 && Program.jogador1.personagens[1].vida > 0 && Program.jogador1.personagens[2].vida > 0) || (Program.jogador2.personagens[0].vida > 0 && Program.jogador2.personagens[1].vida > 0 && Program.jogador2.personagens[2].vida > 0))
                {
                    Console.WriteLine("o jogo acabou");
                }
                else 
                {
                    Console.WriteLine("fim do turno " + h);
                    Console.ReadLine();
                    h++;
                }
                    

               


            } while ((Program.jogador1.personagens[0].vida > 0 || Program.jogador1.personagens[1].vida > 0 || Program.jogador1.personagens[2].vida > 0) && (Program.jogador2.personagens[0].vida > 0 || Program.jogador2.personagens[1].vida > 0 || Program.jogador2.personagens[2].vida > 0));

            if (Program.jogador1.personagens[0].vida <= 0 && Program.jogador1.personagens[1].vida <= 0 && Program.jogador1.personagens[2].vida <= 0)
            {
               Console.WriteLine(Program.jogador2.nome + " VENCEU");
                Console.ReadLine ();
            }
            else 
            {
                Console.WriteLine(Program.jogador1.nome + " VENCEU");
                Console.ReadLine ();
            }
            return;
        }

        public Player()
        {
            personagens = new List<classedepersonagem>();
        }
       
    }
}
