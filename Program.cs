using System.Reflection.Metadata.Ecma335;
using static System.Net.WebRequestMethods;

namespace Basics_Session04;
class program
{
    static void Main()
    {
        //#region part 1
        //double [] Price = { 25.5, 40.0, 33.75 };
        //Console.WriteLine($"Second price: {Price[1]}");
        //#endregion

        //#region part 2
        //int[,] shelfCopies =
        //{
        //    { 3, 5 },
        //    {  1, 4 }
        //};
        //Console.WriteLine($"number of copies on shelf 1, slot 0: {shelfCopies[1,0]}");
        //#endregion

        //#region part 3
        //PrintWelcomeMessage();
        //#endregion

        //#region part 4
        //PrintBookTitle("Clean Code");
        //#endregion

        //#region part 5
        //int pages = 400;
        //AddBonusPages(pages);
        //Console.WriteLine($"Pages: {pages}");
        //// pages remain unaffected, because the method was called by value, so it took of a copy of the variable
        //#endregion

        //#region part 6
        //double[] prices = { 25.5, 40.0 };
        //ApplyDiscount(prices);
        //Console.WriteLine($"First price: {prices[0]}");
        //// pages affected, because the method was called by reference, so it took of the refrence of the variable itself
        //#endregion

        //#region part 7
        //int pages = 400;
        //AddBonusPagesByRef(ref pages);
        //Console.WriteLine($"Pages {pages}");
        ////pages affected, because the method was called by reference, so it took of the refrence of the variable itself
        //#endregion

        //#region part 8
        //double[] prices = { 10.0 };
        //ReplaceArray(ref prices);
        //Console.WriteLine(prices.Length);
        //#endregion

        //#region part 9
        //bool valid=TryGetPrice("Clean Code", out double price);
        //string Result= valid ? price.ToString():"Not Found";
        //Console.WriteLine($"Price: {Result}");
        //#endregion

        //#region part 10
        //PrintBookInfo("Clean Code");
        //PrintBookInfo("Clean Code", 500);
        //#endregion

        //#region part 11
        //PrintBookInfo(pages:500,title:"Clean Code");
        //#endregion

        //#region part 12
        //PrintAllTitles("Clean Code", "C++ Basics", "OOP for beginers");
        //#endregion
    }
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
    }
    static void PrintBookTitle(string title)
    {
        Console.WriteLine("Book title: " + title);
    }
    static void AddBonusPages(int pages)
    {
        pages += 50;
    }
    static void ApplyDiscount(double[] prices)
    {
        prices[0] -= 5;
    }
    static void AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
    }
    static void ReplaceArray(ref double[] prices)
    {
        prices =new double[]{ 10.0, 12.5, 15.0 } ;
    }
    static bool TryGetPrice(string title, out double price)
    {
        if(title == "Clean Code") { price = 25.5; return true; }
        price = 0; return false;
    }
    static void PrintBookInfo(string title, int pages = 300)
    {
        Console.WriteLine($"Title: {title}, Pages: {pages}");
    }
    static void PrintAllTitles(params string[] titles)
    {
        foreach(var i in titles)
        {
            Console.WriteLine(i);
        }
    }
}