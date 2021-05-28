using System;

public class User
{
	public User()
	{
        String myName;
        Loan[] myLoans;

        Public User()
        {
            name = "N/A";
            myLoans = new Loan[0];
        }

        Public User(String name, Loan[] loans)
        {
            name = myName;
            myLoans = new Loan[0];
        }

    }

    public String toString()
    {
        //Console.WriteLine("username: " + myName);
        //
        String userString = "user: " +myName + " ";
        for(int i = 0; i < myLoans.length(); i++)
        {
            userString += myLoans[i].toString;
        }
    }
}
