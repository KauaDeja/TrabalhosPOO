namespace Exercício_1_POO_correção
{
    public class Celular
    {
        /// <summary>
        /// Propriedades criadas
        /// </summary>
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        /// <summary>
        /// Ligar Celular
        /// </summary>
        /// <returns>Ligando Celualr</returns>
        public string Ligar(){
            ligado = true;
            return "ligando celular";
        }

        /// <summary>
        /// Desligar Celular
        /// </summary>
        /// <returns>Desligando Celular</returns>
        public string Desligar(){
            ligado = false;
            return "desligando celular";
        }
     
        /// <summary>
        /// Enviar mensagem
        /// </summary>
        /// <returns>Enviando Mensagem</returns>
        public string EnviarMensagem(){
            return "enviando mensagem";
        }

        public string FazerLigacao(){
            return "Fazendo ligação";
        }

    }
}