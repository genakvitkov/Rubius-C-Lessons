using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HospitalHomework
{
    class Program
    {
        public static Random rand = new Random();

        public static int GenerateIllness()
        {
            var random = rand;
            int code = random.Next(1, 10);
            return code;

        }

        public static void ChooseDoctor(Patient patient, List<Doctor> doctors)
        {
            foreach (Doctor doctor in doctors)
            {
                if (patient.RecommendedDoctor == doctor.Speciality)
                {
                    Console.WriteLine($"Пациент {patient.Name} c диагнозом {patient.Diagnosis}\nнаправлен к доктору {doctor.Name} со специальностью {doctor.Speciality}");

                    doctor.SetAppointment(patient);
                    break;
                }
            }
        }
       
        static void Main(string[] args)
        {
            var patients = new List<Patient>()
            {
            new Patient { Name = "Валерия", Age = 26 },
            new Patient { Name = "Роман", Age = 22 },
            new Patient { Name = "Даниил", Age = 30 }
            };

            var doctors = new List<Doctor>()
            {
            new Doctor { Name = "Иван Иванович", Speciality = "Терапевт" },
            new Doctor { Name = "Анастасия Евгеньевна", Speciality = "Травматолог" },
            new Doctor { Name = "Ирина Александровна", Speciality = "Психиатр" }
            };

            while (true) 
            {
                for (int i = 0; i < patients.Count; i++)
                {
                    int code = GenerateIllness();
                    patients[i].GetIllness(code);
                    ChooseDoctor(patients[i], doctors);

                    foreach (Doctor doctor in doctors)
                    {                 
                        if (doctor.Appointment == patients[i])
                        {
                            doctor.Cure(doctor.Appointment);
                        }
                    }
                    Console.WriteLine("");
                }
                Console.ReadLine();
            }                     
        }  
    }       
}






