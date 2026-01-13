public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage
        Member m1 = new Member("Oman Paraguay", 23, "Standard");
        Member m2 = new Member("Armenia Seychelles", 43, "Premium");
        Member m3 = new Member("Suriname Portugal", 36, "VIP");

        var members = new Dictionary<string, int>();
        
        members.Add(m1.Name, m1.Age);
        members.Add(m2.Name, m2.Age);
        members.Add(m3.Name, m3.Age);
        
        
        
        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic
        for (int i = 0; i < m1.GetMaxBorrowLimit() + 1; i++)
        {
            m1.BorrowBook();
        }

        for (int i = 0; i < m2.GetMaxBorrowLimit(); i++)
        {
            m2.BorrowBook();
            Console.WriteLine(m2.GetBooksBorrowed());
        }

        for (int i = 0; i < m3.GetMaxBorrowLimit() + 1; i++)
        {
            m3.BorrowBook();
        }

        Console.WriteLine();

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data

        Console.WriteLine($"Member #1, {m1.Name}, is {m1.Age} years old, is a {m1.membershipLevel} level user. {m1.GetBooksBorrowed()}");
        Console.WriteLine($"Member #2, {m2.Name}, is {m2.Age} years old, is a {m2.membershipLevel} level user. {m2.GetBooksBorrowed()}");
        Console.WriteLine($"Member #3, {m1.Name}, is {m1.Age} years old, is a {m1.membershipLevel} level user. {m1.GetBooksBorrowed()}");

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data


        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data

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
