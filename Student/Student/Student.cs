﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public static Student[] store = new Student[25];
        public string name;
        public string surname;
        public int gpa;
        public static int k = 0;
        public Student(string name, string surname, int gpa)
        {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;
        }

        public static Student create(string name, string surname, int gpa)
        {
            name = Console.ReadLine();
            surname = Console.ReadLine();
            string s_gpa = Console.ReadLine();
            gpa = int.Parse(s_gpa);
            Student st1 = new Student(name, surname, gpa);
            store[k] = st1;
            k++;
            return st1; 
        }
        
        public override string ToString()
        {
            return "NAME: " + this.name + "\n" + "SURNAME: " + this.surname + "\n" + "GPA: " + this.gpa;
        }
       
    }
    
}
