using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public class CalculateCinemaPrices
    {
        public CalculateCinemaPrices() { }

        public int CinemaPrices()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Cinema!");
            Console.WriteLine("Enter amount of attendees");
            int.TryParse(Console.ReadLine(), out int amountOfAttendees);

            if (amountOfAttendees == 1)
            {
                Console.WriteLine("Age of attendee");
                int.TryParse(Console.ReadLine(), out int attendeeAge);
                int price = CalculatePrice(attendeeAge);
                Console.WriteLine($"{Enum.GetName(typeof(Prices), price)}: {price} SEK");
            }

            else if (amountOfAttendees > 1)
            {
                int[] attendeesAges = new int[amountOfAttendees];
                int companyPrice = 0;

                for (int i = 0; i < attendeesAges.Length; i++)
                {
                    Console.WriteLine($"Age of attendee number: {i+1}");
                    int.TryParse(Console.ReadLine(), out int age);
                    attendeesAges[i] = age;
                    companyPrice += CalculatePrice(age);
                }

                Console.WriteLine($"Company size: {amountOfAttendees}");
                Console.WriteLine($"Total cost for company: {companyPrice}");
            }

            return 0;
        }

        private int CalculatePrice(int age)
        {
            int price;
            if (age < 20)
            {
                price = (int)Prices.Youth;
            }

            else if (age > 64)
            {
                price = (int)Prices.Senior;
            }

            else
            {
                price = (int)Prices.Standard;
            }

            return price;
        }
    }
}
