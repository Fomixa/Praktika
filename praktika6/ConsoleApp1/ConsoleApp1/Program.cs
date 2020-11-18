using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace practica_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrow, ncolumn;
            Console.WriteLine("Введите кол-во строк и столбцов через пробел");
            string line = Console.ReadLine();
            var arr = line.Split(' ');

        }
    }

    class Person
    {
        private string name;
        private string surname;
        private System.DateTime birthdate;
        public Person(string _name, string _surname, DateTime _birthdate)
        {
            name = _name;
            surname = _surname;
            birthdate = _birthdate;
        }
        public Person()
        {
            name = "Chel";
            surname = "Tbl";
            birthdate = DateTime.Now;
        }
        public string person_name
        {
            get
            {
                return name;
            }
        }
        public string person_surname
        {
            get
            {
                return surname;
            }
        }
        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
        }
        public int Get_set_date
        {
            get
            {
                return birthdate.Year;
            }
            set
            {
                birthdate = new DateTime(value, birthdate.Month, birthdate.Day);
            }

        }
        public override string ToString()
        {
            return name + " " + surname + " " + birthdate.Date.ToString();
        }
        public string ToShortString()
        {
            return name + " " + surname;
        }
    }
    enum TimeFrame { Year, TwoYears, Long }
    class Paper
    {
        public string NameP
        {
            get;
            set;
        }
        public Person Author
        {
            get;
            set;
        }
        public DateTime Data
        {
            get;
            set;
        }

        public Paper(string _NameP, Person _Author, DateTime _Data)
        {
            NameP = _NameP;
            Author = _Author;
            Data = _Data;
        }
        public Paper()
        {
            NameP = "Cheeeel";
            Author = new Person();
            Data = new DateTime(2020, 01, 01);
        }
        public override string ToString()
        {
            return NameP + " " + Author + " " + Data;
        }
    }
    class ResearchTeam
    {
        public string Theme_of_res;
        public string Name_of_org;
        public int Number_of_reg;
        public TimeFrame duration;
        public List<Paper> _publications = new List<Paper>();
        public ResearchTeam(string _Theme_of_res, string _nameoforg, int _numberofreg, TimeFrame _duration)
        {
            Theme_of_res = _Theme_of_res;
            Name_of_org = _nameoforg;
            Number_of_reg = _numberofreg;
            duration = _duration;
        }
        public ResearchTeam()
        {
            Theme_of_res = "Tema";
            Name_of_org = "Ceeeeeeeeeeeeeeeeeb";
            Number_of_reg = -1;
            duration = new TimeFrame();
            _publications = new List<Paper>();
        }
        public string theme
        {
            get
            {
                return Theme_of_res;
            }
            set
            {
                Theme_of_res = value;
            }
        }
        public string name_of_ogr
        {
            get
            {
                return Name_of_org;
            }
            set
            {
                Name_of_org = value;
            }
        }
        public int numberofreg
        {
            get
            {
                return Number_of_reg;
            }
            set
            {
                Number_of_reg = value;
            }
        }
        public TimeFrame Dur
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        public IReadOnlyList<Paper> Publications
        {
            get
            {
                return _publications.AsReadOnly();
            }
            set
            {
                _publications = new List<Paper>(value);
            }
        }
        public Paper LastPublic
        {
            get
            {
                if (_publications.Count == 0)
                {
                    return null;
                }
                else
                {
                    Paper last_pub = _publications[0];
                    for (int i = 1; i < _publications.Count; i++)
                    {
                        if (_publications[i].Data > last_pub.Data)
                        {
                            last_pub = _publications[i];
                        }
                    }
                    return last_pub;
                }
            }
        }
        public bool this[TimeFrame rez_prov]
        {
            get
            {
                if (Dur == rez_prov)
                    return true;
                else
                    return false;
            }
        }
        public void AddPapers(params Paper[] papers)
        {
            for (int i = 0; i < papers.Length; i++)
            {
                _publications.Add(papers[i]);
            }
        }
        public override string ToString()
        {
            return Theme_of_res + " " + Name_of_org + " " + Number_of_reg + " " + duration + " " + _publications;
        }
        public string ToShortString()
        {
            return Theme_of_res + " " + Name_of_org + " " + Number_of_reg + " " + duration;
        }


    }

}
