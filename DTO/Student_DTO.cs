using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Studen
    {
        public string id { get; set; }
        public string name { get; set; }
        public string dateOfBirth { get; set; }
        public string gender { get; set; }
        public string khoa { get; set; }
        public string img { get; set; }
        public Studen() { }
        public Studen(string id, string name, string dateOfBirth, string gender, string khoa, string img)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.khoa = khoa;
            this.img = img;
        }
    }
}



