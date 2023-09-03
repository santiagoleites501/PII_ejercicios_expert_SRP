using System;
using Library;
using System.Text;
namespace Program
{
    class Program{
        static void Main(string[] args){

        
         // Datos para la primera cita
            string name1 = "Ralf Manson";
            string id1 = "";
            string phoneNumber1 = "5555-555-555";
            DateTime date1 = DateTime.Now;
            string appointmentPlace1 = "Queen Street";
            string doctorName1 = "";
        
            string result1 = Library.AppointmentService.CreateAppointment(new Library.AppointmentInfo
            {
                Name = name1,
                Id = id1,
                PhoneNumber = phoneNumber1,
                Date = date1,
                AppointmentPlace = appointmentPlace1,
                DoctorName = doctorName1
            });
// Datos para la segunda cita
            string name2 = "Steven Jhonson";
            string id2 = "986782342";
            string phoneNumber2 = "5555-555-555";
            DateTime date2 = DateTime.Now;
            string appointmentPlace2 = "Wall Street";
            string doctorName2 = "Armand";

            string result2 = Library.AppointmentService.CreateAppointment(new Library.AppointmentInfo
            {
                Name = name2,
                Id = id2,
                PhoneNumber = phoneNumber2,
                Date = date2,
                AppointmentPlace = appointmentPlace2,
                DoctorName = doctorName2
            });

            // Imprimir resultados
            Console.WriteLine("Resultado 1:");
            Console.WriteLine(result1);

            Console.WriteLine("\nResultado 2:");
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}




