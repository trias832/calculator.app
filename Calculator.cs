class Calculator
{
	static void main (string[] args)
	{
		int a=10;
		int b=6;
		Consule.WriteLine("Hasil Penambahan: {0}+{1}={2}", a, b, Penambahan(a, b));
		Consule.WriteLine("Hasi Pengurangan: {0}-{1}={2}", a,b, Pengurangan(a, b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.RedKey);
		}
		static int Penambahan(int a, int b)
		{
			return a+b;
		}
		static int Pengurangan(int a, int b)
		{
			return a-b;
		}
	}