public class Member
{
    // ============================
    // 1. Public Auto-property for Name
    // TODO: Implement a public property to store the member's name
   
    
    public string Name { get; set; }


    // ============================
    // 2. Full property for Age with simple logic
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            // TODO: Implement logic to prevent negative ages
            if (value < 0) // if the input is negative, output 0| else set output = input
                age = 0;
            else
                age = value;
        }
    }

    // ============================
    // 3. Static auto-property for TotalMembers
    // TODO: Implement a public static auto-property to track total members

    public static int TotalMember { get; set; }


    // ============================
    // 4. Static full property with logic for TotalBooksBorrowed
    private static int totalBooksBorrowed;
    public static int TotalBooksBorrowed
    {
        get { return totalBooksBorrowed; }
        set
        {
            // TODO: Implement logic to prevent negative total books borrowed
            if (value < 0)
                totalBooksBorrowed = 0;
            else
                totalBooksBorrowed = value;
        }
    }

    // ============================
    // 5. MembershipLevel auto-property with private setter
    // TODO: Implement a public property for MembershipLevel with a private setter
    public string MembershipLevel { get; private set; }
    
    // ============================
    // 6. Private instance attribute booksBorrowed
    // TODO: Create a private field to track the number of books a member has borrowed
    private int booksBorrowed;

    // ============================
    // 7. Private static attributes for max borrow limits
    // TODO: Create private static fields to define the maximum number of books that can be borrowed
    private static int StandardLimit = 3;
    private static int PremiumLimit = 5;
    private static int VIPLimit = 10;
    

    // ============================
    // Constructor
    public Member(string name, int age, string level)
    {
        // TODO: Initialize Name, Age, and MembershipLevel
        Name = name;
        Age = age;
        MembershipLevel = level;

        booksBorrowed = 0;
        TotalMember++;
    }

    // ============================
    // Private method to get max borrow limit for this member
    // TODO: Implement a private method to return the max number of books allowed
    private int GetMaxBorrowLimit()
    {
        switch (MembershipLevel)
        {
            case "Standard":
                return StandardLimit;
            case "Premium":
                return PremiumLimit;
            case "VIP":
                return VIPLimit;
            default:
                return 0;
        } 
        
    }

    // ============================
    // Borrow book method
    // TODO: Implement BorrowBook()
    public void BorrowBook()
    {
        if (booksBorrowed < GetMaxBorrowLimit())
        {
            booksBorrowed++;
            TotalBooksBorrowed++; 
        }
        else
        { 
            Console.WriteLine($"{Name} has reached their borrowing limit.");
        }
    }  

    // ============================
    // Return book method
    // TODO: Implement ReturnBook()
    public void ReturnBook()
    {
        

        if (booksBorrowed != 0)
        {
            booksBorrowed--;
            TotalBooksBorrowed--;

            if (booksBorrowed == 0)
                Console.WriteLine($"{Name} has returned all their books.");
        }
        else
        {
            Console.WriteLine($"{Name} has no books to return");
        }
    }

    // ============================
    // Getter for private booksBorrowed
    // TODO: Implement a public method to return the number of books borrowed
    public int GetBooksBorrowed()
    {
        return booksBorrowed;
    }
}