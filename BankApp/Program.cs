using System;
using System.Collections.Generic;

namespace BancoApp;
class Program {
    static void Main(string[] args) {
        
        int input = -1;
        Util util = new Util();
        string name = util.start();
        Bank banco = new Bank(name);

        Console.WriteLine(util.menu());

        while(input != 0){
            


        }


    }

}