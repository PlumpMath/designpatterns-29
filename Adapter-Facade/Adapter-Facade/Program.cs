using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_Facade
{
	class Program
	{
		static void Main(string[] args)
		{
			int visitors;

			visitors = 3; //Convert.ToInt32(args[0]);
			for (int count = 0; count < visitors - 1; count++)
			{
				if (count >= 1)
				{
					LargeAnimalShowCar newLACar = new LargeAnimalShowCar();
					BugsShowCar adaptedCar = new AdapterLargeAnimalToBugs(newLACar);
					adaptedCar.GetVisitor();
					adaptedCar.SecureDoors();
					adaptedCar.SetProtection();
					//adaptedCar.OpenCommChannel();
					//adaptedCar.SelectDestinationArea();
					//adaptedCar.StartEngine();
					//adaptedCar.WalkVisitorThroughLandscape();
				}
				else
				{
					BugsShowCar bugcar = new BugsShowCar();
					bugcar.GetVisitor();
					bugcar.SecureDoors();
					bugcar.SetProtection();
					//bugcar.OpenCommChannel();
					//bugcar.SelectDestinationArea();
					//bugcar.StartEngine();
					//bugcar.WalkVisitorThroughLandscape();
				}
			}
		}
	}
}
