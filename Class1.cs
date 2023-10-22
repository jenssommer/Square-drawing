namespace Abschlussaufgabe2
{
	public class Class1
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Insert a number:");
			try
            {
				int Nr = Convert.ToInt32(Console.ReadLine());
				if(Nr < 25 && Nr > 0)
                {
					Console.WriteLine("Thats a beautiful number!");
					Console.WriteLine();
					for (int i = 0; i < Nr; i++)
					{
						for (int j = 0; j < Nr; j++)
						{
							Console.Write("#");
						}
						Console.WriteLine();
					}
				} else
                {
					Console.WriteLine("The Number has to be smaller than 25 but bigger than 0");
					return;
                }
			} catch
            {
				Console.WriteLine("A error happend");
				Console.WriteLine("Please insert a number");
				return;
            }
			Console.ReadKey();
		}
	}
}