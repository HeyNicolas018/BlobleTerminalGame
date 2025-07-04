using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlobleTerminal

{
    class Menu
    {
        public static void Main()
        {
            string keyBind;
            do
            {
                
                
                //Botão Jogar
                Console.WriteLine("     ██╗ ██████╗  ██████╗  █████╗ ██████╗ \r\n     ██║██╔═══██╗██╔════╝ ██╔══██╗██╔══██╗\r\n     ██║██║   ██║██║  ███╗███████║██████╔╝\r\n██   ██║██║   ██║██║   ██║██╔══██║██╔══██╗\r\n╚█████╔╝╚██████╔╝╚██████╔╝██║  ██║██║  ██║\r\n ╚════╝  ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝\r\n                                          ");

                //Botão de Selecionar Cor
                Console.WriteLine("███████╗███████╗██╗     ███████╗ ██████╗████████╗     ██████╗ ██████╗ ██╗      ██████╗ ██████╗ \r\n██╔════╝██╔════╝██║     ██╔════╝██╔════╝╚══██╔══╝    ██╔════╝██╔═══██╗██║     ██╔═══██╗██╔══██╗\r\n███████╗█████╗  ██║     █████╗  ██║        ██║       ██║     ██║   ██║██║     ██║   ██║██████╔╝\r\n╚════██║██╔══╝  ██║     ██╔══╝  ██║        ██║       ██║     ██║   ██║██║     ██║   ██║██╔══██╗\r\n███████║███████╗███████╗███████╗╚██████╗   ██║       ╚██████╗╚██████╔╝███████╗╚██████╔╝██║  ██║\r\n╚══════╝╚══════╝╚══════╝╚══════╝ ╚═════╝   ╚═╝        ╚═════╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚═╝  ╚═╝\r\n                                                                                               ");

                //Botão Sair
                Console.WriteLine("███████╗ █████╗ ██╗██████╗ \r\n██╔════╝██╔══██╗██║██╔══██╗\r\n███████╗███████║██║██████╔╝\r\n╚════██║██╔══██║██║██╔══██╗\r\n███████║██║  ██║██║██║  ██║\r\n╚══════╝╚═╝  ╚═╝╚═╝╚═╝  ╚═╝\r\n                           ");
                

                keyBind = Console.ReadLine();
                switch (keyBind)
                {
                    case "1":
                        Jogando();
                        break;
                }
            } while (keyBind != "x");
        }


        public static void Jogando()
            {
            Console.Clear();
            Console.WriteLine("A");
            Console.ReadLine();
        }
    }
}



