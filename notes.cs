using System;

namespace ConsoleApp1
{
    /*
        notes for loan simulator
        
        project will:
            determine the amount a USER has in loan(s), allow USER to pay loans and interest on thise loans.
        
        project specifications:
            USER: only requires one user
                other features:
                    display total owed
                    display owed for each loan
            loans(s): MUST hold an amount owed.
                other features: 
                    when the loan was taken, 
                    original value of loan, 
                    interst rate of loan,
                    interest on loan [current/total]
                    --extra:
                        late fees
            payment: MUST subtract value from loan. MUST consider interest
                other features:
                    payment methods:
                        highest principal,
                        highest interest rate,
                        lowest principal,
                        lowest interest rate,
                        even distribution,
                        targeted distribution.
                external considerations:
                    last payment amount
                    last payment date
        

        requrirements:
            loan array: keeps track of what loans the USER has. object array is functional; 
                vs stack, array has object permanence/able to move through objects w/o worrying about creation/deletion
                vs list, more mobility, loans dont interact, no need to use one to get to another
                vs tree, ^

            user () >> user to string ives user name, iterates through loan array toprint each loans val and calc total owed.

            ability to calculate days between curr day and last payment/when loan was taken
                need date comparator





     */
}
