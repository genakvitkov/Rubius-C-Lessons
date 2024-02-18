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

        public void SetAppointment(Patient patient) 
        { 
            Appointment = patient;
            Console.WriteLine($"Пациент {Appointment.Name} на приёме у доктора {Name}");
        }
    }
}
/*Понятия не имею, насколько всё это соответствует принципам SOLID, в частности - нормально ли, что методы одного класса
меняют состояние другого или вызывают его методы (как в строках 13-14)? Или что свойство класса Doctor имеет тип Patient?*/