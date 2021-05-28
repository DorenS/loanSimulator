using System;

public class Loan
{
	public Loan()
	{
        double startVal;
        double principal;
        double intrestRate;
        double totInterestAccrued;
        double interestAccumulating;
        //int lateFee;
        //date loanTaken
        //date payDue
        //--date var? how to implement
        //--String date, easy for user input? lots to parse for comparison


        Public loan()
        {
            startVal = 0;
            principal = 0;
            intrestRate = .01;
            totInterestAccrued = 0;
            interestAccumulating = 0;
        }

        Public loan(double amt, double rte/*, latefee, dateTaken, payDate*/)
        {
            startVal = amt;
            principal = amt;
            intrestRate = rte;
            totInterestAccrued = 0;
            interestAccumulating = 0;
        }

        
    }

    //maybe not supposed to be marked public, should be called from principal calculator
    public void updatePrincipal(int temp)
    {

    }

    public String toSTring()
    {
        String str = "Loan starting value: " + startVal + "\n" +
            "Loan interest rate: " + interestRate + "\n" +
            "Loan current value: " + principal + "\n" +
            "amount paid towards loan: " + (startVal - principal + totInterestAccrued);
    }

    /*
    public String toSTringDetailed()
    {
        String str = "Loan starting value: $" + startVal + "\n" +
            "Loan current value: $" + principal + "\n" +
            "amount paid towards loan: $" + (startVal - principal + totInterestAccrued);
    }
    */
    /*
     loans(s): MUST hold an amount owed.
                other features: 
                    when the loan was taken, 
                    original value of loan, 
                    interst rate of loan,
                    interest on loan [current/total]
                    --extra:
                        late fees
     */
}
