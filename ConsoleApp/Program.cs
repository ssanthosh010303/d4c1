/*
 * Author: Sakthi (Sandy) Santhosh
 * Created on: 11/04/2024
 *
 * Day-4 Challenge-1: Simple Doctor Registration and Management System
 */
namespace Challenge1;

class Program
{
    static void Main()
    {
        Doctor doctorHandle = new Doctor
        {
            Id = 1,
            Age = 35,
            Experience = 10,
            Qualifications = new List<string> { "MBBS", "MD" },
            Speciality = "Cardiology"
        };

        doctorHandle.PrintDoctorDetails();
    }
}
