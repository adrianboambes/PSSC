﻿using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    //Entity 
    public class Professor
    {


        public PlainText Name_teacher { get; internal set; }

        public Professor(PlainText name)
        {
            Name_teacher = name;
        }
    }
}
