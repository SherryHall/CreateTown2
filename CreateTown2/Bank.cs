using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTown2
{
	class Bank : Building
	{
		private double AmountOfMoney;

		public Bank(string name, string constructionMaterial, int currentOccupants, int bathRooms, int floors, int numberOfRoom, double length, double width, double height, string address1, string address2, string city, string state, int zip)
			: base(name, constructionMaterial, currentOccupants, bathRooms, floors, numberOfRoom, length, width, height, address1, address2, city, state, zip)
		{
			this.BuildingType = "Bank";
		}
		public void DepositMoney(double depositAmt)
		{
			AmountOfMoney += depositAmt;
		}

		public void WithdrawMoney(double withdrawAmt)
		{
			AmountOfMoney -= withdrawAmt;
		}

		public double GetBalance()
		{
			return AmountOfMoney;
		}

	}
}
