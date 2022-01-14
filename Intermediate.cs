using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Intermediate
{
	public static void Exercise(int index)
	{
		// Add Combinational exercises
		// Exercise: Solve the left-hand sides so the equality checks evaluate to true
		{
			bool[] answers = new bool[10];

			// Part 1
			// Add solution within the brackets on the left-hand side
			// and make your solution evaluate to true
			// You are only allowed to use &, |, ^, ~, <<, >>
			// Of course you could always only use AND and OR, but come on, give it some spice.
			answers[0] = (0b_0000_0001 /* Remove commet and write solution */) == 0b_0000_0000;
			answers[1] = (0b_0000_1000 /* Remove commet and write solution */) == 0b_0010_1001;
			answers[2] = (0b_0100_0001 /* Remove commet and write solution */) == 0b_0000_1000;
			answers[3] = (0b_1111_1111 /* Remove commet and write solution */) == 0b_0000_0000;
			answers[4] = (0b_1111_1111 /* Remove commet and write solution */) == 0b_1001_0100;

			// Part 2
			// You are only allowed to use &, |, ^, ~, <<, >>
			int set_bit(int number, int index)
			{
				// Fill out this function
				// The return value must be the input number
				// with the certain bit in position of index set to 1
				return number;
			}
			int clear_bit(int number, int index)
			{
				// Fill out this function
				// The return value must be the input number
				// with the certain bit in position of index set to 0
				return number;
			}

			// Fill out the functions above and set the correct parameters
			answers[5] = set_bit(0b_0000_0000, 0) == 0b_0000_0001;
			answers[6] = set_bit(0b_0000_0000, 0) == 0b_0000_1000;
			answers[7] = clear_bit(0b_1111_1111, 0) == 0b_1111_1011;
			answers[8] = clear_bit(0b_1111_1111, 0) == 0b_1011_1111;
			answers[9] = clear_bit(0b_1111_1111, 0) == 0b_1111_1101;


			Console.WriteLine($"\nExercise {index}: INTERMEDIATE...ing!");
			for (int i = 0; i < answers.Length; i++)
			{
				Console.WriteLine($"{i}:\t{answers[i]}");
			}
		}
	}
}

