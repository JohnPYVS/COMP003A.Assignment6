namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This here is to track multiple library books and will let the user update or display
            // one book using a menu loop
            Book book1 = new Book("C++ Software Design", 435 , false);
            Book book2 = new Book("Computer Programming", 201 , true);
            Book book3 = new Book("Programming Python", 1626 , false);

            int choice = 0;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Display all");
                Console.WriteLine("2. Update One Book");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Book 1: ");
                        book1.DisplayInfo();
                        Console.Write("Book 2: ");
                        book2.DisplayInfo();
                        Console.Write("Book 3: ");
                        book3.DisplayInfo();
                        break;

                    case 2:
                        Console.Write("Select book (1-3): ");
                        int which = int.Parse(Console.ReadLine());

                        // This switch is to choose one obeject to update, based on the user's selection 
                        switch (which)
                        {
                            case 1:
                                book1.ToggleCompleted();
                                Console.WriteLine("Updated Book 1.");
                                break;
                            case 2:
                                book2.ToggleCompleted();
                                Console.WriteLine("Updated Book2.");
                                break;
                            case 3:
                                book3.ToggleCompleted();
                                Console.WriteLine("Updated Book 3.");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Program ended.");
                        break;


                }
            } while (choice != 3);
        }
    }

    // This class will model a librabry book that a user is tracking, 
    // including the title, page count, and completion status
    class Book
    {
        public string Title;
        public int Pages;
        public bool Completed;

        // This constructor will create a Book object, which will set all the fields from the parameters
        public Book(string title, int pages, bool completed)
        {
            Title = title;
            Pages = pages;
            Completed = completed;
        }
        // This method is to display the book's field values in a readable format.
        public void DisplayInfo()
        {
            Console.WriteLine("Title=" + Title + ", Pages=" + Pages + ", Completed=" + Completed);
        }
        // This method will update the book by changing whether the user has completed reading it
        public void ToggleCompleted()
        {
            Completed = !Completed;
        }
    }
}
