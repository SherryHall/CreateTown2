﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTown2
{
	abstract class Building
	{
		public string BuildingType { get; set; }
		public string Name { get; set; }
		public string ConstructionMaterial { get; set; }
		//DEBUG still need to make this read-only
		public int CurrentOccupants { get; set; }

		public int BathRooms { get; set; }
		public int Floors { get; set; }
		public int NumberOfRoom { get; set; }

		public double Height { get; set; }
		public double Length { get; set; }
		public double Width { get; set; }
		public double SquareFootage { get { return (Length * Width); } }
		public double Volume { get { return (SquareFootage * Height); } }

		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public int Zip { get; set; }
		public string FullAddress
		{
			get { return string.Format("{0}, {1}, {2}, {3}, {4}", Address1, Address2, City, State, Zip); }
		}


		public Building(string name, string constructionMaterial, int currentOccupants, int bathRooms, int floors, int numberOfRoom, double length, double width, double height, string address1, string address2, string city, string state, int zip)
		{
			this.Name = name;
			this.ConstructionMaterial = constructionMaterial;
			this.BathRooms = bathRooms;
			this.Floors = floors;
			this.NumberOfRoom = numberOfRoom;
			this.Length = length;
			this.Height = height;
			this.Width = width;
			this.Address1 = address1;
			this.Address2 = address2;
			this.City = city;
			this.State = state;
			this.Zip = zip;
		}

		public int DecreaseOccupants()
		{
			return CurrentOccupants--;
		}


		public int IncreaseOccupants()
		{
			//return CurrentOccupants++;
			return CurrentOccupants++;
		}

		public string DisplayName()
		{
			return this.Name;
		}

		public override string ToString()
		{
			return $"{BuildingType} : {Name}";
		}
	}
}
