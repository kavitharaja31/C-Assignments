using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public struct Book
{
    public int bid;
    public string btitle;
    public int bprice;
    public enum bType;
    {
        Magazine = 0,
        Novel = 1,
        ReferenceBook = 2,
        Miscellanous = 3
    }

    public void Accept()
    {
        Console.WriteLine("Enter the book id");
        bookid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the book title");
        title =Console.ReadLine();
        Console.WriteLine("Enter the book price");
        price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the code of bookType");
        code = Convert.ToInt32(Console.ReadLine());
    }
    public void display()
    {
        
        Console.WriteLine(" Book Title : {0}", btitle);
        Console.WriteLine("Book Price : {0}", bprice);
        Console.WriteLine("Book ID : {0}", bid);
        Console.WriteLine("Book Type :{0}",(bookType);
      

    }

    static void Main(string[] args)
    {
        Book book1=new Book();
        book1.Accept();
        book1.display();
        Console.ReadKey();
    }
