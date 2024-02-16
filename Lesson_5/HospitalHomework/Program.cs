using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalHomework
{
    class Program
    {
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

            SetIllness(patients[0]);
            ChooseDoctor(patients[0], doctors);
            foreach (Doctor doctor in doctors) 
            { 
             if (patients[0].RecommendedDoctor == doctor.Speciality) 
                {
                    patients[0].GetAppointment(doctor);
                }
            }

            foreach (Doctor doctor in doctors) 
            { 
            if (patients[0].Appointment == doctor) 
                {
                    doctor.Cure(patients[0]);
                }
            }

            SetIllness(patients[1]);
            ChooseDoctor(patients[1], doctors);
            foreach (Doctor doctor in doctors)
            {
                if (patients[1].RecommendedDoctor == doctor.Speciality)
                {
                    patients[1].GetAppointment(doctor);
                }
            }

            foreach (Doctor doctor in doctors)
            {
                if (patients[1].Appointment == doctor)
                {
                    doctor.Cure(patients[1]);
                }
            }

            SetIllness(patients[2]);
            ChooseDoctor(patients[2], doctors);
            foreach (Doctor doctor in doctors)
            {
                if (patients[2].RecommendedDoctor == doctor.Speciality)
                {
                    patients[2].GetAppointment(doctor);
                }
            }

            foreach (Doctor doctor in doctors)
            {
                if (patients[2].Appointment == doctor)
                {
                    doctor.Cure(patients[2]);
                }
            }


            /*
                        foreach (Patient p in patients)
                        {
                            SetIllness(p);
                            ChooseDoctor(p, doctors);
                        }*/

            Console.ReadLine();
            

        }

        public static void SetIllness(Patient patient)
        {
            var rand = new Random();
            int code = rand.Next(1, 10);
            var illness = new Dictionary<int, string>()
            {
                {1, "Посттравматическое расстройство"},
                {2, "Пограничное расстройство"},
                {3, "Тревожно-депрессивное расстройство"},
                {4, "Ушиб"},
                {5, "Сотрясение"},
                {6, "Перелом"},
                {7, "ОРВИ"},
                {8, "Грипп"},
                {9, "Ангина"}
            };
            Console.WriteLine(code);

            foreach (var item in illness)
            {
                if (item.Key == code)
                {
                    Console.WriteLine(item.Key);
                    patient.Diagnosis = item.Value;
                    patient.IsIll = true;

                    if (item.Key <= 3)
                    {
                        patient.RecommendedDoctor = "Психиатр";
                    }
                    else if (item.Key >= 4 && item.Key < 7)
                    {
                        patient.RecommendedDoctor = "Травматолог";
                    }
                    else
                    {
                        patient.RecommendedDoctor = "Терапевт";
                    }
                }
            }

            Console.WriteLine($"У пациента {patient.Name} {patient.Diagnosis}");
            Console.WriteLine($"Рекомендуемый специалист:{patient.RecommendedDoctor}");
        }

        public static void ChooseDoctor(Patient patient, List<Doctor> doctors)
        {
            foreach (Doctor doctor in doctors)
            {
                if (patient.RecommendedDoctor == doctor.Speciality)
                {
                    Console.WriteLine($"Пациент {patient.Name} c диагнозом {patient.Diagnosis} \n направлен к доктору {doctor.Name} со специальностью {doctor.Speciality}");

                    patient.Appointment = doctor;
                    break;
                }
            }
        }
    }
}

    

