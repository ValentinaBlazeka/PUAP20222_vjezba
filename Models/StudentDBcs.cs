using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PUAP20222_vjezba.Models
{
    
    public class StudentDBcs
    {
        private List<Student> lista = new List<Student>();
        public StudentDBcs()
        {
            lista.Add(new Student()
            {
                Id = 1,
                Prezime = "Ivic",
                Ime = "Petar",
                Spol = 'M',
                DatumRodjenja = new DateTime(1991, 02, 01),
                Oib = "12345678912",
                RedovanStudent = true
            }
            );

            lista.Add(new Student()
            {
                Id = 2,
                Prezime = "Marko",
                Ime = "Markic",
                Spol = 'M',
                DatumRodjenja = new DateTime(1992, 05, 04),
                Oib = "36575678912",
                RedovanStudent = true
            }
           );

            lista.Add(new Student()
            {
                Id = 3,
                Prezime = "Ivana",
                Ime = "Ivic",
                Spol = 'Z',
                DatumRodjenja = new DateTime(1990, 10, 10),
                Oib = "42575678972",
                RedovanStudent = false
            }
          );

            lista.Add(new Student()
            {
                Id = 4,
                Prezime = "Lovro",
                Ime = "Lovric",
                Spol = 'M',
                DatumRodjenja = new DateTime(1992, 01, 18),
                Oib = "22575678962",
                RedovanStudent = true
            }
          );

        } 
            public List<Student> VratiListu()
            {
                return lista;
            }
        
            




        
    }
}