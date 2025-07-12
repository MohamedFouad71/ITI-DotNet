



using System.Runtime.InteropServices;

namespace EmployeeManagementSystem
{
    class Program
    {
        public static void Main()
        {
            var employees = new Employee[3];

            #region Data Gazzering
            for (int i = 0; i < employees.Length; i++)
            {
                System.Console.Write($"Employee {i + 1} ID : ");
                employees[i].SetID(int.Parse(Console.ReadLine()));

                System.Console.Write($"Employee {i + 1} Name : ");
                employees[i].SetName(System.Console.ReadLine());

                System.Console.Write($"Employee {i + 1} Department : ");
                employees[i].SetDepartment(System.Console.ReadLine());

                System.Console.WriteLine($"Employee {i + 1} Status, Select from above choices : ");
                System.Console.WriteLine("1. Abscent");
                System.Console.WriteLine("2. Present");
                System.Console.WriteLine("3. Onleave");
                System.Console.WriteLine("4. Late");

                switch (System.Console.ReadLine())
                {

                    case "1":
                        employees[i].SetAttendanceStatus(AttendanceStatus.Absent);
                        break;
                    case "2":
                        employees[i].SetAttendanceStatus(AttendanceStatus.Present);
                        break;
                    case "3":
                        employees[i].SetAttendanceStatus(AttendanceStatus.OnLeave);
                        break;
                    case "4":
                        employees[i].SetAttendanceStatus(AttendanceStatus.Late);
                        break;
                    default:
                        System.Console.WriteLine("[Error] Invalid Choice");
                        break;

                }
            }

            #endregion

            #region Printing

            for (int i = 0; i < employees.Length; i++)
            {
                System.Console.WriteLine($"Employee {i + 1} ");
                employees[i].GetInfo();
                System.Console.WriteLine();
            }
                
            #endregion
        }
    }
}