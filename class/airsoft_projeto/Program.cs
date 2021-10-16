using System;

namespace airsoft_projeto
{   
    class Jogador
    {
        public string nome_jogador;
        private string email_jogador;
        public string modal_jogador;
        private char resp_jogador;
        private int id_jogador;


        public cadJogador(String nome_jogador, string email_jogador, string modal_jogador, char resp_jogador)
        {
            
            Console.WriteLine("Deseja cadastrar jogador? (s/n)");
            this.resp_jogador = Console.ReadLine();

            while ((!this.resp_jogador.Equals("n")) || (!this.resp_jogador.Equals("N")) {
                this.id_jogador += 1;
            }
            
        }
    }
    
    class Evento
    {
        Local local;
        Jogador jogador;

    }

     

   public class Local
    {
            string rua;
            string bairro;
            int numero;
            string? complemento;
            string cidade;
            string estado;
            int uf;

        public string cad_local(Local)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
