using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Adapter_Facade
{
	public class AdapterLargeAnimalToBugs : BugsShowCar
	{
		LargeAnimalShowCar LACar;

		public AdapterLargeAnimalToBugs(LargeAnimalShowCar LACar)
		{
			this.LACar = LACar;
		}

		public void SetProtection()
		{
			string operation = "Raise protective vail!";
			LACar.SetProtection();
			MessageBox.Show(operation);
		}
	}

	public class ZooShowCar : ICarInterface
	{
		public void GetVisitor()
		{ 

		}

		public void SetProtection()
		{
			string operation = "Set tourist protection!";
			MessageBox.Show(operation);
		}

		public void SecureDoors()
		{
			string operation = "Doors secured.";
			MessageBox.Show(operation);
		}

		public void StartEngine()
		{
			string operation = "Engine start.";
			MessageBox.Show(operation);
		}

		public void OpenCommChannel()
		{
			string operation = "Comm channel opened.";
			MessageBox.Show(operation);
		}

		public void SelectDestinationArea()
		{
			string operation = "Destination area selected..";
			MessageBox.Show(operation);
		}

		public void WalkVisitorThroughLandscape()
		{
			string operation = "Walking visitors...";
			MessageBox.Show(operation);
		}
	}

	public class LargeAnimalShowCar : ZooShowCar
	{
		public void SetProtection()
		{
			string operation = "Raise Bars!"; 
			MessageBox.Show(operation);
		}
	}

	public class FowlShowCar : ZooShowCar
	{
		public void SetProtection()
		{
			string operation = "Raise protective roof!";
			MessageBox.Show(operation);
		}
	}

	public class BugsShowCar : ZooShowCar
	{
		public void SetProtection()
		{
			string operation = "Raise protective vail!";
			MessageBox.Show(operation);
		}
	}

	public interface ICarInterface
	{
		void GetVisitor();
		void SetProtection();
	}
}
