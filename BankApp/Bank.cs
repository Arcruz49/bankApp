using System;
using System.Collections.Generic;

namespace BancoApp;
class Bank {
    private string name {get;set;}

    private List<ContaBancaria> contas {get;set;}

    public Bank(string name){
        this.name = name;
        this.contas = new List<ContaBancaria>();
    }

    public string getName(){
        return this.name;
    }
}