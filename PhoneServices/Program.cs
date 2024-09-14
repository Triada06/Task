using PhoneServices;

MobileService phone =  new MobileService();

while (true)
{
    Console.WriteLine(@"
        0.Exit
        1.Add phone number
        2.Delete phone number
        3.Update phone number
        4.Show list of people
        5.Search
");

    string line  = Console.ReadLine();

    if(int.TryParse(line, out int num ))
    {
        if(num == 0)
        {
            Console.WriteLine("Process is done");
            break;
        }

        switch (num)
        {
            case 1:
                phone.AddNumber();
                break;
            case 2:
                phone.RemoveNumber();
                break;
            case 3:
                phone.Update();
                break;
            case 4:
                phone.ShowList();
                break;
            case 5:
                phone.Search(); 
                break;
        }
    }
}


