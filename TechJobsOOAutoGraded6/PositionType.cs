﻿using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType : JobField
	{
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        public PositionType(string value) : base(value)
        {
            //Id = nextId;
            //nextId++;
        }

        //public PositionType(string value) : this()
        //{
        //    Value = value;
        //}

        // TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.

        //public override bool Equals(object obj)
        //{
        //    return obj is PositionType type &&
        //           Id == type.Id;
        //           //Value == type.Value;
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

