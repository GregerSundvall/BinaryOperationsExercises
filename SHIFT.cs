using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class SHIFT
{
    public static void Exercise(int index)
    {
		// Shift
		// <<
		// >> 

		// This operator saays what it does, it shifts the bits either to the left or right (up and down)
		// The best way to explain it is through an example
		// We have: 0000 0001 = 1
		// by saying 0000 0001 << 1 we tell the bit string to shift everything by one position to the left
		// NOTE: in C# overflowing bits are discarded and the new bits that get shifted in become 0
		// The solution would be 0000 0010 in this case
		{
			int bits = 0b_0000_0001;
			bits = bits << 1; // 0b_0000_0010
			bits = bits << 1; // 0b_0000_0100

			// We can also shift by multiple positions
			bits = bits << 4; // 0b_0100_0000

			// We can also shift everything back
			bits = bits >> 6; // 0b_0000_0001
		}

		{
			bool[] answers = new bool[10];
			// Exercise: Write the shifted solution on the right-hand side (0b_0000_0000)
			answers[0] = (0b_1111_0000 >> 1) == 0b_0000_0000;
			answers[1] = (0b_0010_1010 >> 4) == 0b_0000_0000;
			answers[2] = (0b_0000_0011 << 2) == 0b_0000_0000;
			answers[3] = (0b_0000_0110 << 3) == 0b_0000_0000;
			answers[4] = (0b_0000_0001 << 6) == 0b_0000_0000;

			// Exercise: Write the amount you must shift the bits on the left hand side on the right of the shift operator 
			// to achieve the result on the right
			answers[5] = (0b_0001_0010 << 0) == 0b_1001_0000;
			answers[6] = (0b_0110_0000 >> 0) == 0b_0000_0011;
			answers[7] = (0b_0000_1101 << 0) == 0b_0110_1000;
			answers[8] = (0b_0010_0100 >> 0) == 0b_0001_0010;
			answers[9] = (0b_0001_1100 >> 0) == 0b_0000_0111;

			Console.WriteLine($"\nExercise {index}: SHIFTing!");
			for (int i = 0; i < answers.Length; i++)
			{
				Console.WriteLine($"{i}:\t{answers[i]}");
			}
		}
	}
}

