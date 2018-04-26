using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TekkenApp.CharactersMoves
{
    public class Alisa
    {
        public int adding = 3;

        List<Profile.Attack_TYPE> MoveList_List = new List<Profile.Attack_TYPE>();

        public void AlisaMoves(ListView list)
        {
            MoveList_List.Add(new Profile.Attack_TYPE()
            {
                Name = "Stop Bit",
                Picture = "MoveList/CharactersMoves/Alisa/Alisa_" + adding + ".png",
                InAlph = "1, 1",
                Damage = "7, 18",
                HitLevel = "H, H",
                Block = "-3",
                Hit = "+5",
                Counter = "KND",
                Speed = "10",
                Video = "MoveList/CharactersMoves/Alisa/Alisa_" + adding + ".mp4"
            });

            list.ItemsSource = MoveList_List;
        }
    }
}
