using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTown2
{

	class School : Building
	{
		public int ClassRooms { get; set; }
		public bool InSession { get; set; }
		public int NumberOfStudents { get; set; }
		public int NumberOfTeachers { get; set; }

		public School(string name, string constructionMaterial, int currentOccupants, int bathRooms, int classRooms, int floors, int numberOfRoom, double length, double width, double height, string address1, string address2, string city, string state, int zip, int numberOfStudents, int numberOfTeachers)
			: base(name, constructionMaterial, currentOccupants, bathRooms, floors, numberOfRoom, length, width, height, address1, address2, city, state, zip)
		{
			this.BuildingType = "School";
			this.NumberOfStudents = numberOfStudents;
			this.NumberOfTeachers = numberOfTeachers;

		}
		public string TeacherStudentRatio()
		{
			// Get the greatest common divisor for number of teachers and number of students
			int Remainder;
			int a = NumberOfTeachers;
			int b = NumberOfStudents;

			while (b != 0)
			{
				Remainder = a % b;
				a = b;
				b = Remainder;
			}

			return string.Format("{0}:{1}", NumberOfTeachers / a, NumberOfStudents / a);
		}
	}
}
