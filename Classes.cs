using System;

namespace VendingMachine
{
	public abstract class Item
	{
		public string Name;
		public float Price;
	}

	public class Food : Item
	{
		public int GrossWeight;

		public Food(string n, float p, int gw)
		{
			Name = n;
			Price = p;
			GrossWeight = gw;
		}

		public void Eat()
		{
			GrossWeight = 0;
		}
	}

	public class Perishable : Food
	{
		public int ExpiryMonth;
		public int ExpiryYear;

		public Perishable(string n, float p, int gw, int em, int ey) : base(n, p, gw)
		{
			ExpiryMonth = em;
			ExpiryYear = ey;
		}
	}

	public class NonPerishable : Food
	{
		public int NetWeight;

		public NonPerishable(string n, float p, int gw, int nw) : base(n, p, gw)
		{
			NetWeight = nw;
		}
	}

	//----------------------------------------------------------//
	// Use the Food classes as an example to complete Clothing,
	// Safety and Casual.  Hint:  Think about inheritence
	//----------------------------------------------------------//
	public class Clothing : Item
	{
		public String Size;
		public bool Used;


		public Clothing(string n, float p, string s, bool used)
		{
			Size = s;
			Used = used;
		}


		public Clothing(string name, float price, string size)
		{
			Name = name;
			Price = price;
			Size = size;
		}

		public void Wear()
		{
			Used = true;
		}

	}
}