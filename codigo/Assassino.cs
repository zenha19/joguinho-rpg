using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace joguinho_pf
{
    internal class Assassino:classedepersonagem
    {
        public Assassino()
        {
            name = "Assassino";
            ataque = 25;
            vida = 100;
            ateataqueespecial =3;//trocar pra zero apos os testes
            ataqueEspecial =45;
            buffespecial = 20;
            debuffespecial = 12;
            buffdesangramento = 3;
            debuffdesangramento = 2;
            sangramento =5;
            duraçãoSangramento=0;
            velocidade = 1.5;
            mana = 1;
            escolha = 0;
            numeros = "";
            buff = 10;
            duraçãodobuff=0;
            debuff =7;
            duraçãododebuff = 0 ;



        }
        public static void AtaqueEspecial(object jogadoratacando, string personagematacando) 
        {
            string a = "";
          
           
            
            if (jogadoratacando == Program.jogador1)    
            {
                int b = int.Parse(personagematacando);
                int d = 0;
                int g = 0;
                int sangramentobase=5;
                
                if (Program.jogador1.personagens[b].duraçãodobuff > 0 || Program.jogador1.personagens[b].duraçãododebuff > 0)
                {
                    if (Program.jogador1.personagens[b].duraçãododebuff > 0 && Program.jogador1.personagens[b].duraçãodobuff > 0)
                    {
                        g = Program.jogador1.personagens[b].buffdesangramento - Program.jogador1.personagens[b].debuffdesangramento; //adcionar espcial

                        d = g + sangramentobase;

                        //acionar parte do ataque especial

                        Program.jogador1.personagens[b].duraçãodobuff -= 1;

                        Program.jogador1.personagens[b].duraçãododebuff -= 1;

                       
                    }
                    else if (Program.jogador1.personagens[b].duraçãodobuff > 0)
                    {
                        d = sangramentobase + Program.jogador1.personagens[b].buffdesangramento;

                        //acionar parte do ataque especial

                        Program.jogador1.personagens[b].duraçãodobuff -= 1;
                       


                    }
                    else
                    {
                        d = sangramentobase - Program.jogador1.personagens[b].debuffdesangramento;



                        Program.jogador1.personagens[b].duraçãododebuff -= 1;
                        
                    }




                }
                else
                {
                    //caso não tenha nehum buff ou só vai usar o ataque
                    d = sangramentobase;

                    
                }
                int c = 0;
                Console.WriteLine("Qual personaem deseja atacar?");
                a = VivoMorto.Jogador2();
                c = int.Parse(a);
                int dano = classedepersonagem.buffsdebuffs(jogadoratacando, personagematacando);
                Program.jogador2.personagens[c].vida -= dano;
                Program.jogador2.personagens[c].sangramento = d;
                Program.jogador2.personagens[c].duraçãoSangramento += 3;


               
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
                int b = int.Parse(personagematacando);
                int d = 0;
                int g = 0;
                int sangramentobase = 5;
                if (Program.jogador2.personagens[b].duraçãodobuff > 0 || Program.jogador2.personagens[b].duraçãododebuff > 0)
                {
                    if (Program.jogador2.personagens[b].duraçãododebuff > 0 && Program.jogador2.personagens[b].duraçãodobuff > 0)
                    {
                        g = Program.jogador2.personagens[b].buffdesangramento - Program.jogador2.personagens[b].debuffdesangramento; //adcionar espcial

                        d = g + sangramentobase;

                        //acionar parte do ataque especial

                        Program.jogador2.personagens[b].duraçãodobuff -= 1;

                        Program.jogador2.personagens[b].duraçãododebuff -= 1;


                    }
                    else if (Program.jogador2.personagens[b].duraçãodobuff > 0)
                    {
                        d = sangramentobase + Program.jogador2.personagens[b].buffdesangramento;

                        //acionar parte do ataque especial

                        Program.jogador2.personagens[b].duraçãodobuff -= 1;



                    }
                    else
                    {
                        d = sangramentobase - Program.jogador2.personagens[b].debuffdesangramento;



                        Program.jogador2.personagens[b].duraçãododebuff -= 1;

                    }




                }
                else
                {
                    //caso não tenha nehum buff ou só vai usar o ataque
                    d = sangramentobase;


                }
                int c = 0;
                Console.WriteLine("Qual personaem deseja atacar?");
                a = VivoMorto.Jogador1();
                c = int.Parse(a);
                int dano = classedepersonagem.buffsdebuffs(jogadoratacando, personagematacando);

                Program.jogador1.personagens[c].vida -= dano;
                Program.jogador1.personagens[c].sangramento = d;
                Program.jogador1.personagens[c].duraçãoSangramento += 3;

               
             
                if (Program.jogador2.personagens[b].duraçãoSangramento > 0)
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
