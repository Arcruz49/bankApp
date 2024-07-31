using System;
using System.Collections.Generic;

namespace BancoApp;
class PessoaJuridica : Pessoa {
    private string cnpj {get; set;}

    protected PessoaJuridica(string nome, int idade, string cnpj) : base(nome, idade){
        this.cnpj = cnpj;
    }

    public override string ExibirDetalhes(){
        return "";
    }
}