using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTown2
{
	class House : Building
	{
		public int BedRooms { get; set; }

		public House(string name, string constructionMaterial, int currentOccupants, int bathRooms, int bedRooms, int floors, int numberOfRoom, double length, double width, double height, string address1, string address2, string city, string state, int zip)
			:base (name, constructionMaterial, currentOccupants, bathRooms, floors, numberOfRoom, length, width, height, address1, address2, city, state, zip)
		{
			this.BuildingType = "House";
			this.BedRooms = bedRooms;
		}
	}
}
