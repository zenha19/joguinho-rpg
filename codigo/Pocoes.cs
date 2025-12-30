using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_pf
{
    //a é o jogador que está jogando
    //b é o numero do personagem escolhido
    //z é as escolhas que ele vai fazendo
    //c é pra armazenar a velocidade que ele vai ganhar
    //y é o z em int pra diminuir o codigo usado
    //d vai ser usado pra defenir o buff
    //e pra evitar que o mago use uma poção e depois ataque
    //o pra vereficar se é buff ou debuff
    internal class Pocoes
    {
        public static void general(object a, int b, string d,string o,int e)
        {
            
            //parte do jogaodr 1
            if (a == Program.jogador1)
            {
                if (Program.jogador1.personagens[b].mana > 0)
                {
                    string z;
                    double c;

                    string x = "";
                    if (o == "1")
                    {
                        Console.WriteLine("a qual personagem deseja dar o buff");
                        //aqui se escolhe o personagem a quem o buff vai ser concedido
                        z = VivoMorto.Jogador1();


                        int y = int.Parse(z);
                        //aqui se faz a verevicação de qual buff ele escolheu mais cedo na função escolhas
                        if (d == "0")
                        {
                            Program.jogador1.personagens[y].vida += 15;
                        }
                        else if (d == "1")
                        {
                            c = Program.jogador1.personagens[y].velocidade / 4;

                            Program.jogador1.personagens[y].velocidade += c;

                        }
                        else
                        {
                            //pra evitar que o buff de ataque fique se acumulando
                            //também evita ter de criar variaveis diferentes pra acompanhar cada buff de ataque
                            if (Program.jogador1.personagens[y].duraçãodobuff > 0)
                            {
                                if (e == 0)
                                {
                                    Console.WriteLine("este personagem já têm um buff de ataque ativo");
                                    Console.ReadLine();

                                    Console.WriteLine("Deseja voltar pra escolher entre ataque e poção ou");
                                    Console.WriteLine(" escolher outro buff/debuff pra seu personagem dar ?");
                                    do
                                    {
                                        Console.WriteLine("1 ou 2 ?");
                                        z = Console.ReadLine();

                                    } while (z != "1" && z != "2");

                                    if (z == "1")
                                    {
                                        //caso ele escolha voltar pra o menu de ataque ou poção
                                        escolhas.escolha(Program.jogador1, b);
                                        return;
                                    }
                                    else
                                    {
                                        //caso ele escolha simplesmente outro buff ou o ataque pra outro personagem
                                        Console.WriteLine("deseja dar um buff ou debuff ?");

                                        Console.ReadLine();

                                        z = Pocoes.buffdebuff();

                                        d = Pocoes.pocao();



                                        Pocoes.general(Program.jogador1, b, d, z, e);
                                        return;
                                    }
                                }
                                else
                                {
                                    //está parte é especifica pra prevenir de o mago atacar apos ter dado um buff 

                                    Console.WriteLine("esse personagem já têm um buff de ataque");
                                    Console.WriteLine("escolha outro buff/debuff ou de o buff de ataque a outro personagem");
                                    Console.WriteLine("deseja dar um buff ou debuff ?");

                                    Console.ReadLine();

                                    z = Pocoes.buffdebuff();

                                    d = Pocoes.pocao();

                                    Pocoes.general(Program.jogador1, b, d, z, e);

                                    return;




                                }

                            }
                            else
                            {
                                //caso não tenha nehum buff de ataque ativo adiciona um mais quantos ataques vai ter o buff ativo 
                                

                                Program.jogador1.personagens[y].duraçãodobuff += 3;
                            }

                        }
                    }
                    else
                    {
                        //parte do debuff
                        Console.WriteLine("a qual personagem deseja dar o debuff");
                        //aqui se escolhe o personagem a quem o buff vai ser concedido
                        z = VivoMorto.Jogador2();

                        int y = int.Parse(z);

                        //aqui se faz a verevicação de qual buff ele escolheu mais cedo na função escolhas
                        if (d == "0")
                        {
                            Program.jogador2.personagens[y].vida -= 10;
                        }
                        else if (d == "1")
                        {
                            c = Program.jogador2.personagens[y].velocidade / 5;

                            Program.jogador2.personagens[y].velocidade -= c;

                        }
                        else
                        {
                            //pra evitar que o buff de ataque fique se acumulando
                            //também evita ter de criar variaveis diferentes pra acompanhar cada buff de ataque
                            if (Program.jogador1.personagens[y].duraçãododebuff > 0)
                            {
                                if (e == 0)
                                {
                                    Console.WriteLine("este personagem já têm um debuff de ataque ativo");
                                    Console.ReadLine();

                                    Console.WriteLine("Deseja voltar pra escolher entre ataque e poção ou");
                                    Console.WriteLine(" escolher outro buff/debuff pra seu personagem dar ?");
                                    do
                                    {
                                        Console.WriteLine("1 ou 2 ?");
                                        z = Console.ReadLine();

                                    } while (z != "1" && z != "2");

                                    if (z == "1")
                                    {
                                        //caso ele escolha voltar pra o menu de ataque ou poção
                                        escolhas.escolha(Program.jogador1, b);
                                        return;
                                    }
                                    else
                                    {

                                        //caso ele escolha simplesmente outro buff ou o ataque pra outro personagem
                                        Console.WriteLine("deseja dar um buff ou debuff ?");

                                        Console.ReadLine();

                                        z = Pocoes.buffdebuff();

                                        d = Pocoes.pocao();

                                        Pocoes.general(Program.jogador1, b, d, z, e);
                                        return;
                                    }
                                }
                                else
                                {
                                    //está parte é especifica pra prevenir de o mago atacar apos ter dado um buff 
                                    Console.Clear();
                                    Console.WriteLine("esse personagem já têm um debuff de ataque");
                                    Console.WriteLine("escolha outro buff/debuff ou de o buff de ataque a outro personagem");
                                    Console.WriteLine("deseja dar um buff ou debuff ?");

                                    Console.ReadLine();

                                    z = Pocoes.buffdebuff();

                                    d = Pocoes.pocao();

                                    Pocoes.general(Program.jogador1, b, d, z, e);
                                    return;




                                }

                            }
                            else
                            {
                                //caso não tenha nehum buff de ataque ativo adiciona um mais quantos ataques vai ter o buff ativo 
                              

                                Program.jogador2.personagens[y].duraçãododebuff += 3;
                            }


                        }

                    }

                    e = 0;

                    Program.jogador1.personagens[b].mana -= 1;


                    //este if é principalmente pra o mago pelo fato de ele ter 2 de mana pode usar dois buffs
                    //caso não seja um mago ou o mago ja tiver usado a mana toda
                    //só vai rebastecer o mana,provavelmente devo mudar isso pra o player
                    //pra evitar de caso um personagem fique com dois de velocidade usar mais poções no mesmo turno ou
                    // deixo assim ainda não fiz uma decisão


                    if (Program.jogador1.personagens[b].mana == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("segunda poção");
                        z = "";
                        x = Pocoes.buffdebuff();

                        z = Pocoes.pocao();

                        e = 1;
                        Pocoes.general(Program.jogador1, b, z, x, e);


                        return;


                    }
                    else
                    {
                        Program.jogador1.personagens[b].velocidade -= 1;

                    }
                }
                else
                {
                    Console.WriteLine("o seu personagem não têm mana suficiente o que resta é atacar alguem");
                    Console.WriteLine("escolha o personagem a ser atacado");
                    Console.ReadLine();

                    string z = "";

                    z=VivoMorto.Jogador2();

                    classedepersonagem.Ataque(z, b, a);
                }
                if (Program.jogador1.personagens[b].duraçãoSangramento > 0)
                {
                    Program.jogador1.personagens[b].vida -= Program.jogador1.personagens[b].sangramento;
                    Program.jogador1.personagens[b].duraçãoSangramento -= 1;
                }
            }
            else
            {
                if (Program.jogador2.personagens[b].mana > 0)
                {
                    //começo das situações do jogador 2(mesma coisa que o jogador 1 mas adaptado pra o 2)
                    string z;
                    double c;
                    string x = "";


                    if (o == "1")
                    {
                        Console.WriteLine("a qual personagem deseja dar o buff");

                        //aqui se escolhe o personagem a quem o buff vai ser concedido

                        z = VivoMorto.Jogador2();

                        int y = int.Parse(z);

                        //aqui se faz a verevicação de qual buff ele escolheu mais cedo na função escolhas
                        if (d == "0")
                        {
                            Program.jogador2.personagens[y].vida += 15;
                        }
                        else if (d == "1")
                        {
                            c = Program.jogador2.personagens[y].velocidade / 4;

                            Program.jogador2.personagens[y].velocidade += c;



                        }
                        else
                        {
                            //pra evitar que o buff de ataque fique se acumulando
                            //também evita ter de criar variaveis diferentes pra acompanhar cada buff de ataque
                            if (Program.jogador2.personagens[y].duraçãodobuff > 0)
                            {
                                if (e == 0)
                                {
                                    Console.WriteLine("este personagem já têm um buff de ataque ativo");
                                    Console.ReadLine();

                                    Console.WriteLine("Deseja voltar pra escolher entre ataque é poção ou");
                                    Console.WriteLine(" escolher outra poção pra o mesmo perssonagem ?");
                                    do
                                    {
                                        Console.WriteLine("1 ou 2 ?");
                                        z = Console.ReadLine();

                                    } while (z != "1" && z != "2");

                                    if (z == "1")
                                    {
                                        //caso ele escolha voltar pra o menu de ataque ou poção
                                        escolhas.escolha(Program.jogador2, b);
                                        return;
                                    }
                                    else
                                    {
                                        //caso ele escolha simplesmente outro buff ou o ataque pra outro personagem
                                        Console.WriteLine("deseja dar um buff ou debuff ?");

                                        Console.ReadLine();

                                        z = Pocoes.buffdebuff();

                                        d = Pocoes.pocao();

                                        Pocoes.general(Program.jogador2, b, d, z, e);
                                        return;
                                    }
                                }
                                else
                                {
                                    //está parte é especifica pra prevenir de o mago atacar apos ter dado um buff 
                                    Console.Clear();
                                    Console.WriteLine("esse personagem já têm um buff de ataque");
                                    Console.WriteLine("escolha outro buff/debuff ou de o buff de ataque a outro personagem");
                                    Console.WriteLine("deseja dar um buff ou debuff ?");

                                    Console.ReadLine();

                                    z = Pocoes.buffdebuff();

                                    d = Pocoes.pocao();


                                    Pocoes.general(Program.jogador2, b, d, z, e);
                                    e = 0;
                                    return;
                                }
                            }
                            else
                            {

                               

                                Program.jogador2.personagens[y].duraçãodobuff += 3;
                            }
                        }

                    }
                    else
                    {
                        //parte do debuff
                        Console.WriteLine("a qual personagem deseja dar o debuff");
                        //aqui se escolhe o personagem a quem o buff vai ser concedido
                        z = VivoMorto.Jogador1();

                        int y = int.Parse(z);

                        //aqui se faz a verevicação de qual buff ele escolheu mais cedo na função escolhas
                        if (d == "0")
                        {
                            Program.jogador1.personagens[y].vida -= 10;
                        }
                        else if (d == "1")
                        {
                            c = Program.jogador1.personagens[y].velocidade / 5;

                            Program.jogador1.personagens[y].velocidade -= c;

                        }
                        else
                        {


                            //pra evitar que o buff de ataque fique se acumulando
                            //também evita ter de criar variaveis diferentes pra acompanhar cada buff de ataque
                            if (Program.jogador1.personagens[y].duraçãododebuff > 0)
                            {
                                if (e == 0)
                                {
                                    Console.WriteLine("este personagem já têm um debuff de ataque ativo");
                                    Console.ReadLine();

                                    Console.WriteLine("Deseja voltar pra escolher entre ataque e poção ou");
                                    Console.WriteLine(" escolher outro buff/debuff pra seu personagem dar ?");
                                    do
                                    {
                                        Console.WriteLine("1 ou 2 ?");
                                        z = Console.ReadLine();

                                    } while (z != "1" && z != "2");

                                    if (z == "1")
                                    {
                                        //caso ele escolha voltar pra o menu de ataque ou poção
                                        escolhas.escolha(Program.jogador2, b);
                                        return;
                                    }
                                    else
                                    {
                                        //caso ele escolha simplesmente outro buff ou o ataque pra outro personagem
                                        Console.WriteLine("deseja dar um buff ou debuff ?");

                                        Console.ReadLine();

                                        z = Pocoes.buffdebuff();

                                        d = Pocoes.pocao();

                                        Pocoes.general(Program.jogador2, b, d, z, e);
                                        return;
                                    }
                                }
                                else
                                {
                                    //está parte é especifica pra prevenir de o mago atacar apos ter dado um buff 
                                    Console.Clear();

                                    Console.WriteLine("esse personagem já têm um buff de ataque");
                                    Console.WriteLine("escolha outro buff/debuff ou de o buff de ataque a outro personagem");
                                    Console.WriteLine("deseja dar um buff ou debuff ?");

                                    Console.ReadLine();

                                    z = Pocoes.buffdebuff();

                                    d = Pocoes.pocao();

                                    Pocoes.general(Program.jogador2, b, d, z, e);
                                    return;


                                }

                            }
                            else
                            {
                                //caso não tenha nehum buff de ataque ativo adiciona um mais quantos ataques vai ter o buff ativo 
                               

                                Program.jogador1.personagens[y].duraçãododebuff += 3;
                            }

                        }
                    }

                    Program.jogador2.personagens[b].mana -= 1;



                    e = 0;


                    //este if é principalmente pra o mago pelo fato de ele ter 2 de mana pode usar dois buffs
                    //caso não seja um mago ou o mago ja tiver usado a mana toda
                    // só vai rebastecer o mana,provavelmente devo mudar isso pra o player
                    //pra evitar de caso um personagem fique com dois de velocidade usar mais poções no mesmo turno ou
                    // deixo assim ainda não fiz uma decisão


                    if (Program.jogador2.personagens[b].mana == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("segunda poção");
                        z = "";
                        x = Pocoes.buffdebuff();

                        z = Pocoes.pocao();
                        e = 1;

                        Pocoes.general(Program.jogador2, b, z, x, e);


                        return;

                    }
                    else
                    {
                        Program.jogador2.personagens[b].velocidade -= 1;
                    }
                }
                else 
                {
                    Console.WriteLine("o seu personagem não têm mana suficiente o que resta é atacar alguem");
                    Console.WriteLine("escolha o personagem a ser atacado");
                    Console.ReadLine();

                    string z = "";

                    z = VivoMorto.Jogador1();
                    
                    classedepersonagem.Ataque(z, b, a);
                }
                if (Program.jogador2.personagens[b].duraçãoSangramento > 0)
                {
                    Program.jogador2.personagens[b].vida -= Program.jogador2.personagens[b].sangramento;
                    Program.jogador2.personagens[b].duraçãoSangramento -= 1;

                }
            }
        } 

        public static string  buffdebuff()
        {
            string z = "";
            do
            {
                Console.WriteLine("1 buff");
                Console.WriteLine("2 debuff");

                z = Console.ReadLine();


            } while (z != "1" && z != "2");

            return z;
        }
        public static string pocao()
        {
            string d = "";

            do
            {
                Console.WriteLine("0 vida");
                Console.WriteLine("1 velocidade");
                Console.WriteLine("2 ataque");

                d = Console.ReadLine();

            } while (d != "0" && d != "1" && d != "2");

            return d;
        }
    }

    
}
