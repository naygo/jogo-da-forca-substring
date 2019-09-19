using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Nayla_Gomes__TP01___2019___1
{
    class Program
    {
        //NOME DO PROGRAMADOR(A): Nayla Cristina Gomes Carvalho da Silva.
        //OBJETIVO DO PROGRAMA: Jogo da forca com dois jogadores, um insere a palavra e o outro tenta adivinhar.

        static void Main(string[] args)
        {
            //Declaração das variáveis
            int acertos = 0, erros = 1, j = 0, chances = 7, encontradas, naoEncontradas, opcao;
            string palavra, letra, letrasInseridas = "", chutar;
            bool fimJogo = false, repetida = false;

            //Requirindo e lendo a palavra do JOGADOR 1
            Console.WriteLine("================ JOGO DA FORCA ================");
            Console.Write("\nJOGADOR 1 insira a palavra a ser adivinhada \n=> ");
            palavra = Console.ReadLine().ToUpper();

            //Limpando o console para o JOGADOR 2 não ver a palavra
            Console.Clear();

            //Alertando que a palavra foi inserida e mostrando o total de casas
            Console.WriteLine("\n\nPalavra inserida! Total de letras: " + palavra.Length + "\n");
            while (j < palavra.Length)
            {
                Console.Write(" ___ ");
                j++;
            }

            //Avisando o JOGADOR 2 que é a vez dele e pedindo que chute uma letra
            Console.WriteLine("\n\n\nSua vez JOGADOR 2! Hora de tentar adivinhar a palavra! \nVocê tem 7 chances!");

            //Estrutura de repetiçao que roda enquanto as 7 tentativas não acabarem
            do
            {
                Console.Write("\n\nDigite uma letra! \n==> ");
                letra = Console.ReadLine().ToUpper();

                encontradas = 0;
                naoEncontradas = 0;
                repetida = false;

                //Verificação de letras repetidas
                for (int r = 0; r < letrasInseridas.Length; r++)
                {
                    if (letrasInseridas.Substring(r, 1) != letra && repetida == false)
                        repetida = false;
                    else
                        repetida = true;
                }

                //Bloco que defini o que será feito se a letra for repetida. Se for a vericação de que se a letra pertence à palavra é pulada
                if (repetida == true)
                    Console.WriteLine("Letra já digitada!");
                else
                    if (repetida == false)
                {
                    //Verificação da letra na palavra
                    for (int i = 0; i < palavra.Length; i++)
                    {
                        if (letra == palavra.Substring(i, 1))
                        {
                            acertos++;
                            encontradas++;
                            Console.WriteLine("A letra " + letra + " está na posição " + (i + 1));
                        }
                        else
                        {
                            naoEncontradas++;
                        }
                    }

                    //Caso a letra não seja encontrada na palavra
                    if (naoEncontradas == palavra.Length)
                    {
                        chances--;
                        erros++;
                        Console.WriteLine("A letra " + letra + " não existe na palavra");
                        Console.WriteLine("CHANCES: " + chances);

                        //Boneco da forca é desenhado se o JOGADOR 2 errar, de acordo com o restante das chances
                        if (chances == 6)
                        {
                            Console.WriteLine("\n\n-----|");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|========|");
                        }
                        else
                            if (chances == 5)
                        {
                            Console.WriteLine("\n\n-----|");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|========|");
                        }
                        else
                            if (chances == 4)
                        {
                            Console.WriteLine("\n\n-----|");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|  /");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|========|");
                        }
                        else
                            if (chances == 3)
                        {
                            Console.WriteLine("\n\n-----|");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|  / |");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|========|");
                        }
                        else
                            if (chances == 2)
                        {
                            Console.WriteLine("\n\n-----|");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|  / | \\ ");
                            Console.WriteLine("|");
                            Console.WriteLine("|");
                            Console.WriteLine("|========|");
                        }
                        else
                            if (chances == 1)
                        {
                            Console.WriteLine("\n\n-----|");
                            Console.WriteLine("|    |");
                            Console.WriteLine("|    O");
                            Console.WriteLine("|  / | \\ ");
                            Console.WriteLine("|   /");
                            Console.WriteLine("|");
                        }
                    }

                    //Caso a letra seja encontrada na palavra
                    else
                        if (encontradas > 0)
                    {
                        Console.Write("ACERTOS: " + acertos + " DE: " + palavra.Length);
                    }

                    //Verificando se o JOGADOR 2 acertou todas as letras, senão é perguntado se ele deseja arriscar uma palavra
                    if (acertos == palavra.Length)
                        fimJogo = true;
                    else
                    {
                        Console.Write("\n\nChutar uma palavra? \n1 para SIM \n2 para NÃO \n=> ");
                        opcao = int.Parse(Console.ReadLine());

                        //Verificando se a palavra chutada foi acertada, se sim o JOGADOR 2 ganha o o jogo, se não ele perde uma chance e o boneco é mostrado
                        switch (opcao)
                        {
                            case 1:
                                Console.Write("\nQual palavra você acha que é? \n=> ");
                                chutar = Console.ReadLine().ToUpper();
                                if (chutar == palavra)
                                    fimJogo = true;
                                else
                                {
                                    chances--;
                                    erros++;
                                    Console.Write("Ops! Menos uma chance... ");
                                    Console.WriteLine("CHANCES: " + chances);

                                    //Boneco da forca sendo desenhado de acordo com o restante das chances
                                    if (chances == 6)
                                    {
                                        Console.WriteLine("\n\n-----|");
                                        Console.WriteLine("|    |");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|========|");
                                    }
                                    else
                                        if (chances == 5)
                                    {
                                        Console.WriteLine("\n\n-----|");
                                        Console.WriteLine("|    |");
                                        Console.WriteLine("|    O");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|========|");
                                    }
                                    else
                                        if (chances == 4)
                                    {
                                        Console.WriteLine("\n\n-----|");
                                        Console.WriteLine("|    |");
                                        Console.WriteLine("|    O");
                                        Console.WriteLine("|  /");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|========|");
                                    }
                                    else
                                        if (chances == 3)
                                    {
                                        Console.WriteLine("\n\n-----|");
                                        Console.WriteLine("|    |");
                                        Console.WriteLine("|    O");
                                        Console.WriteLine("|  / |");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|========|");
                                    }
                                    else
                                        if (chances == 2)
                                    {
                                        Console.WriteLine("\n\n-----|");
                                        Console.WriteLine("|    |");
                                        Console.WriteLine("|    O");
                                        Console.WriteLine("|  / | \\ ");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|");
                                        Console.WriteLine("|========|");
                                    }
                                    else
                                        if (chances == 1)
                                    {
                                        Console.WriteLine("\n\n-----|");
                                        Console.WriteLine("|    |");
                                        Console.WriteLine("|    O");
                                        Console.WriteLine("|  / | \\ ");
                                        Console.WriteLine("|   /");
                                        Console.WriteLine("|");
                                    }
                                }
                                break;

                            //Caso o jogador não queira chutar uma palavra nada é feito
                            case 2:
                                break;

                            default:
                                Console.Write("\nOpção inválida!");
                                break;
                        }
                    }
                }

                //Armazenando a letra digitada que não é repetida
                letrasInseridas = letrasInseridas + letra;

            } while (erros <= 7 && fimJogo == false);

            //Se a variável fimJogo for verdadeira significa que o JOGADOR 2 venceu e é mostrado a mensagem de vitória
            if (fimJogo == true)
                Console.WriteLine("\n\nVOCÊ VENCEU!");

            //Se a variável for falsa o JOGADOR 2 perdeu e é mostrado a mensagem de derrota
            else
            {
                Console.WriteLine("\n\nVOCÊ PERDEU! A palavra era " + palavra);
                Console.WriteLine("\n\n-----|");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|  / | \\ ");
                Console.WriteLine("|   / \\ ");
                Console.WriteLine("|");
                Console.WriteLine("|========|");
            }
            Console.ReadKey();
        }
    }
}
