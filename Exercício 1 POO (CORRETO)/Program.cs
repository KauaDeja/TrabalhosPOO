using System;

namespace Exercício_1_POO_correção
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular lg = new Celular();
            lg.cor = "preto";
            lg.modelo = "lgk10";
            lg.tamanho = "pequeno";
            lg.ligado = true;

            Console.WriteLine("Deseja ligar o celular?");
            lg.ligado = Boolean.Parse(Console.ReadLine() );

            if(lg.ligado){
                while(lg.ligado){

                    Console.WriteLine("O que deseja fazer?/n 1-Desligar o celular/n 2-Enviar Mensagem/n 3- Fazer  ligação");
                    int resposta = Int32.Parse(Console.ReadLine() );

                    switch(resposta){
                        case 1:
                        Console.WriteLine(lg.Desligar());
                        break;

                        case 2:
                        Console.WriteLine(lg.EnviarMensagem());
                        break;

                        case 3:
                        Console.WriteLine(lg.FazerLigacao());
                        break;

                        default:
                        Console.WriteLine(lg.Ligar());
                        break;

                    }
                    } 

                }else{
                        Console.WriteLine("O celular está desligado");
            }

    
        }

    }
}
