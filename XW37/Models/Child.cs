﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace XW37.Models
{
    public class Child
    {
        [PrimaryKey, AutoIncrement]

        public int C_ID { get; set; }
        public string C_Name { get; set; }
        public string C_L_Name { get; set; }
        public string C_Gender { get; set; }
        public string C_Team_Football { get; set; }
        public string C_Team_Sail { get; set; }


    }
}
