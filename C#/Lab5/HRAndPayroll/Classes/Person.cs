
namespace HRAndPayrollManagementSystem.Classes
{
    abstract class Person
    {
        #region Fields
        static protected readonly HashSet<uint> AssignedIDs = [];
        protected uint id;
        protected string fullName = "Unspecified";
        #endregion


        #region Properties
        public virtual uint ID
        {
            set
            {
                if (AssignedIDs.Contains(value))
                    throw new ArgumentException("ID already exists.");

                id = value;
                AssignedIDs.Add(value);
            }

            get => id;
        }

        public virtual string FullName
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Fullname can't be null, or whitespaces.");

                fullName = value;
            }

            get => fullName;
        }
        #endregion


        #region Methods

        public virtual void DisplayInfo(bool showID)
        {
            Console.WriteLine($"Name : {FullName}");

            if (showID)
                Console.WriteLine($"ID   : {ID}");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name        : {FullName} ");
            Console.WriteLine($"ID          : {ID} ");
        }


        #endregion
    }
}