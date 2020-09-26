using System;

namespace Supernatural_Inheritance
{
    class Pupil
    {
        public Pupil(string title)
        {
            this.Title = title;
        }

        public Pupil(string title, string origin)
        {
            this.Title = title;
            this.Origin = origin;
        }

        public string Title { get; private set; }
        public string Origin { get; private set; }

        public virtual string CastWindStorm()
        {
            Storm storm = new Storm("Wind", false, Title);
            string strength = SpellStrength(storm.IsStrong);
            
            return $"{storm.Caster} cast a {strength} {storm.Type} storm";
        }

        public string SpellStrength(bool isStrong)
        {
            if (isStrong == false)
                return "weak";
            else
                return "strong";
        }
    }
}
