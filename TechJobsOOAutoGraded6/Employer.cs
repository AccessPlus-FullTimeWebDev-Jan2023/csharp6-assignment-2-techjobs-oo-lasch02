﻿using System;
//this assignment goes thru chapter 8
namespace TechJobsOOAutoGraded6
{
	public class Employer : JobField
	{
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        public Employer(string value) : base(value)
        {
            //Id = nextId;
            //nextId++;
        }

        //public Employer(string value) : this()
        //{
        //    Value = value;
        //}

        //public override bool Equals(object obj)
        //{
        //    return obj is Employer employer &&
        //           Id == employer.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}

