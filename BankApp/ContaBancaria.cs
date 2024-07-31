
using System;

using System.Collections.Generic;

namespace BancoApp;

class ContaBancaria{
    private PessoaFisica? responsavelPF {get; set;}

    private PessoaFisica? responsavelPJ {get; set;}

    private double saldo {get; set;}

    public ContaBancaria(PessoaFisica? responsavelPF, PessoaFisica? responsavelPJ, double saldo = 0){
        try{

            if(responsavelPF == null && responsavelPJ == null){
                throw new Exception("A conta deve possuir um responsável");
            }

            this.responsavelPF = responsavelPF;
            this.responsavelPJ = responsavelPJ;
            this.saldo = saldo;

        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        
    }

    public Retorno saque(double valor){
        Retorno ret = new Retorno();
        try{
            if(this.saldo < valor){
                ret.sucesso = false;
                ret.mensagem = "Saldo insuficiente";
                return ret;
            }
            
            this.saldo -= valor;
            ret.sucesso = true;
            ret.mensagem = "";
            return ret;

        }
        catch(Exception ex){
            ret.sucesso = false;
            ret.mensagem = ex.ToString();
            return ret;
        }
    }

    public Retorno deposito(double valor){
        Retorno ret = new Retorno();
        try{

            this.saldo += valor;
            ret.sucesso = true;
            ret.mensagem ="";
            return ret;
        
        }
        catch(Exception ex){
        
            ret.sucesso = false;
            ret.mensagem = ex.ToString();
            return ret;
        
        }
    }

}