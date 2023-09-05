using System;

namespace Library
{
    public class Appointment //clase especifica para crear la cita con toda la informacion necesaria
    {
        public string PatientName {get; set;}
        public string PatientId {get; set;}
        public string Doc {get; set;}
        public DateTime Date {get; set;}
        public string Place {get; set;}
        public string PhoneNumber {get; set;}
        public string DocSpec {get; set;}

        public Appointment (string patientname, string patientid, string phonenumber, DateTime date, string place, string doctorname, string doctorspecialty)
        {
            this.PatientName = patientname;
            this.Doc = doctorname;
            this.DocSpec = doctorspecialty;
            this.Date = date;
            this.Place = place;
            this.PhoneNumber = phonenumber;
            this.PatientId = patientid;
        }
    }
}