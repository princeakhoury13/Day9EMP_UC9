namespace Day9EMPWageUC9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilder infosys = new EmpWageBuilder("Infosys", 22, 3, 18);
            EmpWageBuilder tcs = new EmpWageBuilder("TATA CONSULTANCY SERVICES", 15, 4, 25);

            infosys.computeEmpWage();
            Console.WriteLine(infosys.toString());
            tcs.computeEmpWage();
            Console.WriteLine(tcs.toString());
        }
    }
}