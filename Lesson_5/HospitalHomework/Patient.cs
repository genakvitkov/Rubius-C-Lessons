using System;

namespace HospitalHomework
{
	public class Patient
	{
		public uint Age { get; set; }
		public string Name { get; set; }
		public bool IsIll { get; set; }
		public string HealthStatus { get; set; }
		public string Diagnosis { get; set; }
		public string RecommendedDoctor { get; set; }
		public Doctor Appointment { get; set; }

		public void GetStatus()
		{
			HealthStatus = IsIll ? "Болен" : "Здоров";
		}

		public void GetAppointment(Doctor doctor)
		{
			Console.WriteLine($"Пациент {Name} записан на приём к доктору {doctor.Name}");
			doctor.Appointment = this;
		}
	}
}


