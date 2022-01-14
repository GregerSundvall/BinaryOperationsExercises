using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class OR
{
    public static void Exercise(int index)
    {
		// OR (|)
		{
			// With bools
			// 0010 0011
			bool[] lhs_byte = new bool[]
			{
				false, false, true, false,
				false, false, true, true
			};
			// 1010 1010
			bool[] rhs_byte = new bool[]
			{
				true, false, true, false,
				true, false, true, false
			};

			// ANDing 
			const int BYTE_LENGTH = 8;
			bool[] result_byte = new bool[BYTE_LENGTH];
			for (int i = 0; i < BYTE_LENGTH; i++)
			{
				// we OR bools, therefore, we use ||
				result_byte[i] = lhs_byte[i] || rhs_byte[i];
			}

			// With bits
			int lhs_bits = 0b_0010_0011;
			int rhs_bits = 0b_1010_1010;
			int result_bits = lhs_bits | rhs_bits;
		}
		// under the hood the CPU is doing the for loop, but CPUs these days are so well optimised
		// and architectured, that they operate on multiple bits (bytes) at the same time

		// In either the solution is: 1010 1011

		// Exercise: Write the write OR solution on the right-hand side (0b_0000_0000)
		{
			bool[] answers = new bool[10];
			answers[0] = (0b_1111_0000 | 0b_0000_1111) == 0b_11111111;
			answers[1] = (0b_0010_1010 | 0b_1100_0010) == 0b_11101010;
			answers[2] = (0b_1011_0011 | 0b_0000_0000) == 0b_10110011;
			answers[3] = (0b_1100_0000 | 0b_0000_0010) == 0b_11000010;
			answers[4] = (0b_0000_0001 | 0b_1000_0000) == 0b_10000001;

			answers[5] = (12 | 20) == 0;
			answers[6] = (77 | 120) == 0;
			answers[7] = (19 | 70) == 0;
			answers[8] = (20 | 20) == 0;
			answers[9] = (15 | 14) == 0;

			Console.WriteLine($"\nExercise {index}: ORing!");
			for (int i = 0; i < answers.Length; i++)
			{
				Console.WriteLine($"{i}:\t{answers[i]}");
			}
		}
	}
}

