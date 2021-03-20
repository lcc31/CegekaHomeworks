﻿namespace GenericsExercise.Console
{
    public class Student : IEntity
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName}";
        }
    }
}