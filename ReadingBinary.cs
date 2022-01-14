using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ReadingBinary
{
    public static void Exercise(int index)
    {
		// Think about numbers as multiple bools 
		// If you have a number with 8 bits, then you can represent 255 numbers
		// To visualise it - Open your calculator on your windows pc
		// Press the "burger" button and select the "Programmer" calculator
		// Open/select the bit toggling keypad and change the QWORD to BYTE 
		// All those buttons are located somewhere in the centre of the calculator 

		// One habit when you think about bits and bytes is to translate numbers to the bit/byte system
		// One representation is hexadecimal, another one is binary (a long string of 0s and 1s)
		// Why hexadecimal is relevant is a story for another time :D 

		// The classic decimal system uses a power of 10 - Nothing to imagine here, we know this system
		// When you check out memory, the number 15 stored in one byte will get represented with 0F
		// and 0F can get broken down to 0000 1111
		// moreover, the number 240, F0 in hexadecimal can get broken down to 1111 0000
		// It's save to say, 4 bits can get represented by using 0 to F, 
		// while 8 bits can get represented by using a range from 0 to FF, each additional byte 
		// will naturally add FF in terms of capacity

		// NOTE: The bit representation is read from right to left (The most significant bit to the least)
		// This can vary based on the platform, but for the sake of this exercise and all. IT IS THIS WAY!


		// Exercise: Fill out the left-hand side to the corrcet binary number,
		// so the equality check evaluated to true
		// Numbers are implied to be unsigned
		// 0b at the beginning is the way to "force" bit representation 
		// Figure out the correct bit representation for the number on the right-hand side
		{
			bool[] answers = new bool[10];
			answers[0] = 0b_0000_1010 == 240;
			answers[1] = 0b_0000_1010 == 17;
			answers[2] = 0b_0000_1010 == 28;
			answers[3] = 0b_0000_1010 == 35;
			answers[4] = 0b_0000_1010 == 89;

			answers[5] = 0b_0000_1010 == 128;
			answers[6] = 0b_0000_1010 == 255;
			answers[7] = 0b_0000_1010 == 0;
			answers[8] = 0b_0000_1010 == 189;
			answers[9] = 0b_0000_1010 == 39;

			Console.WriteLine($"Exercise {index}: Reading Binary!");
			for (int i = 0; i < answers.Length; i++)
			{
				Console.WriteLine($"{i}:\t{answers[i]}");
			}
		}
	}
}

