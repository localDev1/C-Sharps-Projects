﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsSubmission
{
    //Abstract class called Person with two properties
    public abstract class Person
    {
        //two properties 
        public string  fisrtName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }

        //Abstract method to implement in the class inherit
        public abstract void SayName();

    }
}
