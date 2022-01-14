
class Demo
{
	enum ExerciseType
    {
		None = 0,
		Reading = 1 << 0,		// 0b_0000_0001
		OR = 1 << 1,			// 0b_0000_0010
		AND = 1 << 2,			// 0b_0000_0100
		XOR = 1 << 3,			// 0b_0000_1000
		NOT = 1 << 4,			// 0b_0001_0000
		SHIFT = 1 << 5,			// 0b_0010_0000
		INTERMEDIATE = 1 << 6,	// 0b_0100_0000
	}

	static void Main(string[] args)
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

		// NOTE: If you feel clever by succeeding these exercises by adding "|| true" or whatever,
		// I do not care, these exercises are solely for self-practice and to learn bit operations
		// If you cheat the exercises you cheat yourself :) 

		// |, &, and ^
		// These operators AND, OR and XOR
		// ANDing means to only have as a result what ALL input have
		// ORing means to take ALL the 1s from from ALL the input
		// XORing is a little more complicated, it takes either, but if both of them are 1, it becomes 0

		// For each operation you can imagine each bit as a bool
		// Therefore, multiple bits would be an array of bytes
		// Example: 0000 0000 would be an array of 8 bools
		// Let's compare the bools and the bits

		// Input bools are from the least significant bit to the most significant bit
		// So the opposite way as you would read bits (Instead of righ to left, this function takes left to right)

		ExerciseType exerciseTypesToControl = ExerciseType.None;
		exerciseTypesToControl |= ExerciseType.Reading;
		exerciseTypesToControl |= ExerciseType.OR;
		exerciseTypesToControl |= ExerciseType.AND;
		exerciseTypesToControl |= ExerciseType.XOR;
		exerciseTypesToControl |= ExerciseType.NOT;
		exerciseTypesToControl |= ExerciseType.SHIFT;

		if((exerciseTypesToControl & ExerciseType.Reading) != 0)
        {
			ReadingBinary.Exercise(0);
        }
		if ((exerciseTypesToControl & ExerciseType.OR) != 0)
		{
			OR.Exercise(1);
		}
		if((exerciseTypesToControl & ExerciseType.AND) != 0)
        {
			AND.Exercise(2);
		}		
		if((exerciseTypesToControl & ExerciseType.XOR) != 0)
        {
			XOR.Exercise(3);
		}		
		if((exerciseTypesToControl & ExerciseType.NOT) != 0)
        {
			NOT.Exercise(4);
		}			
		if ((exerciseTypesToControl & ExerciseType.SHIFT) != 0)
		{
			SHIFT.Exercise(5);
		}
		if ((exerciseTypesToControl & ExerciseType.INTERMEDIATE) != 0)
		{
			Intermediate.Exercise(6);
		}
	}
}
