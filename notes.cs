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
                need date comparator ^
                !!need to cumulate interest monthly - ability to determine when new month starts

            payment method requirements:
                HIR: can set int to track array index containing CurrHIR and eval when new loan created
                    {if dynamic rates, whenever rates change, flag to comp against currHIR}
                    --theoretically prevents fast build up of interest that eats up payment and keeps it from being applied to principal
                LIR: can set int to track array index containing CurrLIR and eval when new loan created
                    {if dynamic rates, whenever rates change, flag to comp against currLIR}
                    --theoretically applies greatest amount towards principal, eliminates loans faster to reduce burden
                XXX     HP:  to ensure HP always accurate, would have to iterate through all loans (that changed principal, rare that this wouldnt be total num loans)
                XXX     HP: set HP value. when loan principal changes check against HP value. if loan == HP loan, update HP. else if loanPrinciple > HP, 
                    --theoretically prevents fast build up of interest that eats up payment and keeps it from being applied to principal

                    !! running into efficiency and redundancy issues
                        course of action if multiple loans have == principal?
                            choose loan w/ HIR between ties
                        what order/when to evaluate currHP
                            need to ensure all loans have upto date principal before checking for HP
                                flag if a loans principal changes, check if payment being made (HPloan only needs to be know when paying HP), 
                                check if any loans have changes pending (only applies if monthly accrual(s) of interest would be applied)

               HP/LP: when making payment, check if any loans have changes pending/changed principal. run updates and check vals against HP?LP
                (redundancy if HP/LP loan remarked as HP/LP after its update is minimal inefficiency)
                    --theoretically reigns in interst build up by preventing HP for it to capitalize on
                    --theoretically allows quick elimination of loans to ease burden
                            
               ED: takes payment / num loans (should verify ans has no more than 2 decimal places)

               TP: payment applied to USER indicated index.

     */
}
