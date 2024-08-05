using System;
using System.Collections.Generic;

namespace BancoApp;
class PessoaFisica : Pessoa {
    private string cpf {get; set;}

    public PessoaFisica(string nome, int idade, string cpf) : base(nome, idade){
        this.cpf = cpf;
    }

    public override string ExibirDetalhes(){
        return "";
    }
}