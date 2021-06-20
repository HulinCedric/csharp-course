using System;

namespace Exercice1
{
	public class Machine
	{
		private string nom;
		private float temperature;
		private float seuilLimiteTemperature;
		
		public delegate void SurchauffeEventHandler(object sender, SurchauffeEventArgs e);
		public event SurchauffeEventHandler Surchauffe;
		
		public Machine()
		{
			nom= "Default";
			temperature= 0.0f;
			seuilLimiteTemperature= 0.0f;
		}
		
		public Machine(string nom, float temperature, float seuilLimiteTemperature)
		{
			this.nom= nom;
			this.temperature= temperature;
			this.seuilLimiteTemperature= seuilLimiteTemperature;
		}
		
		public string Nom
		{
			get { return nom; }
			set { nom= value; }
		}
		
		public float Temperature
		{
			get { return temperature; }
			set 
			{ 
				temperature= value;
				
				if (temperature > seuilLimiteTemperature)
					OnSurchauffe(nom, temperature, seuilLimiteTemperature);
			}
		}
		
		public float SeuilLimiteTemperature
		{
			get { return seuilLimiteTemperature; }
			set { seuilLimiteTemperature= value; }
		}
		
		public void OnSurchauffe(string nom, float temperature, float seuilLimiteTemperature)
        {
            if (Surchauffe != null)
                Surchauffe(this, new SurchauffeEventArgs(nom, temperature, seuilLimiteTemperature));
        }
	}
}