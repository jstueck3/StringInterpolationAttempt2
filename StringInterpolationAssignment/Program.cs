// See https://aka.ms/new-console-template for more information

//Display the following using string interpolation


//1
string dateOne = $"{DateTime.Now.ToString("January 22, 2019"),40}";
Console.WriteLine(dateOne);

//2
string dateTwo = $"{DateTime.Now.ToString("2019.01.22")}";
Console.WriteLine(dateTwo);


//3
string dateThree = $"Day {DateTime.Now.ToString("22")} of {DateTime.Now.ToString("January, 2019")}";
Console.WriteLine(dateThree);


//4
string dateFour = $"Year: {DateTime.Now.ToString("2019")}, Month: {DateTime.Now.ToString("01")}, Day: {DateTime.Now.ToString("22")}";
Console.WriteLine(dateFour);


//5
string day = $"{DateTime.Now.ToString("Tuesday"),(10)}";
Console.WriteLine(day);




//6
string timeText = $"{DateTime.Now.ToString("11:01 PM"),10}";
string dayText = $"{DateTime.Now.ToString(""),10}";
Console.WriteLine($"{timeText} {dayText}");


//7
string timeTextTwo = $"h:{DateTime.Now.ToString("11")}, m:{DateTime.Now.ToString("01")}, s:{DateTime.Now.ToString("27")}";
Console.WriteLine(timeTextTwo);

//8
string dateTimeText = $"{DateTime.Now.ToString("2019.01.22.11.01.27")}";
Console.WriteLine(dateTimeText);


