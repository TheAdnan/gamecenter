﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Student
    {

        long id;
        string ime, prezime;
        List<Single> ocjene = new List<Single>();

        public Student(string i, string p)  {
            ime=i;
            prezime=p;
        }

        public string Ime
        {
            get;
            set;
        }
        public string Prezime
        {
            get;
            set;
        }
        public long Id
        {
            get;
            set;
        }
    }
}

