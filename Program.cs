// using System;
// namespace BitsectTest {
//     class Program {
//         static void Main(string[] args){
//             Console.WriteLine("Ngo Thanh Dat");
//         }
//     }
// }
using System;
namespace BisectTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine("Integer division of 23/4 is{$}",
            calculator.Divide(23, 4));

            Console.WriteLine("Modulus 23%4 is{$}",
            calculator.Multiply(23, 4));
            Console.WriteLine("Real substract of 23/4 is{$}",
            calculator.Subtract(23.0, 4.0));

            var book = new Book();
            book.Author = "Jesse Liberty";
            book.BookName = "Pro Git for Programmers";
            book.WholeSalePrice = 10.0;
            book.ComputePrice();
            Console.WriteLine( book.BookName," by{$}", book.Author );
            Console.WriteLine($"{book.BookName}: {book.Price}");
            Console.WriteLine("Discount price is {$}",book.DiscountPrice);
            Console.WriteLine("Discontinued price is{$}",book.DiscontinuedPrice);
        }
    }
}

