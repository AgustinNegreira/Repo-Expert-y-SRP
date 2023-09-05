using System;
using System.Text;

namespace Library
{
    public class Doctor //clase especifica para crear el perfil del doctor
    {
        public string Name { get; set; }
        public string Specialty { get; set; }

        public Doctor (string name, string specialty)
        {
            this.Name = name;
            this.Specialty = specialty;
        }
    }
}