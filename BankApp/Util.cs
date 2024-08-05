namespace BancoApp;
class Util {
    
    public string start(){
        Console.WriteLine("Digite o nome do banco: ");
        string name = Console.ReadLine();
        return name;
    }

    public string menu(){
        return @"
1 - Ver dados do banco
2 - Adicionar Conta
3 - Listar Contas
4 - Realizar saque
5 - Realizar depósito
0 - Sair
";
        }

    public Retorno verificaNumero(string stringInput){
            
            Retorno retorno = new Retorno();
            
            if (int.TryParse(stringInput, out int numero)){
                if(numero >= 0 || numero <= 5){
                    retorno.sucesso = true;
                    retorno.mensagem = "";
                    return retorno;
                }
                else{
                    retorno.sucesso = false;
                    retorno.mensagem = "Número inválido";
                    return retorno;
                }    

            }
            retorno.sucesso = false;
            retorno.mensagem = "O valor digitado deve ser um número";
            return retorno;
    }

    public Retorno adicionaConta(int tipoPessoa = 0, string nome = "", int idade = 0, string cpf = "", string cnpj = "", double saldo = 0){

        Retorno retorno = new Retorno();
        try{
            if(tipoPessoa == 1){ // pessoa física
                PessoaFisica pessoaFisica = new PessoaFisica(cpf, idade, nome);
                ContaBancaria conta = new ContaBancaria(pessoaFisica, null, saldo);

            }
            
            else if(tipoPessoa == 2){ // pessoa jurídica
                PessoaJuridica pessoaJuridica = new PessoaJuridica(cnpj, idade, nome);
                ContaBancaria conta = new ContaBancaria(null, pessoaJuridica, saldo);
            }

            else{
                retorno.sucesso = false;
                retorno.mensagem = "Tipo de pessoa inválida";
                return retorno;
            }

            retorno.sucesso = true;
            retorno.mensagem = "Conta adicionada com sucesso";
            return retorno;

        }
        catch(Exception ex){
            retorno.sucesso = false;
            retorno.mensagem = "Houve um erro ao criar a conta" + ex.Message;   
            return retorno;      
        }

    }

    
}