using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joguinho_pf
{
    internal class Mago: classedepersonagem
    {
        public Mago()
        {
            name = "mago";
            ataque= 15;
            ataqueEspecial =12;
            buffespecial = 5;
            debuffespecial = 3;
            ateataqueespecial=3;//trocar pra zero apos os testes
            sangramento = 5;
            duraçãoSangramento=0;
            vida = 100;
            velocidade=1;
            mana=2;
            escolha = 0;
            buff = 6;
            duraçãodobuff = 0;
            debuff=4;
            duraçãododebuff=0;
        }
        public static void AtaqueEspecial(object jogadoratacando,string personagematacando) {

            if (jogadoratacando == Program.jogador1) 
            {
                int dano = classedepersonagem.buffsdebuffs(jogadoratacando, personagematacando);
                int index =0;
                foreach (object obj in Program.jogador2.personagens)
                {
                    Program.jogador2.personagens[index].vida -= dano;
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
                int index = 0;
                foreach (object obj in Program.jogador1.personagens)
                {
                    Program.jogador1.personagens[index].vida -= dano;
                    index++ ;
                }

                int b = int.Parse(personagematacando);
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
