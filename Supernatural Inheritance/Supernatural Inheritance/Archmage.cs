using System;

namespace Supernatural_Inheritance
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title)
        {

        }

        public Archmage(string title, string origin) : base(title, origin)
        {

        }

        public override string CastWindStorm()
        {
            Storm storm = new Storm("Wind", true, Title);
            string strength = SpellStrength(storm.IsStrong);

            return $"{storm.Caster} cast a {strength} {storm.Type} storm";
        }

        public override string CastRainStorm()
        {
            Storm storm = new Storm("Rain", true, Title);
            string strength = SpellStrength(storm.IsStrong);
            return $"{storm.Caster} cast a {strength} {storm.Type} storm";
        }

        public string CastLightningStorm()
        {
            Storm storm = new Storm("Lightning", false, Title);
            string strength = SpellStrength(storm.IsStrong);
            return $"{storm.Caster} cast a {strength} {storm.Type} storm";
        }
    }
}
