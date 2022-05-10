namespace SwitchCase
{ 
 public class program
{
    public int EmpHour = 0;
    public int WagesPerHour = 20;
    public const int IS_FULL_TIME = 2;
    public const int IS_PART_TIME = 1;

    public int EmployeeWage()
    {
        Random random = new Random();

        int Emp_Check = random.Next(0, 3);       
        switch (Emp_Check)
        {
            case IS_PART_TIME:
                EmpHour = 4;
                break;
            case IS_FULL_TIME:
                EmpHour = 8;
                break;
            default:
                EmpHour = 0;
                break;
        }
        int EmpWage = EmpHour * WagesPerHour;
            return EmpWage;
    }
    public static void Main(string[] args)
    {
        program prg = new program();
        prg.EmployeeWage();
    }
}
}
        
    

