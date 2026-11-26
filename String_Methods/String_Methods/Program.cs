String fullName = "Sabbir Hossain";
//fullName = fullName.ToUpper();
//fullName = fullName.ToLower();
//Console.WriteLine(fullName);


//String phoneNumber = "0170-000-0000";
//phoneNumber = phoneNumber.Replace("-", "");
//Console.WriteLine(phoneNumber);


//String userName = fullName.Insert(0, "@");
//Console.WriteLine(userName);

/*
String fullName = "Sabbir Hossain";
fullName = fullName.ToLower();
fullName = fullName.Replace(" ", "");
String userName = fullName.Insert(0, "@");
Console.WriteLine(userName);
*/

Console.WriteLine(fullName.Length);

String firstName = fullName.Substring(0, 6);// first index then how many character you want to take
Console.WriteLine(firstName);
String lastName = fullName.Substring(7, 7);
Console.WriteLine(lastName);

Console.ReadKey();
