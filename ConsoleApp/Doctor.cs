/*
 * Author: Sakthi (Sandy) Santhosh
 * Created on: 11/04/2024
 */
namespace Challenge1;

class Doctor
{
    private static readonly Dictionary<string, string> QualificationsDict = new Dictionary<string, string>
    {
        { "MBBS", "Bachelor of Medicine, Bachelor of Surgery" },
        { "MD", "Doctor of Medicine" },
        { "DO", "Doctor of Osteopathic Medicine" },
        { "DDS", "Doctor of Dental Surgery" },
        { "DMD", "Doctor of Dental Medicine" },
        { "PharmD", "Doctor of Pharmacy" },
        { "DVM", "Doctor of Veterinary Medicine" },
    };
    private static readonly HashSet<string> Specialities =
    [
        "Anesthesiology",
        "Cardiology",
        "Dermatology",
        "Emergency Medicine",
        "Endocrinology",
        "Family Medicine",
        "Gastroenterology",
        "Hematology",
        "Infectious Disease",
        "Internal Medicine",
        "Neurology",
        "Obstetrics and Gynecology (OB/GYN)",
        "Ophthalmology",
        "Orthopedics",
        "Otolaryngology (ENT)",
        "Pediatrics",
        "Psychiatry",
        "Pulmonology",
        "Radiology",
        "Urology"
    ];

    ushort _age, _experience;
    string _speciality;
    List<string> _qualifications;

    public Doctor()
    {
        _speciality = string.Empty;
        _qualifications = [];
    }

    public uint Id { get; set; }

    public ushort Age
    {
        get { return _age; }
        set
        {
            if (value > 0 && value < 150)
                _age = value;
            else
                throw new ArgumentOutOfRangeException(nameof(Age), "Age is out of valid range.");
        }
    }

    public ushort Experience
    {
        get { return _experience; }
        set
        {
            if (value > 0 && value < Age)
                _experience = value;
            else
                throw new ArgumentException($"Experience cannot be greater than age ({Age}) or less than zero.", nameof(Experience));
        }
    }

    public List<string> Qualifications
    {
        get { return _qualifications; }
        set
        {
            foreach (string qualification in value)
                if (IsValidQualification(qualification))
                    _qualifications.Add(qualification);
                else
                    throw new ArgumentException("Invalid qualification provided.", nameof(Qualifications));

        }
    }

    public string Speciality
    {
        get { return _speciality; }
        set
        {
            if (IsValidSpeciality(value))
                _speciality = value;
            else
                throw new ArgumentException("Invalid speciality provided.", nameof(Speciality));
        }
    }

    public static bool IsValidQualification(string qualification) { return QualificationsDict.ContainsKey(qualification); }
    public static bool IsValidSpeciality(string speciality) { return Specialities.Contains(speciality); }

    public void PrintDoctorDetails()
    {
        Console.WriteLine("Doctor");
        Console.WriteLine("  ID:             " + Id);
        Console.WriteLine("  Age:            " + Age);
        Console.WriteLine("  Experience:     " + Experience);
        Console.WriteLine("  Speciality:     " + Speciality);

        Console.WriteLine("  Qualifications:");
        foreach (string qualification in Qualifications)
            Console.WriteLine($"    {QualificationsDict[qualification]} ({qualification})");
    }
}
