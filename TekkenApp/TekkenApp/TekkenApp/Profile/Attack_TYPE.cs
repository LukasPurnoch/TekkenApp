using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TekkenApp.Profile
{
    public class Attack_TYPE
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string InAlph { get; set; }
        public string Damage { get; set; }
        public string HitLevel { get; set; }
        public string Block { get; set; }
        public string Hit { get; set; }
        public string Counter { get; set; }
        public string Speed { get; set; }
        public string Video { get; set; }
        public string SpecialProperty { get; set; }
    }
}
