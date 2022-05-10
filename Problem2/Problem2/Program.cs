namespace Dailywage
{
    public class program
    {
        public int EmpPresent = 1;
        public int EmpHour = 8;
        public int PartTimeEmpHr = 4;
        public int WagesPerHour = 20;
        public int FullTimeEmp = 1;
        public void CheckEmpPresentAbsent()
        {
            Random Check = new Random();
            int CheckEmp = Check.Next(0, 2);
            if (EmpPresent == CheckEmp)
            {
                Console.WriteLine("Employee is Prsent");
                Random Timecheck = new Random();
                int CheckTimeEmp = Timecheck.Next(0, 2);
                if (FullTimeEmp == CheckTimeEmp)
                {
                    int DailyWagePerHour = EmpHour * WagesPerHour;
                    Console.WriteLine("DailyWages" + DailyWagePerHour);
                }
                  else
                {
                    int DailyWagesPerHour1 = PartTimeEmpHr * WagesPerHour;
                    Console.WriteLine("Dailywages" + DailyWagesPerHour1);
                }
            }

            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public static void Main(string[] args)
        {
            program prg = new program();
            prg.CheckEmpPresentAbsent();
        }
    }
}


