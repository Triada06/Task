using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneServices
{
    internal class MobileService
        
    {
        Person person11 = new Person();
       List<Person> people = new List<Person>();

        public void AddNumber()
        {
            Console.WriteLine("Please, enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please, enter surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Please, enter the phone number: ");
            string phoneNumber = Console.ReadLine();

            Person person = new Person()
            {
                Name = name,
                Surname = surname,
                MobilePhone = phoneNumber
            };

            people.Add(person);
        }



        public void RemoveNumber()
        {
            restart: Console.WriteLine("Enter name and surname: ");

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter surname: ");
            string surname = Console.ReadLine();


            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Surname.Trim().ToLower() == surname.Trim().ToLower() && people[i].Name.Trim().ToLower() == name.Trim().ToLower())
                {
                    Console.WriteLine("Are u sure u wanna delete the number? (y/n)");
                    retry: string approve = Console.ReadLine();

                    if (approve == "y")
                    {
                        people.Remove(people[i]);
                        Console.WriteLine("Person has been deleted! ");
                        return;

                    }

                    if(approve == "n") return;

                    else 
                    {
                        Console.WriteLine("Please, select one of the aviable options (y/n) ");
                        goto retry;
                    }
                }


                Console.WriteLine("No data has been found");

                tryagain: Console.WriteLine("To complete the removal select option 1");

                Console.WriteLine("To try again select option 2");

                string option = Console.ReadLine();

                int num = 0;

                bool finish = int.TryParse(option, out num);

                if (finish)
                {
                    switch (num)
                    {
                        case 1:
                            return;
                        case 2:
                            goto restart;

                        default:
                            Console.WriteLine("Please, select one of the possible actions");
                            goto tryagain;
                    }
                }
                else
                {
                    Console.WriteLine("Please, enter 1 or 2");
                    goto tryagain;
                }
            }

        }



        public void Update()
        {
            restart: Console.WriteLine("Please, enter name or surname");
            string line = Console.ReadLine();

            foreach (Person person in people)
            {
                if(person.Name == line || person.Surname == line)
                {
                    Console.WriteLine("Enter new number: ");
                    string newNumber = Console.ReadLine();

                    person.MobilePhone = newNumber;
                    return;
                }
                
            }
            Console.WriteLine("No data has been found");

            tryagain: Console.WriteLine("To complete select option 1");

            Console.WriteLine("To try again select option 2");

            string option = Console.ReadLine();

            int num = 0;

            bool finish = int.TryParse(option, out num);

            if (finish)
            {
                switch (num)
                {
                    case 1:
                        return;
                    case 2:
                        goto restart;

                    default:
                        Console.WriteLine("Please, select one of the possible actions");
                        goto tryagain;
                }
            }
            else
            {
                Console.WriteLine("Please, enter 1 or 2");
                goto tryagain;
            }

        }

       

        public void ShowList()
        {
            GOTO: Console.WriteLine("Enter how you would like to sort: (A-Z) (1) or (Z-A) (2)");

            string line = Console.ReadLine();

            if(int.TryParse(line, out int num))
            {
                switch (num)
                {
                    case 1:
                        people.Sort((x, y) => x.Surname.CompareTo(y.Surname));

                        foreach (var item in people)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.MobilePhone}");
                        }
                        return;

                    case 2:
                        people.Sort((x, y) => y.Surname.CompareTo(x.Surname));
                        foreach (var item in people)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.MobilePhone}");
                        }
                        return;

                }
            }
            else
            {
                Console.WriteLine("Select valid option: ");
                goto GOTO;
            }

            

            
        }


        public void Search()
        {
            Console.WriteLine("To search by name or surname choose 1");
            Console.WriteLine("To search by phone number choose 2");

            tryagain: string option = Console.ReadLine();

            int num = 0;

            bool finish = int.TryParse(option, out num);

            if (finish)
            {
                switch (num)
                {
                    case 1:

                        Console.WriteLine("Enter name or surname: ");

                        string text = Console.ReadLine();

                        var data = people.Where(x => x.Name.ToLower().Trim().Contains(text) == text.ToLower().Trim().Contains(text));

                        foreach (var item in data)
                        {
                            Console.WriteLine(item.Name + " " +  item.Surname + " " + item.MobilePhone);
                        }

                        return;
                    case 2:

                        Console.WriteLine("Enter phone number: ");

                        string phone = Console.ReadLine();

                        var data1 = people.Where(x => x.MobilePhone.ToLower().Contains(phone) == phone.ToLower().Contains(phone));

                        foreach (var item in data1)
                        {
                            Console.WriteLine(item.Name + " " + item.Surname + " " + item.MobilePhone);
                        }
                        return;

                    default:
                        Console.WriteLine("Please, select one of the possible actions");
                        goto tryagain;
                }
            }
            else
            {
                Console.WriteLine("Please, enter 1 or 2");
                goto tryagain;
            }

        }
    }
}
