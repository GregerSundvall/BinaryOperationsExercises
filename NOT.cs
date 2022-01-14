using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class NOT
{
    public static void Exercise(int index)
    {
		// ~
		// This operator inverts the bits
		// ~1111 1111 -> 0000 0000
		// ~0101 1000 -> 1010 0111
		// The equivalent to it would be the not(!) operator 
		{
			// 0010 0011
			bool[] @byte = new bool[]
			{
				false, false, true, false,
				false, false, true, true
			};

			// ANDing 
			const int BYTE_LENGTH = 8;
			bool[] result_bytes = new bool[BYTE_LENGTH];
			for (int i = 0; i < BYTE_LENGTH; i++)
			{
				// We no the byte and it becomes the opposite of it
				// The opposite of true is false
				// The oppoisite of false is true
				result_bytes[i] = !@byte[i];
			}

			// With bits
			int bits = 0b_0010_0011;
			int result_bits = ~bits;
		}
		// In either the solution is: 1101 1100

		{
			bool[] answers = new bool[10];
			answers[0] = ~0b_1111_0000 == 0b_0000_0000;
			answers[1] = ~0b_0010_1010 == 0b_0000_0000;
			answers[2] = ~0b_1011_0011 == 0b_0000_0000;
			answers[3] = ~0b_1100_0110 == 0b_0000_0000;
			answers[4] = ~0b_0000_0101 == 0b_0000_0000;

			answers[5] = ~12 == 0;
			answers[6] = ~77 == 0;
			answers[7] = ~19 == 0;
			answers[8] = ~20 == 0;
			answers[9] = ~15 == 0;

			Console.WriteLine($"\nExercise {index}: NOTing!");
			for (int i = 0; i < answers.Length; i++)
			{
				Console.WriteLine($"{i}:\t{answers[i]}");
			}
		}
	}
}
