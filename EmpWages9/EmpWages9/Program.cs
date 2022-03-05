using System;

namespace EmpWages9
{
    class Program
    {
        //Declaring Constant Variable
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //  private static int maxHoursPerMonth;
        public static int computeWage(string company, int wage_per_hour, int max_working_days, int maxHoursPerMonth)
        {
            int empHours = 0;
            int workingDays = 0;
            int workingHrs = 0;


            Random r = new Random();

            while (workingDays <= max_working_days && workingHrs < maxHoursPerMonth)
            {
                workingDays++;
                Random random = new Random();
                int empAttendance = r.Next(0, 3);
                switch (empAttendance)
                {
                    case FULL_TIME:
                        // Console.WriteLine("Employee is present for full-time");
                        empHours = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("Employee is present for part-time");
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        //Console.WriteLine("Employee is absent");
                        break;
                }
                workingHrs += empHours;
                Console.WriteLine("Days" + workingDays + "Emp HOurs" + empHours);
            }
            int totalEmpWage = empHours * wage_per_hour;
            Console.WriteLine("Total emp wage For Company: " + company + "is :" + totalEmpWage);
            Console.WriteLine("Working Hours : " + workingHrs);
            return totalEmpWage;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            computeWage("TVSNEXT", 20, 2, 10);
            computeWage("Wipro", 10, 4, 20);

        }
    }

}