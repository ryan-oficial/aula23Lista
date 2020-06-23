using System;
using System.Collections.Generic;

namespace Aula23Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Produto celular1 = new Produto();
            celular1.Codigo = 1;
            celular1.Nome = "Iphone X";
            celular1.Preco = 4000.99f;

            produtos.Add(celular1);

            produtos.Add( new Produto(2, "Galaxy", 2500.98f) );
            produtos.Add( new Produto(3, "Xiaomi", 2500.98f));
            produtos.Add( new Produto(4, "Asus", 2500.98f));
            produtos.Add( new Produto(5, "Lenovo", 2500.98f));
            produtos.Add( new Produto(6, "Asus", 2500.98f));

            foreach(Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.Green;              
                Console.WriteLine($"R$ {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }

            produtos.Remove(celular1);

            produtos.RemoveAt(1);

            produtos.RemoveAll( p => p.Nome == "Asus");

            foreach(Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.Red;             
                Console.WriteLine($"R$ {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }

            Produto lenovo = produtos.Find(x => x.Nome == "Lenovo");
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( lenovo.Preco );
            Console.ResetColor();

            System.Console.WriteLine("--------------------------------");

            List<Cartao> cartoes = new List<Cartao>();

            Cartao Visa = new Cartao();
            Visa.Titular = "Ryan";
            Visa.Numero = 123456f;
            Visa.Bandeira = "Visa";
            Visa.Vencimento = 10102020;
            Visa.CVV = 13;

            cartoes.Add(Visa);
            
            cartoes.Add( new Cartao("Ryan", 158139, "Cielo", 10102025, 15));
            cartoes.Add( new Cartao("Ryan", 412379, "Mastercard", 10102022, 15));
            cartoes.Add( new Cartao("Ryan", 013495, "HyperCard", 10102027, 15));
            cartoes.Add( new Cartao("Ryan", 941305, "Elo", 10102028, 15));

            foreach(Cartao c in cartoes){
                Console.ForegroundColor = ConsoleColor.Magenta;              
                Console.WriteLine($"Ryan - {c.Bandeira}");
                Console.ResetColor();
            }



        }
    }
}
