using System;

namespace homeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            { // ex #2
            Console.Write("Enter first side of rectangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second side of rectangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle Pryamougolnik = new Rectangle(side1, side2);
            Pryamougolnik.PerimeterCulk(side1, side2);
            Pryamougolnik.AreaCulk(side1, side2);
            Console.WriteLine(Pryamougolnik.Perimeter);
            Console.WriteLine(Pryamougolnik.Area);
            }
            { // ex #3
                Book addedBook = new Book();

                Console.Write("Here you can enter book's title: ");
                string addedTitle = Console.ReadLine();
                Console.Write("Here you can write book's Autor: ");
                string addedAuthor = Console.ReadLine();
                Console.Write("Here you can write content of thid book: ");
                string addedContent = Console.ReadLine();
                addedBook.bTitle.booksTitle = addedTitle;
                addedBook.bAuthor.booksAuthor = addedAuthor;
                addedBook.bContent.booksContent = addedContent;
                addedBook.bTitle.Show();
                addedBook.bAuthor.Show();
                addedBook.bContent.Show();
                // не получается нернуть белый цвет в консоле
            }
            {// 
                Academy preview = new Academy();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("Wellcome to Alif Coding Academy! \n I will help you adapt here. \n How many people do you see? \n");
                int numberOfPeople = int.Parse(Console.ReadLine());
                if (numberOfPeople == 1 || numberOfPeople == 2) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    preview.manager();
                } 
                if (numberOfPeople > 2 && numberOfPeople < 20)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    preview.noLesson();
                }
                if (numberOfPeople >= 20)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    preview.lesson();
                }
            }

        }
    }
    class Rectangle 
    {
        double side1, side2, perimeter, area;
        public double Area{get{return area;} }
        public double Perimeter{get{return perimeter;} }
        public Rectangle(double side1,double side2)
        {
            this.side1=side1;
            this.side2=side2;
        }
        public void PerimeterCulk (double side1, double side2) 
        {
            perimeter = (side1 + side2)*2;
        }
        public void AreaCulk (double side1, double side2)
        {
            area = side1*side2;
        }

    }
    class Book
    {
        public Title bTitle = new Title();
        public Author bAuthor = new Author();
        public Content bContent = new Content();
        
    }
    class Title
    {
        public string booksTitle { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Book's title:");
            Console.ForegroundColor = ConsoleColor.DarkBlue; 
            Console.WriteLine(booksTitle);

            
        }
    }
    class Author
    {
        public string booksAuthor { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Author's name:");
            Console.ForegroundColor = ConsoleColor.DarkBlue; 
            Console.WriteLine(booksAuthor);
        }
    }
    class Content 
    {
        public string booksContent { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.WriteLine("Book's content:");
            Console.ForegroundColor = ConsoleColor.DarkBlue; 
            Console.WriteLine(booksContent);                   
        }
    }
    class Academy
    {
        public void lesson ()
        {
            Console.Write("keep silence There is a lesson!");
        }
        public void noLesson ()
        {
             Console.Write("You can do whatever you want! There is no lesson)");
           
        }
        public void manager ()
        {
            Console.Write("Use the Internet only for its intended purpose!!! Do not forget the manifest of the programmer!");
        }
    }

        
}
