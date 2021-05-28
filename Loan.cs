using System;

public class Loan
{
	public Loan()
	{
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
            principal = 0;
            intrestRate = .01;
            totInterestAccrued = 0;
            interestAccumulating = 0;
        }

        Public loan(double amt, double rte/*, latefee, dateTaken, payDate*/)
        {
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
