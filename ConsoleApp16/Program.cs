using System.Threading.Channels;

namespace ConsoleApp16
{


#nullable enable
    using System;

    namespace ConsoleApp16
    {
        class Book
        {
            public string Title { get; set; } = "";
            public int Pages { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                
                {
                    object book = new Book();
                    Console.WriteLine(book);

                    Console.WriteLine(book.ToString());
                    Console.WriteLine(book.Equals(book));
                    Console.WriteLine(book.GetHashCode());
                    Console.WriteLine(book.GetType());
                }

                {
                    int pages = 464;
                    Console.WriteLine(pages);
                }

                {
                    int zero = 0;
                    try
                    {
                        int result = 10 / zero;
                        Console.WriteLine(result);
                    }
                    catch 
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    finally
                    {
                        Console.WriteLine("Done");
                    }
                }

                {
                    int pages = 300;
                    double doublePages = pages;
                    Console.WriteLine(doublePages);
                }

                {
                    double price = 49.99;
                    int intPrice = (int)price;
                    Console.WriteLine(intPrice);
                }

                {
                    string pagesText = "464";
                    int pages = Convert.ToInt32(pagesText);
                    Console.WriteLine(pages);
                }

                {
                    string yearText = "2023";
                    int year = int.Parse(yearText);
                    Console.WriteLine(year);

                    string badText = "abc";
                    bool isNumber = int.TryParse(badText, out int number);
                    if (isNumber == false)
                    {
                        Console.WriteLine("Invalid number");
                    }
                }

                {
                    int pages = 464;
                    string pagesString = pages.ToString();
                    Console.WriteLine(pagesString.GetType());
                }

                {
                    int copies = 100;
                    object boxedCopies = copies;
                    int unboxedCopies = (int)boxedCopies;
                    Console.WriteLine(boxedCopies);
                    Console.WriteLine(unboxedCopies);
                }

                {
                    int? year = null;
                    Console.WriteLine(year.HasValue);
                    year = 2023;
                    Console.WriteLine(year.Value);
                }

                {
                    string reviewer = null;
                    Console.WriteLine(reviewer == null);
                }

                {
                    Book? book = null;
                    string? title = book?.Title;
                    Console.WriteLine(title);

                    Console.WriteLine(title ?? "Untitled");
                    title ??= "Untitled";
                    Console.WriteLine(title);
                }

                {
                    string? name = "Ahmed";
                    string confirmedName = name!;
                    Console.WriteLine(confirmedName);
                }
            }
        }
    }

}
