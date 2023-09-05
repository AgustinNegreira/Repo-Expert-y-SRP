using System;

namespace Library
{
    public class Patient //clase especifica para crear el perfil del paciente
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string PhoneNumber { get; set; }

        public Patient (string name, string id, string phoneNumber)
        {
            this.Name = name;
            this.ID = id;
            this.PhoneNumber = phoneNumber;
        }
    }
}