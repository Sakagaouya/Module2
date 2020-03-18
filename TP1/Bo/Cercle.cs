using System;

namespace TP1
{
    public class Cercle : Forme
    {
        /*
         * private int rayon;

		public int Rayon
		{
			get { return rayon; }
			set { rayon = value; }
		}

		public override double Aire => Math.PI * Math.Pow(Rayon,2);

		public override double Perimetre
		{
			get { return 2 * Math.PI * Rayon; }
		}
        */
        public int Rayon { get; set; }

        public override double Aire => Math.PI * Rayon * Rayon;

        public override double Perimetre => 2 * Math.PI * Rayon;

        public override string ToString()
        {
            return $"Cercle de rayon {Rayon}" + Environment.NewLine + base.ToString();
        }
    }
}