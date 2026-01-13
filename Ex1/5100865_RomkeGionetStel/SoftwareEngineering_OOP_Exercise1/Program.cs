using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        
        Member m1 = new Member("Alice", 25, "Standard");
        Member m2 = new Member("Bob", 30, "Premium");
        Member m3 = new Member("Charlie", 40, "VIP");
        


        // TODO: Call BorrowBook() multiple times for each member
        for(int i = 0; i <= 3; i++)
        {
            m1.BorrowBook();
        }

        for (int i = 0; i <= 5; i++)
        {
            m2.BorrowBook();
        }

        for (int i = 0; i <= 10; i++)
        {
            m3.BorrowBook();
        }

        // TODO: Print out each member's name, age, membership level, and books borrowed
        Console.WriteLine($"Name: {m1.Name}, Age: {m1.Age}, Membership Level: {m1.MembershipLevel}, Books Borrowed: {m1.GetBooksBorrowed()}");
        Console.WriteLine($"Name: {m2.Name}, Age: {m2.Age}, Membership Level: {m2.MembershipLevel}, Books Borrowed: {m2.GetBooksBorrowed()}");
        Console.WriteLine($"Name: {m3.Name}, Age: {m3.Age}, Membership Level: {m3.MembershipLevel}, Books Borrowed: {m3.GetBooksBorrowed()}");


        // TODO: Print TotalMembers and TotalBooksBorrowed
        
        Console.WriteLine($"Total Members: {Member.TotalMember}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");

         
        // TODO: Call ReturnBook() multiple times for all members
        for(int i = m1.GetBooksBorrowed(); i > 0; i--)
        {
            m1.ReturnBook();
        }

        for (int i = m2.GetBooksBorrowed(); i > 0; i--)
        {
            m2.ReturnBook();
        }

        for (int i = m3.GetBooksBorrowed(); i > 0; i--)
        {
            m3.ReturnBook();
        }


        // TODO: Print out each member's name, age, membership level, and books borrowed
        Console.WriteLine($"Name: {m1.Name}, Age: {m1.Age}, Membership Level: {m1.MembershipLevel}, Books Borrowed: {m1.GetBooksBorrowed()}");
        Console.WriteLine($"Name: {m2.Name}, Age: {m2.Age}, Membership Level: {m2.MembershipLevel}, Books Borrowed: {m2.GetBooksBorrowed()}");
        Console.WriteLine($"Name: {m3.Name}, Age: {m3.Age}, Membership Level: {m3.MembershipLevel}, Books Borrowed: {m3.GetBooksBorrowed()}");

        // TODO: Print TotalMembers and TotalBooksBorrowed
        Console.WriteLine($"Total Members: {Member.TotalMember}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");

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
