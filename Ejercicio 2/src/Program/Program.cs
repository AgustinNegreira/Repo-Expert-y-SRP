using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patientinfo = new Patient("Steven Jhonson", "56184274", "5555-555-555"); //creo un objeto de la clase patient con su info
            Doctor docinfo = new Doctor("Duffoe", "Neurocirujano"); //creo un objeto de la clase doctor con su info
            Appointment appointmentinfo = new Appointment(patientinfo.Name, patientinfo.ID, patientinfo.PhoneNumber, DateTime.Now, "Wall Street", docinfo.Name, docinfo.Specialty); //creo un objeto de la clase appointment con su info

            string appointmentResult2 = AppointmentService.CreateAppointment(appointmentinfo.PatientName, appointmentinfo.PatientId, appointmentinfo.PhoneNumber, appointmentinfo.Date, appointmentinfo.Place, appointmentinfo.Doc, appointmentinfo.DocSpec);
            //aqui llamo al metodo para crear la cita perteneciente a la clase appointment service con la informacion correspondiente y llamando a los atributos
            Console.WriteLine(appointmentResult2);
        }
    }
}
