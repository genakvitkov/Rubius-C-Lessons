using System;
using System.Collections.Generic;

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
      
        public void GetStatus()
        {
            HealthStatus = IsIll ? "болен" : "здоров";
        }

        public void GetIllness(int illnessCode)
        {
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

            foreach (var item in illness)
            {
                if (item.Key == illnessCode)
                {
                    //Console.WriteLine(item.Key);
                    Diagnosis = item.Value;
                    IsIll = true;
                    GetStatus();
                    Console.WriteLine($"Пациент {Name} {HealthStatus}");

                    if (item.Key <= 3)
                    {
                        RecommendedDoctor = "Психиатр";
                    }
                    else if (item.Key >= 4 && item.Key < 7)
                    {
                        RecommendedDoctor = "Травматолог";
                    }
                    else
                    {
                        RecommendedDoctor = "Терапевт";
                    }
                }
            }
            Console.WriteLine($"У пациента {Name} {Diagnosis}");
            Console.WriteLine($"Рекомендуемый специалист:{RecommendedDoctor}");
        }
    }
}


