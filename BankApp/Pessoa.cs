using System;
using System.Collections.Generic;

namespace BancoApp;
abstract class Pessoa {
    public string Nome { get; set; }
    public int Idade { get; set; }

    protected Pessoa(string nome, int idade)
    {
            this.Nome = nome;
            this.Idade = idade;
    }

    public abstract string ExibirDetalhes();

}