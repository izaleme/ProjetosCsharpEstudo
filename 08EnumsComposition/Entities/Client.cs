using System;

namespace EnumsComposition.Entities
{
    class Client
    {
        #region  Atributos/Properties

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        #endregion

        #region  Construtores

        public Client() { }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        #endregion

        #region  Métodos

        public override string ToString()
        {
            return Name
                + " ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }

        #endregion
    }
}