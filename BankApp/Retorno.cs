
namespace BancoApp;
class Retorno {
    public bool sucesso {get; set;}
    public string mensagem {get; set;}

    public Retorno(){
        this.sucesso = false;
        this.mensagem = "";
    }

}