using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_pf
{
    internal class escolhas
    {

        public static void escolha(object c,int b) 
        
        {
            // c é o jogador que tá no turno
            // b é o personagem que tá no turno
            string z;
            string a;
            int e = 0;
            if (c == Program.jogador1)
            {
                //vereficção se o jogador vai atacr ou usar poção

                Console.Clear();
                Console.WriteLine("personagem de " + Program.jogador1.nome);

                switch (b)
                {
                    case 0:
                        Console.WriteLine("turno do "+Program.jogador1.personagens[0].name );
                        break;
                    case 1:
                        Console.WriteLine("turno do " + Program.jogador1.personagens[1].name );
                        break;
                    default:
                        Console.WriteLine("turno do " + Program.jogador1.personagens[2].name );
                        break;
                }

                do
                {
                    Console.WriteLine("1 atacar,2 usar poção");
                    z = Console.ReadLine();
                }while (z != "1" && z!= "2");
                if (z == "1" )
                {
                    //caso ele ataque
                   

                    switch(b)
                    {
                        case 0:
                            Console.WriteLine(Program.jogador1.personagens[0].name+ " está atacando" );
                            break;
                            case 1:
                            Console.WriteLine(Program.jogador1.personagens[1].name + " está atacando");
                            break;
                        default:
                            Console.WriteLine(Program.jogador1.personagens[2].name + " está atacando");
                            break;
                    }

                    if (Program.jogador1.personagens[b].ateataqueespecial >= 3)
                    {
                        string p = "";
                        Console.WriteLine("ataque especial disponiel");
                        Console.WriteLine("1 ataque normal   2 ataque especial");

                        do
                        {
                            p = Console.ReadLine();
                        } while (p != "1" && p != "2");

                        if (p == "2")
                        {
                            p = b.ToString();

                            if (Program.jogador1.personagens[b].name == "Assassino" || Program.jogador1.personagens[b].name == "Assassino1" || Program.jogador1.personagens[b].name == "Assassino2")
                            {
                                Assassino.AtaqueEspecial(Program.jogador1, p);
                                return;
                            }
                            else if (Program.jogador1.personagens[b].name == "mago" || Program.jogador1.personagens[b].name == "mago1" || Program.jogador1.personagens[b].name == "mago2")
                            {
                                Mago.AtaqueEspecial(Program.jogador1, p);
                                return;
                            }
                            else
                            {
                                Tanque.AtaqueEspecial(Program.jogador1, p);
                                return;
                            }
                        }


                    }

                    Console.WriteLine("qual personagem deseja atacar ?");
                    Console.ReadLine();

                    a = VivoMorto.Jogador2();

                    
                    

                    classedepersonagem.Ataque(a, b, c);

                }
                else
                {

                    //caso ele escolha poção

                    Console.WriteLine("deseja dar um buff ou debuff?");
                    z = Pocoes.buffdebuff();
                    if (z == "1") 
                    {
                        switch (b)
                        {
                            case 0:
                                Console.WriteLine(Program.jogador1.personagens[0].name + " está dando buffs");
                                break;
                            case 1:
                                Console.WriteLine(Program.jogador1.personagens[1].name + " está dando buffs");
                                break;
                            default:
                                Console.WriteLine(Program.jogador1.personagens[2].name + " está dando buffs");
                                break;
                        }


                        Console.WriteLine("qual buff deseja dar ?");
                        Console.ReadLine();
                    }
                    else
                    {
                        switch (b)
                        {
                            case 0:
                                Console.WriteLine(Program.jogador1.personagens[0].name + " está dando debuffs");
                                break;
                            case 1:
                                Console.WriteLine(Program.jogador1.personagens[1].name + " está dando debuffs");
                                break;
                            default:
                                Console.WriteLine(Program.jogador1.personagens[2].name + " está dando debuffs");
                                break;
                        }


                        Console.WriteLine("qual debuff deseja dar ?");
                        Console.ReadLine();
                    }



                    a = Pocoes.pocao();

                    Pocoes.general(Program.jogador1,b,a,z, e);


                }



            }
            else 
            {
                Console.Clear();
                //parte do jogador 2
                Console.WriteLine("personagem de " + Program.jogador2.nome);

                switch (b)
                {
                    case 0:
                        Console.WriteLine("turno do " + Program.jogador2.personagens[0].name);
                        break;
                    case 1:
                        Console.WriteLine("turno do " + Program.jogador2.personagens[1].name);
                        break;
                    default:
                        Console.WriteLine("turno do " + Program.jogador2.personagens[2].name);
                        break;
                }
                //vereficção se o jogador vai atacr ou usar poção
                z = "";
                do
                {
                    Console.WriteLine("1 atacar,2 usar poção");
                    z = Console.ReadLine();
                } while (z != "1" && z != "2");

                if (z == "1")
                {
                    //caso ele ataque


                    switch (b)
                    {
                        case 0:
                            Console.WriteLine(Program.jogador2.personagens[0].name + " está atacando");
                            break;
                        case 1:
                            Console.WriteLine(Program.jogador2.personagens[1].name + " está atacando");
                            break;
                        default:
                            Console.WriteLine(Program.jogador2.personagens[2].name + " está atacando");
                            break;
                    }

                    if (Program.jogador2.personagens[b].ateataqueespecial >= 3)
                    {
                        string p = "";
                        Console.WriteLine("ataque especial disponiel");
                        Console.WriteLine("1 ataque normal   2 ataque especial");

                        do
                        {
                            p = Console.ReadLine();
                        } while (p != "1" && p != "2");

                        if (p == "2")
                        {
                            p = b.ToString();

                            if (Program.jogador2.personagens[b].name == "Assassino" || Program.jogador2.personagens[b].name == "Assassino1" || Program.jogador2.personagens[b].name == "Assassino2")
                            {
                                Assassino.AtaqueEspecial(Program.jogador2, p);
                                return;
                            }
                            else if (Program.jogador2.personagens[b].name == "mago" || Program.jogador2.personagens[b].name == "mago1" || Program.jogador2.personagens[b].name == "mago2")
                            {
                                Mago.AtaqueEspecial(Program.jogador2, p);
                                return;
                            }
                            else
                            {
                                Tanque.AtaqueEspecial(Program.jogador2, p);
                                return;
                            }
                        }


                    }

                    Console.WriteLine("qual personagem deseja atacar ?");
                    Console.ReadLine();
                    
                  
                    a = VivoMorto.Jogador1();

                   

                    classedepersonagem.Ataque(a, b, c);
                }
                else
                {
                    //caso ele use pocões
                    Console.WriteLine("deseja dar um buff ou debuff?");
                   

                    z = Pocoes.buffdebuff();
                    if (z == "1")
                    {
                        switch (b)
                        {
                            case 0:
                                Console.WriteLine(Program.jogador2.personagens[0].name + " está dando buffs");
                                break;
                            case 1:
                                Console.WriteLine(Program.jogador2.personagens[1].name + " está dando buffs");
                                break;
                            default:
                                Console.WriteLine(Program.jogador2.personagens[2].name + " está dando buffs");
                                break;
                        }


                        Console.WriteLine("qual buff deseja dar ?");
                        Console.ReadLine();
                    }
                    else 
                    {
                        switch (b)
                        {
                            case 0:
                                Console.WriteLine(Program.jogador2.personagens[0].name + " está dando debuffs");
                                break;
                            case 1:
                                Console.WriteLine(Program.jogador2.personagens[1].name + " está dando debuffs");
                                break;
                            default:
                                Console.WriteLine(Program.jogador2.personagens[2].name + " está dando debuffs");
                                break;
                        }


                        Console.WriteLine("qual debuff deseja dar ?");
                        Console.ReadLine();
                    }
                       

                    a = Pocoes.pocao();

                    Pocoes.general(Program.jogador2, b, a,z, e);
                }

            }
        }
    }
}
