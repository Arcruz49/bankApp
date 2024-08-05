using System;
using System.Collections.Generic;

namespace BancoApp;
class Program {
    static void Main(string[] args) {
        
        int input = -1;
        Util util = new Util();
        string name = util.start();
        Bank banco = new Bank(name);

        string? stringInput = "";

        while(input != 0){
            
            Console.WriteLine(util.menu());
            stringInput = Console.ReadLine();
            if(util.verificaNumero(stringInput).sucesso){
                input = Convert.ToInt32(stringInput);
                Console.Clear();
                switch(input){
                    case 0:
                        break;
                    
                    case 1:
                        Console.WriteLine(banco.getDetalhes());
                        break;
                    
                    case 2:
                        Console.WriteLine();
                        break;
                    
                }


            }
        


        }


    }

}