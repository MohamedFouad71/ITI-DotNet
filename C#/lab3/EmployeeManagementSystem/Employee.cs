


namespace EmployeeManagementSystem
{
    struct Employee
    {
        int _id;
        string _name;
        string _department;
        AttendanceStatus _attendanceStatus;

        public void SetName(string name) { _name = name; }
        public void SetID(int ID) { _id = ID; }
        public void SetDepartment(string department) { _department = department; }
        public void SetAttendanceStatus(AttendanceStatus status) { _attendanceStatus = status; }

        public int GetId() { return _id; }
        public string GetDepartment() { return _department; }
        public string GetName() { return _name; }
        public AttendanceStatus GetAttendanceStatus() { return _attendanceStatus; }

        public void GetInfo()
        {
            System.Console.WriteLine($"Id               : {_id}");
            System.Console.WriteLine($"Name             : {_name}");
            System.Console.WriteLine($"Department       : {_department}");
            System.Console.WriteLine($"AttendanceStatus : {_attendanceStatus}");
        }
    }
}