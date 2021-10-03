using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_izvp
{
    public struct Note
    {
        private String name;
        private String phoneNumber;
        private int[] birthday;

        public Note(string name, string phoneNumber, int[] birthday)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.birthday = birthday;
        }

        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int[] Birthday { get => birthday; set => birthday = value; }

    }
}
