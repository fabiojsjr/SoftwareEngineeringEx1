public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage
        Member m1 = new Member("Alex", 22, "VIP");
        Member m2 = new Member("Bella", 19, "Standard");
        Member m3 = new Member("Greg", 29, "Premium");

        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic
        for (int n = 0; n <= 10; n++) 
            m1.BorrowBook();
        for (int n = 0; n <= 3; n++) 
            m2.BorrowBook(); 
        for (int n = 0; n <= 5; n++) 
            m3.BorrowBook();

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine();
        Console.WriteLine($"Name: {m1.name} Age: {m1.Age} Membership: {m1.membershipLevel} Books Borrowed: {m1.GetBooksBorrowed()}");
        Console.WriteLine($"Name: {m2.name} Age: {m2.Age} Membership: {m2.membershipLevel} Books Borrowed: {m2.GetBooksBorrowed()}");
        Console.WriteLine($"Name: {m3.name} Age: {m3.Age} Membership: {m3.membershipLevel} Books Borrowed: {m3.GetBooksBorrowed()}");
        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine();
        Console.WriteLine($"Total Members: {Member.totalMembers} Total Books Borrowed: {Member.TotalBooksBorrowed}");

        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields
        Console.WriteLine();
        for (int n = 10; n >= 0; n--)
            m1.ReturnBook();
        for (int n = 3; n >= 0; n--)
            m2.ReturnBook();
        for (int n = 5; n >= 0; n--)
            m3.ReturnBook();

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine();
        Console.WriteLine($"Name: {m1.name} Age: {m1.Age} Membership: {m1.membershipLevel} Books Borrowed: {m1.GetBooksBorrowed()}");
        Console.WriteLine($"Name: {m2.name} Age: {m2.Age} Membership: {m2.membershipLevel} Books Borrowed: {m2.GetBooksBorrowed()}");
        Console.WriteLine($"Name: {m3.name} Age: {m3.Age} Membership: {m3.membershipLevel} Books Borrowed: {m3.GetBooksBorrowed()}");

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
