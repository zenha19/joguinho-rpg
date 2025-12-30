using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_pf
{
    public class classedepersonagem
    {
        public string name;
        public int ataque;
        public  int ataqueEspecial;
        public  int buffespecial;
        public  int debuffespecial;
        public  int buffdesangramento;
        public int debuffdesangramento;
        public int ateataqueespecial;
        public int sangramento;
        public int duraçãoSangramento;
        public int vida;
        public double velocidade;
        public int mana;
        public int escolha;
        public string numeros;
        public int buff;
        public int duraçãodobuff;
        public int debuff;
        public int duraçãododebuff;


        public static void Ataque(string a, int i, object jogador)
        {
            // a que se torna c é o personagem que está a ser atacado
            // i é o personagem atacando
            // jogador é o jogador atacando
            // g é pra calcular a diferença entre o buff e o debuff caso ambos estejam ativos

            int c = int.Parse(a);

            int d = 0;
            int g = 0;



            if (jogador == Program.jogador1)
            {
                //jogador1
                if (Program.jogador1.personagens[i].duraçãodobuff > 0 || Program.jogador1.personagens[i].duraçãododebuff > 0)
                {
                    if (Program.jogador1.personagens[i].duraçãododebuff > 0 && Program.jogador1.personagens[i].duraçãodobuff > 0)
                    {
                        g = Program.jogador1.personagens[i].buff - Program.jogador1.personagens[i].debuff;

                        d = g + Program.jogador1.personagens[i].ataque;

                        Program.jogador2.personagens[c].vida -= d;

                        Program.jogador1.personagens[i].duraçãodobuff -= 1;

                        Program.jogador1.personagens[i].duraçãododebuff -= 1;


                    }
                    else if (Program.jogador1.personagens[i].duraçãodobuff > 0)
                    {
                        d = Program.jogador1.personagens[i].ataque + Program.jogador1.personagens[i].buff;

                        Program.jogador2.personagens[c].vida -= d;

                        Program.jogador1.personagens[i].duraçãodobuff -= 1;


                    }
                    else
                    {
                        d = Program.jogador1.personagens[i].ataque - Program.jogador1.personagens[i].debuff;

                        Program.jogador2.personagens[c].vida -= d;

                        Program.jogador1.personagens[i].duraçãododebuff -= 1;

                    }



                    Program.jogador1.personagens[i].velocidade -= 1;
                }
                else
                {
                    //caso não tenha nehum buff ou só vai usar o ataque
                    Program.jogador2.personagens[c].vida -= Program.jogador1.personagens[i].ataque;

                    Program.jogador1.personagens[i].velocidade -= 1;
                }
                Program.jogador1.personagens[i].ateataqueespecial += 1;
                if (Program.jogador1.personagens[i].duraçãoSangramento > 0)
                {
                    Program.jogador1.personagens[i].vida -= Program.jogador1.personagens[i].sangramento;
                    Program.jogador1.personagens[i].duraçãoSangramento -= 1;

                }
            }
            else
            {
                //jogador2
                if (Program.jogador2.personagens[i].duraçãodobuff > 0 || Program.jogador2.personagens[i].duraçãododebuff > 0)
                {
                    if (Program.jogador2.personagens[i].duraçãododebuff > 0 && Program.jogador2.personagens[i].duraçãodobuff > 0)
                    {
                        g = Program.jogador2.personagens[i].buff - Program.jogador2.personagens[i].debuff;

                        d = g + Program.jogador2.personagens[i].ataque;

                        Program.jogador1.personagens[c].vida -= d;

                        Program.jogador2.personagens[i].duraçãodobuff -= 1;

                        Program.jogador2.personagens[i].duraçãododebuff -= 1;


                    }
                    else if (Program.jogador2.personagens[i].duraçãodobuff > 0)
                    {
                        d = Program.jogador2.personagens[i].ataque + Program.jogador2.personagens[i].buff;

                        Program.jogador1.personagens[c].vida -= d;

                        Program.jogador2.personagens[i].duraçãodobuff -= 1;


                    }
                    else
                    {
                        d = Program.jogador2.personagens[i].ataque - Program.jogador2.personagens[i].debuff;

                        Program.jogador1.personagens[c].vida -= d;

                        Program.jogador2.personagens[i].duraçãododebuff -= 1;

                    }



                    Program.jogador2.personagens[i].velocidade -= 1;
                }
                else
                {
                    //caso não tenha nehum buff só vai usar o ataque
                    Program.jogador1.personagens[c].vida -= Program.jogador2.personagens[i].ataque;

                    Program.jogador2.personagens[i].velocidade -= 1;
                }
                if (Program.jogador2.personagens[i].duraçãoSangramento > 0)
                {
                    Program.jogador2.personagens[i].vida -= Program.jogador2.personagens[i].sangramento;
                    Program.jogador2.personagens[i].duraçãoSangramento -= 1;

                }
                Program.jogador2.personagens[i].ateataqueespecial += 1;
            }
        }
        public static int buffsdebuffs(object jogadoratacando, string personagematacando)
        {
            int g = 0;
            int d = 0;
            int b = int.Parse(personagematacando);
            if (jogadoratacando == Program.jogador1)

            {
                //jogador1
                if (Program.jogador1.personagens[b].duraçãodobuff > 0 || Program.jogador1.personagens[b].duraçãododebuff > 0)
                {
                    if (Program.jogador1.personagens[b].duraçãododebuff > 0 && Program.jogador1.personagens[b].duraçãodobuff > 0)
                    {
                        g = Program.jogador1.personagens[b].buffespecial- Program.jogador1.personagens[b].debuffespecial; //adcionar espcial

                        d = g + Program.jogador1.personagens[b].ataqueEspecial;

                        

                        Program.jogador1.personagens[b].duraçãodobuff -= 1;

                        Program.jogador1.personagens[b].duraçãododebuff -= 1;

                        return d;
                    }
                    else if (Program.jogador1.personagens[b].duraçãodobuff > 0)
                    {
                        d = Program.jogador1.personagens[b].ataqueEspecial + Program.jogador1.personagens[b].buffespecial;


                        Program.jogador1.personagens[b].duraçãodobuff -= 1;
                        return d;


                    }
                    else
                    {
                        d = Program.jogador1.personagens[b].ataqueEspecial - Program.jogador1.personagens[b].debuffespecial;



                        Program.jogador1.personagens[b].duraçãododebuff -= 1;
                        return d;

                    }




                }
                else
                {
                    //caso não tenha nehum buff ou só vai usar o ataque
                    d = Program.jogador1.personagens[b].ataqueEspecial;

                    return d;
                }
            }
            else
            {
                //jogador2
                if (Program.jogador2.personagens[b].duraçãodobuff > 0 || Program.jogador2.personagens[b].duraçãododebuff > 0)
                {
                    if (Program.jogador2.personagens[b].duraçãododebuff > 0 && Program.jogador2.personagens[b].duraçãodobuff > 0)
                    {
                        g = Program.jogador2.personagens[b].buffespecial - Program.jogador2.personagens[b].debuffespecial;

                        d = g + Program.jogador2.personagens[b].ataqueEspecial;



                        Program.jogador2.personagens[b].duraçãodobuff -= 1;

                        Program.jogador2.personagens[b].duraçãododebuff -= 1;

                        return d;

                    }
                    else if (Program.jogador2.personagens[b].duraçãodobuff > 0)
                    {
                        d = Program.jogador2.personagens[b].ataqueEspecial + Program.jogador2.personagens[b].buffespecial;



                        Program.jogador2.personagens[b].duraçãodobuff -= 1;

                        return d;

                    }
                    else
                    {
                        d = Program.jogador2.personagens[b].ataqueEspecial - Program.jogador2.personagens[b].debuffespecial;



                        Program.jogador2.personagens[b].duraçãododebuff -= 1;
                        return d;

                    }




                }
                else
                {
                    //caso não tenha nehum buff só vai usar o ataque
                    d= Program.jogador2.personagens[b].ataqueEspecial;

                    return d;
                }


            }
        }
    }
}