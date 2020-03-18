using System;

namespace TP1
{
        public class Carre : Rectangle
        {
        /*
         * public override int Largeur
		{
			get { return this.Longueur; }
		}
        */
            public override int Largeur => Longueur;

            public override string ToString()
            {
                return $"Carré de coté={Longueur}" + Environment.NewLine + base.ToString(true);
         /*
           StringBuilder builder = new StringBuilder();
			builder.Append("Carré de côté = ");
			builder.Append(Longueur);
			Console.WriteLine(builder.ToString());

			Console.WriteLine(String.Format("Carré de côté = {0} \n {1}", Longueur, base.ToString()));

			Console.WriteLine($"Carré de côté = {Longueur} \n {base.ToString()}");
            

			return "Carré de côté = " + Longueur + "\n" + base.ToString();
            */
        }
        }    
}