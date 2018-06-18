/*
 * Created by SharpDevelop.
 * User: Edgar Esteves
 * Date: 18/06/2018
 * Time: 17:06
 * 
 */
using System;
using System.Collections.Generic;

namespace AubayTest
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello Aubay!");
			
			DateTime date1 = new DateTime(1989,6, 22, 1, 1, 1);
			
			PersonManager PM = new PersonManager();
			PM.AddPerson("Edgar",date1);
			PM.AddPerson("Edgar",date1.AddYears(+1));
			PM.AddPerson("Edgar",date1.AddYears(+2));
			
			PM.DeletePerson("Edgar",29);
			
			for(int i =0; i<PM.DB.Count; i++)
			{
				Console.WriteLine(i.ToString());
			}
			
			Console.ReadKey(true);
		}
	}
	
	public class Person
    {
        public string Name {get; set;}
        public int Age {get; set;}
       
        public void CalcAge(DateTime _birthDate)
        {
        	if(_birthDate.Year <= DateTime.Now.Year)
        	{
            	this.Age = DateTime.Now.Year - _birthDate.Year;
        	}
        	else {Age = 0;}
       	}
    }
    
    public class PersonManager
    {
      public List<Person> DB = new List<Person>();
      
        public void AddPerson(string _name, DateTime _birthDate)
        {
            try
            {
            	if((_name == null || _name == "") || (_birthDate.Year <= DateTime.Now.AddYears(-120).Year))
            	{
            		Console.WriteLine("Please enter a valid Name and Age less than 120 years old.");
            	}
            	else
            	{
                	Person p = new Person();
                	p.Name = _name;
                	p.CalcAge(_birthDate);
                	DB.Add(p);
            	}
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        
        public void DeletePerson(string _name, int _Age)
        {
            try
            {
            	if(_name == null || _name == "") 
            	{
            		Console.WriteLine("Please enter a valid Name and Age.");
            	}
            	else
            	{
            		DB.RemoveAll((Person) => Person.Name == _name && Person.Age == _Age);
            	}
            }
            catch(Exception e)
            {
                throw e;
            }
        }

    }

}