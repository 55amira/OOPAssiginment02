using OOPAssiginment02.Binding;

namespace OOPAssiginment02
{
    internal class Program
    {
        //static void EmployeeProcess(FullTimeEmployee employee)
        //{
        //    employee.Fun01();
        //    employee.Fun02();
        //}

        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    employee.Fun01();
        //    employee.Fun02();
        //}



        static void EmployeeProcess(Employee employee)
        {
            employee.Fun01();
            employee.Fun02();
        }

        //static int Sum(int X, int Y)
        //{
        //    return X + Y;
        //}

        //static int Sum(int X, int Y, int Z)
        //{
        //    return X + Y + Z;
        //}

        //static double Sum(double X, double Y)
        //{
        //    return X + Y;
        //}

        //static double Sum(int X, double Y)
        //{
        //    return X + Y;
        //}

        //static double Sum(double X, int Y)
        //{
        //    return X + Y;
        //}
        static void Main(string[] args)
        {
            //inheritance

            // Parent parent = new Parent(1, 2);
            // Console.WriteLine(parent);

            // parent.Fun01();
            //parent.Fun02();

            // Child child=new Child(1,2,3);
            //// Console.WriteLine(child);
            // child.Fun01();
            // child.Fun02();

            //Sum(1, 2);
            //Sum(1.3, 4.3);

            // TypeB typeB = new TypeB() { A = 12, B = 13 };
            //typeB.A = 12;
            //typeB.B = 13;

            // Console.WriteLine("Press any key to exit...");
            // Console.ReadKey();

            //typeB.Fun01();
            //typeB.Fun02();

            //TypeA Ref;
            //Ref = new TypeA();
            //Ref = new TypeB();

            // Ref.A = 12;
            //  Ref.B = 13;
            // 
            // Ref.Fun01();
            // Ref.Fun02();
            //
            FullTimeEmployee fullTime = new FullTimeEmployee()
            {
                id = 1,
                name = "ahmed",
                email = "ah@.com",
                salary = 12000,
                address = ",cmvnb"
            };

            PartTimeEmployee partTime = new PartTimeEmployee()
            {
                id = 1,
                name = "ahmed",
                email = "ah@.com",
                HoureRate = 300,
                NumberOfHoure = 200,
                address = ",cmvnb"

            };

            //EmployeeProcess(fullTime);
            //EmployeeProcess(partTime);
        }
    }
}
