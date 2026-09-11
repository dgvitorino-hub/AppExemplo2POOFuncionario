using System;
using System.Collections.Generic;
using System.Text;

namespace AppExemplo2POOFuncionario.Model
{
    public class Carro
    {
        public string marca;
        public string modelo;
        public string cor;
        public int numeroMarchas;
        public int anoFabricacao;
        public int anoModelo;
        public bool ligar;
        public bool desligar;
        public int velocidade;

        public void Buzinar()
        {
            Console.WriteLine("BIIIIIIIIIII");
        }
        public string Ligar()
        {
            ligar = true;
            return "O carro foi ligado";
        }
        public string Desligar()
        {
            Ligar = false;
            Desligar = true;
            return "O carro foi desligado";
        }

    public int Acelerar(int velocidade)
        {
            velocidade = velocidade + velocidadeCarro;
            return velocidade;
}
