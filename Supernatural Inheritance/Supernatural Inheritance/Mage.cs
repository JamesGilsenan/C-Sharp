using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supernatural_Inheritance
{
    class Mage : Pupil
    {
        public Mage(string title) : base(title)
        {

        }

        public Mage(string title, string origin) : base(title, origin)
        {

        }

        public virtual string CastRainStorm()
        {
            Storm storm = new Storm("Rain", false, Title);
            string strength = SpellStrength(storm.IsStrong);
            return $"{storm.Caster} cast a {strength} {storm.Type} storm";
        }
    }
}