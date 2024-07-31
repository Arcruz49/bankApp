using System;
using System.Collections.Generic;

namespace BancoApp;
class Program {
    static void Main(string[] args) {
        
        int key = 0;
        Util util = new Util();
        while(key != -1){
            Console.WriteLine("" + key);
            string input = Console.ReadLine();
            util.start();
        }


    }

}