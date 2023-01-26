internal class Health
    {
        private int temperature;
        public int Temp
        {
            get
            {
                return temperature;
            }
            set
            {
               if (value < 35 || value == 35)
                {
                    Console.WriteLine("Ваша температура слишком низкая!");
                }
               else if(value == 36)
                {
                    Console.WriteLine("Ваша температура в норме!");
                }
               else if (value >36||value>41)
                {
                    Console.WriteLine("Ваша температура слишком высокая!");
                }

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Health health = new Health();
            do
            {
                Console.WriteLine("Введите вашу температуру, пожалуйста: ");               
                health.Temp = Convert.ToInt32(Console.ReadLine());               
                Console.WriteLine("\nДля повторного запроса нажмите Enter\nДля выхода из программы нажмите ESC");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);          
        }
    }
