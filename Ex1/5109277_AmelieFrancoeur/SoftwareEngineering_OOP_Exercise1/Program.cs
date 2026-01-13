public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage
        Member num1 = new Member("Ryan", 20, "Standard");
        Member num2 = new Member("Daniel", 28, "Premium");
        Member num3 = new Member("Romke", 19, "VIP");



        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic
        num1.BorrowBook();
        num1.BorrowBook();
        num1.BorrowBook();
        num1.BorrowBook();// Print the reched limit message
        Console.WriteLine();

        num2.BorrowBook();
        num2.BorrowBook();
        num2.BorrowBook();
        num2.BorrowBook();
        num2.BorrowBook();
        num2.BorrowBook();// Print limit message
        Console.WriteLine();

        for (int i =0; i< 11; i++)
        {
            num3.BorrowBook();
        }
        Console.WriteLine();
        


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data

        Console.WriteLine($" Name: {num1.Name}");
        Console.WriteLine($" Age: {num1.Age}");
        Console.WriteLine($" Membership Level: {num1.MemberShipLevel}");
        Console.WriteLine($" Books Borrowed: {num1.GetBooksBorrowed()}");
        Console.WriteLine();

        Console.WriteLine($" Name: {num2.Name}");
        Console.WriteLine($" Age: {num2.Age}");
        Console.WriteLine($" Membership Level: {num2.MemberShipLevel}");
        Console.WriteLine($" Books Borrowed: {num2.GetBooksBorrowed()}");
        Console.WriteLine();

        Console.WriteLine($" Name: {num3.Name}");
        Console.WriteLine($" Age: {num3.Age}");
        Console.WriteLine($" Membership Level: {num3.MemberShipLevel}");
        Console.WriteLine($" Books Borrowed: {num3.GetBooksBorrowed()}");
        Console.WriteLine();


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine("Total Members: " + Member.TotalMembers);
        Console.WriteLine("Total Books Borrowed: " + Member.TotalBooksBorrowed);
        Console.WriteLine();


        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields
        num1.ReturnBook();
        num1.ReturnBook();
        num1.ReturnBook();
        num1.ReturnBook();
        num1.ReturnBook();
        
        Console.WriteLine();

        num2.ReturnBook();
        num2.ReturnBook();
        num2.ReturnBook();
        num2.ReturnBook();
        num2.ReturnBook();
        num2.ReturnBook();
        
        Console.WriteLine();

        for (int i = 0; i < 11; i++)
        {
            num3.ReturnBook();
        }
        Console.WriteLine();


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($" Name: {num1.Name}");
        Console.WriteLine($" Age: {num1.Age}");
        Console.WriteLine($" Membership Level: {num1.MemberShipLevel}");
        Console.WriteLine($" Books Borrowed: {num1.GetBooksBorrowed()}");
        Console.WriteLine();

        Console.WriteLine($" Name: {num2.Name}");
        Console.WriteLine($" Age: {num2.Age}");
        Console.WriteLine($" Membership Level: {num2.MemberShipLevel}");
        Console.WriteLine($" Books Borrowed: {num2.GetBooksBorrowed()}");
        Console.WriteLine();

        Console.WriteLine($" Name: {num3.Name}");
        Console.WriteLine($" Age: {num3.Age}");
        Console.WriteLine($" Membership Level: {num3.MemberShipLevel}");
        Console.WriteLine($" Books Borrowed: {num3.GetBooksBorrowed()}");
        Console.WriteLine();


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine("Total Members: " + Member.TotalMembers);
        Console.WriteLine("Total Books Borrowed: " + Member.TotalBooksBorrowed);
        Console.WriteLine();

        /*
            Instructions for Expected Output:

            If you create the following members:
            - Alice, Age: 25, Membership Level: Standard
            - Bob, Age: 30, Membership Level: Premium
            - Charlie, Age: 40, Membership Level: VIP

            Then the program should produce the following output when borrowing and returning books:

            Alice has reached their borrowing limit.
            Bob has reached their borrowing limit.
            Charlie has reached their borrowing limit.
            Alice, Age: 25, Level: Standard, Books Borrowed: 3
            Bob, Age: 30, Level: Premium, Books Borrowed: 5
            Charlie, Age: 40, Level: VIP, Books Borrowed: 10
            Total Members: 3
            Total Books Borrowed: 18
            Alice has returned all their books.
            Bob has returned all their books.
            Charlie has returned all their books.
            Alice, Age: 25, Level: Standard, Books Borrowed: 0
            Bob, Age: 30, Level: Premium, Books Borrowed: 0
            Charlie, Age: 40, Level: VIP, Books Borrowed: 0
            Total Members: 3
            Total Books Borrowed: 0
        */
    }
}
