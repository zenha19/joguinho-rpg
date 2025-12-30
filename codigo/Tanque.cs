using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace joguinho_pf
{
    internal class Tanque:classedepersonagem
    {
        public Tanque()
        {
            name = "tanque";
            ataque = 25;
            ateataqueespecial =3;//trocar pra zero apos os testes
            ataqueEspecial = 30;
            buffespecial = 12;
            debuffespecial = 7;
            sangramento =0; 
            duraçãoSangramento=0;
            vida = 150;
            velocidade = 1;
            mana = 1;
            escolha = 0;
            buff = 10;
            duraçãodobuff = 0;
            debuff = 7;
            duraçãododebuff = 0;
        }
        public static void AtaqueEspecial(object jogadoratacando,string personagematacando) 
        {
            Console.WriteLine("Voce pode atacar dois dos personagens vivos");
            Console.ReadLine();
            if (jogadoratacando == Program.jogador1)
            {
                int dano = classedepersonagem.buffsdebuffs(jogadoratacando,personagematacando);
                int numerodeatacados=0;
                int index = 0;
                foreach (object obj in Program.jogador2.personagens)
                {
                    if(Program.jogador2.personagens[index].vida>0)
                    {
                        string z="";
                        Console.WriteLine("Deseja atacar o " + Program.jogador2.personagens[index].name);

                        do 
                        {
                            Console.WriteLine("1 atacar      2 não atacar");
                            z=Console.ReadLine() ;    

                        }while(z !="1" && z !="2");

                        if (z == "1") 
                        {
                            Program.jogador2.personagens[index].vida -= dano;
                            numerodeatacados++;
                        }
                        
                    
                    }
                    if(numerodeatacados==2)
                    { break; }
                    index++;

                }
                int b = int.Parse(personagematacando);
                if (Program.jogador1.personagens[b].duraçãoSangramento > 0)
                {
                    Program.jogador1.personagens[b].vida -= Program.jogador1.personagens[b].sangramento;
                    Program.jogador1.personagens[b].duraçãoSangramento -= 1;

                }
                Program.jogador1.personagens[b].ateataqueespecial = 0;

                Program.jogador1.personagens[b].velocidade -= 1;

            }
            else 
            {
                int dano = classedepersonagem.buffsdebuffs(jogadoratacando, personagematacando);
                int numerodeatacados = 0;
                int index = 0;
                foreach (object obj in Program.jogador1.personagens)
                {
                    if (Program.jogador1.personagens[index].vida > 0)
                    {
                        string z = "";
                        Console.WriteLine("Deseja atacar o " + Program.jogador1.personagens[index].name);

                        do
                        {
                            Console.WriteLine("1 atacar      2 não atacar");
                            z=Console.ReadLine();

                        } while (z != "1" && z != "2");

                        if (z == "1")
                        {
                            Program.jogador1.personagens[index].vida -= dano;
                            numerodeatacados++;
                        }


                    }
                    if (numerodeatacados == 2)
                    { break; }
                    index++;

                }
                int b = int.Parse(personagematacando);

                if (Program.jogador2.personagens[b].duraçãoSangramento>0)
                {
                    Program.jogador2.personagens[b].vida -= Program.jogador2.personagens[b].sangramento;
                    Program.jogador2.personagens[b].duraçãoSangramento -= 1;

                }
                Program.jogador2.personagens[b].ateataqueespecial = 0;

                Program.jogador2.personagens[b].velocidade -= 1;

            }
        }
    } 
}
