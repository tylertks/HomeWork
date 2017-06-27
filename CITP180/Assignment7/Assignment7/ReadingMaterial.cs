using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace Assignment7
{
    interface IPrintable
    {
        string Available();
    }
    public class ReadingMaterial : IPrintable
    {
        string author;
        string title;
        string publishedDate;
        public ReadingMaterial(string auth, string titl, string date)
        {
            author = auth;
            title = titl;
            publishedDate = date;
        }
    }
    public class Online : ReadingMaterial
    {
        string hostSite;
        public Online(string auth, string titl, string date, string site)
        {
            author = auth;
            title = titl;
            publishedDate = date;
            hostSite = site;
        }
        string IPrintable.Available()
        {
            return "Printable PDF";
        }
    }
    public class Book: ReadingMaterial
    {
        string publisher;
        int chapters;
        public Book(string auth, string titl, string date, string pub, int chap)
        {
            author = auth;
            title = titl;
            publishedDate = date;
            publisher = pub;
            chapters = chap;
        }
        string IPrintable.Available()
        {
            return "Bookstore";
        }
    }
    public class Magazine: ReadingMaterial
    {
        int issue;
        public Magazine(string auth, string titl, string date, int issNum)
        {
            author = auth;
            title = titl;
            publishedDate = date;
            issue = issNum;
        }
        string IPrintable.Available()
        {
            return "Newsstand";
        }
    }
}


