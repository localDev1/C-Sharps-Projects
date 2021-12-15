using System;
using System.Collections.Generic;

namespace CodeFirstChallenge
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public byte[] RowVersion { get; set; }
        
        public virtual StudentAddress Address { get; set; }
        
    }
}