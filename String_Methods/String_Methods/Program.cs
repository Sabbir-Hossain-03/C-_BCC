//String fullName = "Sabbir Hossain";

//fullName = fullName.ToUpper();

//fullName = fullName.ToLower();

//Console.WriteLine(fullName);


//String phoneNumber = "0170-000-0000";
//phoneNumber = phoneNumber.Replace("-", "");
//Console.WriteLine(phoneNumber);


//String userName = fullName.Insert(0, "@");
//Console.WriteLine(userName);

String fullName = "Sabbir Hossain";
fullName = fullName.ToLower();
fullName = fullName.Replace(" ", "");
String userName = fullName.Insert(0, "@");
Console.WriteLine(userName);

Console.ReadKey();
