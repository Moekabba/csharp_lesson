using AccountingSysProj;

Console.WriteLine("Welcom to the Accountig System 1.0");
CheckingACC mychecking = new CheckingACC(100, 0);
PremAcc myprem = new PremAcc(200, 0);

Console.WriteLine($"checking acount with id {mychecking.ID} has starting balance of {mychecking.Balance}");
Console.WriteLine($"Premium acount with id {myprem.ID} has starting balance of {myprem.Balance}");

mychecking.Deposit(2000);
myprem.Deposit(6000);

Console.WriteLine($"checking acount with id {mychecking.ID} has balance of after deposit {mychecking.Balance}");
Console.WriteLine($"Premium acount with id {myprem.ID} has balance of after deposit {myprem.Balance}");

myprem.Transfer(2000, mychecking);

Console.WriteLine($"checking acount with id {mychecking.ID} has balance of after transfer {mychecking.Balance}");
Console.WriteLine($"Premium acount with id {myprem.ID} has balance of after transfer {myprem.Balance}");

decimal interestChecking = mychecking.CalInterest(3);
decimal interstPrem = myprem.CalInterest(3);

Console.WriteLine($"Checking ACC Interest: ${interestChecking}");
Console.WriteLine($"Premium Acc Interest: ${interstPrem}");

// depositing each interest to the account 
mychecking.Deposit(interestChecking);
myprem.Deposit(interstPrem);

Console.WriteLine($"checking acount with id {mychecking.ID} has balance of after interest {mychecking.Balance}");
Console.WriteLine($"Premium acount with id {myprem.ID} has balance of after interest {myprem.Balance}");

//=================================
