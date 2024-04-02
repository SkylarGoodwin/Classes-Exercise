namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           var myCar = new Car();
            myCar.Year = 2000;
            myCar.Make = "Honda";
            myCar.Model = "accord";
            Console.WriteLine(myCar.Year);
            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
        }
    }
}
