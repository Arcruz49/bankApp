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

}