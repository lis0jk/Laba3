using System;

namespace L3
{
    class Program
    {
        static void Main(string[] args)
        {
            DiffStudent student1 = new DiffStudent("Avreitsevich",
                    "Elizaveta", "Sergeevna", "BSUIR", "CSN", "CSPT", 1);
            IRating info = new InfoRating();
            info.PrintBasicInfo(student1);
            info.Rating();
        }
    }
}
