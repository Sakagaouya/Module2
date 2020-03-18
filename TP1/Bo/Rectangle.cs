﻿using System;

namespace TP1
{
    public class Rectangle : Forme
    {
        public virtual int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double Aire => Largeur * Longueur;

        public override double Perimetre => 2 * Largeur + 2 * Longueur;
        public override string ToString()
        {
            return ToString(false);
        }

        protected string ToString(bool isCarre)
        {
            if (isCarre)
                return base.ToString();
            return $"Rectangle de longueur={Longueur} et largeur={Largeur}" + Environment.NewLine + base.ToString();
        }

    }
}