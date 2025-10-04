using System;

class InvalidScoreException : Exception
{
	public InvalidScoreException(string message) : base(message) { }
}
class Program
{
	static void Main()
	{
		try
		{
			Console.WriteLine("Enter a score (0-100):");
			int score = -9;
			if (score < 0 || score > 100)
				throw new InvalidScoreException("Score must be between 0 and 100!");
			Console.WriteLine($"Valid score: {score}");
		}
		catch (InvalidScoreException ex)
		{
			Console.WriteLine($"Caught custom exception: {ex.Message}");
		}
		catch (FormatException)
		{
			Console.WriteLine("Please enter a valid number!");
		}
		finally
		{
			Console.WriteLine("Finally block runs always (cleanup or message).");
		}

		Console.WriteLine("Program finished.");
	}
}
