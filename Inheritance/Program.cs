﻿// https://www.hackerrank.com/challenges/30-inheritance/problem

using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person
{
    private int[] testScores;
  
    public Student(string firstName, string lastName, int id, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        testScores = scores;
    }
    
    public char Calculate()
    {
        double avg = testScores.Average();
        if (avg >= 90)
        {
            return 'O';
        }
        else if (avg >= 80)
        {
            return 'E';
        }
        else if (avg >= 70)
        {
            return 'A';
        }
        else if (avg >= 55)
        {
            return 'P';
        }
        else if (avg >= 40)
        {
            return 'D';
        }
        else
        {
            return 'T';
        }
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}