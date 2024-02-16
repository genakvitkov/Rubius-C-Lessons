using System;

namespace HospitalHomework
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Speciality { get; set; }
        public Patient Appointment { get; set; }
    
        public void Cure(Patient patient) 
        {
            patient.IsIll = false;
            patient.GetStatus();
            Console.WriteLine($"Лечение прошло успешно! Пациент {patient.Name} {patient.HealthStatus}");
        }
    }
} 