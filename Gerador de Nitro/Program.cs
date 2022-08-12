using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Gerador_de_Nitro
{
    internal class Program
    {

        static void Main(string[] args)
        {
            StreamWriter x;
            Random numAleatorio = new Random();
            string CaminhoNome = $"C:\\Users\\{Environment.UserName}\\Desktop\\nitroGerados.txt";
            string alfabetoMaiusculo = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alfabetoMinusculo = "abcdefghijklmnopqrstuvwxyz";
            string link = "http://discord.gift/";
            string gerado = "";
            string completosLink = "";
            int aux = 0, i = 0;

            string menu = "  [1]  :  link de Discord Nitro \n" +
                          "  [2]  :  Fechar gerador";

            Console.WriteLine(menu);
            int opcaoMenu = Int32.Parse(Console.ReadLine());
            x = File.CreateText(CaminhoNome);

            switch (opcaoMenu)
            {
                case 1:
                    while (i <= 1000000)
                    {
                        while (gerado.Count() <= 16)
                        {
                            aux = numAleatorio.Next(1, 100);
                            if (aux % 3 == 0)
                            {
                                aux = numAleatorio.Next(1, 100);
                                gerado = gerado + aux.ToString();
                            }
                            if (aux % 2 == 0)
                            {
                                aux = numAleatorio.Next(1, 26);
                                gerado = gerado + alfabetoMaiusculo[aux];
                            }
                            else
                            {
                                aux = numAleatorio.Next(1, 26);
                                gerado = gerado + alfabetoMinusculo[aux];
                            }
                            if (gerado.Count() <= 16)
                                completosLink = link + gerado;
                        }
                        gerado = "";
                        x.WriteLine(completosLink);
                        i++;
                    }
                    x.Close();
                    Console.WriteLine($"{i} - nitro gerado !");
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }



        }
    }
}
