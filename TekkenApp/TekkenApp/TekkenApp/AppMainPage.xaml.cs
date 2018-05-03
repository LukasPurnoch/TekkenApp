using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace TekkenApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppMainPage : ContentPage
	{
        List<Profile.Profile> Characters = new List<Profile.Profile>();

        Database.Database_Connection database = new Database.Database_Connection("Movelist_Alisa.db3");

		public AppMainPage ()
		{
			InitializeComponent ();

            CharacterShow();
            Save();
            
        }

        private async void Save()
        {
            /*
            
            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Rage Art", Picture = "MoveList/CharactersMoves/Alisa/Alisa_1.png", InAlph = "b, 1+2", Damage = "55", HitLevel = "M",
            Block = "+1", Hit = "KND", Counter = "KND", Speed = "13", Video = "MoveList/CharactersMoves/Alisa/Alisa_1.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Rage Drive", Picture = "MoveList/CharactersMoves/Alisa/Alisa_2.png", InAlph = "f+2+3", Damage = "55", HitLevel = "M",
            Block = "-1", Hit = "0", Counter = "0", Speed = "10", Video = "MoveList/CharactersMoves/Alisa/Alisa_2.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Stop Bit", Picture = "MoveList/CharactersMoves/Alisa/Alisa_3.png", InAlph = "1, 1", Damage = "7, 18", HitLevel = "H, H",
            Block = "-3", Hit = "+5", Counter = "KND", Speed = "10", Video = "MoveList/CharactersMoves/Alisa/Alisa_3.mp4", SpecialProperty = "None"};
            
            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Stop Bit to Destructive Form", Picture = "MoveList/CharactersMoves/Alisa/Alisa_4.png", InAlph = "1, 1, 1+2", Damage = "7, 18", HitLevel = "H, H",
            Block = "-3", Hit = "+5", Counter = "KND", Speed = "10", Video = "MoveList/CharactersMoves/Alisa/Alisa_4.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Coil Punch Combo", Picture = "MoveList/CharactersMoves/Alisa/Alisa_5.png", InAlph = "1, 2, 2", Damage = "7, 10, 17", HitLevel = "H, H, L",
            Block = "-11~-10", Hit = "+2~+3", Counter = "KND", Speed = "10", Video = "MoveList/CharactersMoves/Alisa/Alisa_5.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Accelerator Combo", Picture = "MoveList/CharactersMoves/Alisa/Alisa_6.png", InAlph = "1, 2, 4", Damage = "7, 10, 21" HitLevel = "H, H, H",
            Block = "-5~-4", Hit = "KND", Counter = "KND", Speed = "10", Video = "MoveList/CharactersMoves/Alisa/Alisa_6.mp4", SpecialProperty = "Tailspin"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Down Time", Picture = "MoveList/CharactersMoves/Alisa/Alisa_7.png", InAlph = "2, 3, 3", Damage = "7, 10, 20" HitLevel = "H, M, M",
            Block = "-11~-9", Hit = "KND", Counter = "KND", Speed = "12a", Video = "MoveList/CharactersMoves/Alisa/Alisa_7.mp4", SpecialProperty = "Tailspin"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Down Link", Picture = "MoveList/CharactersMoves/Alisa/Alisa_8.png", InAlph = "2, 3, 4", Damage = "7, 10, 20" HitLevel = "H, M, L",
            Block = "-19~-16", Hit = "KND", Counter = "KND", Speed = "js24~", Video = "MoveList/CharactersMoves/Alisa/Alisa_8.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Right Jab to Accelerator", Picture = "MoveList/CharactersMoves/Alisa/Alisa_9.png", InAlph = "2, 4", Damage = "10, 21" HitLevel = "H, H",
            Block = "-5~-4", Hit = "KND", Counter = "KND", Speed = "24~", Video = "MoveList/CharactersMoves/Alisa/Alisa_9.mp4", SpecialProperty = "Tailspin"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Quick Access", Picture = "MoveList/CharactersMoves/Alisa/Alisa_10.png", InAlph = "3, 2", Damage = "12,4*5" HitLevel = "M, M x 5 (DES)",
            Block = "-9", Hit = "+1", Counter = "+1", Speed = "14~15", Video = "MoveList/CharactersMoves/Alisa/Alisa_10.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Accelerator", Picture = "MoveList/CharactersMoves/Alisa/Alisa_11.png", InAlph = "4", Damage = "24" HitLevel = "H",
            Block = "-5~-4", Hit = "KND", Counter = "KND", Speed = "13~14", Video = "MoveList/CharactersMoves/Alisa/Alisa_11.mp4", SpecialProperty = "Tailspin, Homing"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Gigabyte Hammer", Picture = "MoveList/CharactersMoves/Alisa/Alisa_12.png", InAlph = "1+2", Damage = "21" HitLevel = "M (TJ)",
            Block = "-5~-4", Hit = "KND", Counter = "KND", Speed = "33~34 js7~", Video = "MoveList/CharactersMoves/Alisa/Alisa_12.mp4", SpecialProperty = "None"};

            */

            //await database.SaveAttack(save);

            //Database.Database_Access ac = new Database.Database_Access();
            //ac.FindDB();
        }

        private void CharacterShow()
        {
            Characters.Add(new Profile.Profile() { Name = "Alisa Bosconovitch", FightingStyle = "High Mobility Combat", Origin = "Russia", Source = "ImgResources/AlisaBosconovitch.png" });
            Characters.Add(new Profile.Profile() { Name = "Asuka Kazama", FightingStyle = "Kazama Traditional Martial Art", Origin = "Japan", Source = "ImgResources/AsukaKazama.png" });
            Characters.Add(new Profile.Profile() { Name = "'Bob' Robert Richards", FightingStyle = "Freestyle Karate", Origin = "USA", Source = "ImgResources/RobertRichards.png" });
            Characters.Add(new Profile.Profile() { Name = "Bryan Fury", FightingStyle = "Kickbox", Origin = "USA", Source = "ImgResources/BryanFury.png" });
            Characters.Add(new Profile.Profile() { Name = "Claudio Serafino", FightingStyle = "Sirius Exorcism Sorcery", Origin = "Italy", Source = "ImgResources/ClaudioSerafino.png" });
            Characters.Add(new Profile.Profile() { Name = "Devil Jin", FightingStyle = "Unknown", Origin = "Unknown", Source = "ImgResources/DevilJin.png" });
            Characters.Add(new Profile.Profile() { Name = "Eddy Gordo", FightingStyle = "Capoeira", Origin = "Brazil", Source = "ImgResources/EddyGordo.png" });
            Characters.Add(new Profile.Profile() { Name = "Feng Wei", FightingStyle = "God Fist Martial Art", Origin = "China", Source = "ImgResources/FengWei.png" });
            Characters.Add(new Profile.Profile() { Name = "Gigas", FightingStyle = "Destructive Impulse", Origin = "Data Deleted (Unknown)", Source = "ImgResources/Gigas.png" });
            Characters.Add(new Profile.Profile() { Name = "Heihachi Mishima", FightingStyle = "Mishima Fighting Karate", Origin = "Japan", Source = "ImgResources/HeihachiMishima.png" });
            Characters.Add(new Profile.Profile() { Name = "Hwoarang", FightingStyle = "Taekwondo", Origin = "South Korea", Source = "ImgResources/Hwoarang.png" });
            Characters.Add(new Profile.Profile() { Name = "Jack", FightingStyle = "Brute Force", Origin = "Russia / Unknown", Source = "ImgResources/Jack.png" });
            Characters.Add(new Profile.Profile() { Name = "Jin Kazama", FightingStyle = "Karate", Origin = "Japan", Source = "ImgResources/JinKazama.png" });
            Characters.Add(new Profile.Profile() { Name = "Josie Rizal", FightingStyle = "Eskrima Based Kickbox", Origin = "Philippines", Source = "ImgResources/JosieRizal.png" });
            Characters.Add(new Profile.Profile() { Name = "Katarina Alves", FightingStyle = "Savate", Origin = "Brazi", Source = "ImgResources/KatarinaAlves.png" });
            Characters.Add(new Profile.Profile() { Name = "Kazumi Mishima", FightingStyle = "Hachijo Style Karate", Origin = "Japan", Source = "ImgResources/KazumiMishima.png" });
            Characters.Add(new Profile.Profile() { Name = "Kazuya", FightingStyle = "Mishima Fighting Karate", Origin = "Japan", Source = "ImgResources/Kazuya.png" });
            Characters.Add(new Profile.Profile() { Name = "Kuma", FightingStyle = "Heihachi Kuma Shinken", Origin = "Japan", Source = "ImgResources/Kuma.png" });
            Characters.Add(new Profile.Profile() { Name = "King", FightingStyle = "Pro-Wrestler", Origin = "Mexico", Source = "ImgResources/King.png" });
            Characters.Add(new Profile.Profile() { Name = "Lars Alexandersson", FightingStyle = "Karate, Tekken Forces", Origin = "Sweden", Source = "ImgResources/LarsAlexandersson.png" });
            Characters.Add(new Profile.Profile() { Name = "Law Marshall", FightingStyle = "Jeet Kune Do", Origin = "USA", Source = "ImgResources/LawMarshall.png" });
            Characters.Add(new Profile.Profile() { Name = "Lee Chaolan", FightingStyle = "Mishima Fighting Karate", Origin = "China (From Birth) / Japan", Source = "ImgResources/LeeChaolan.png" });
            Characters.Add(new Profile.Profile() { Name = "Leo Kliesen", FightingStyle = "Baji Quan", Origin = "Germany", Source = "ImgResources/LeoKliesen.png" });
            Characters.Add(new Profile.Profile() { Name = "Miguel Caballero Rojo", FightingStyle = "None (Brawling)", Origin = "Spain", Source = "ImgResources/MiguelCaballeroRojo.png" });
            Characters.Add(new Profile.Profile() { Name = "Nina Williams", FightingStyle = "Aikido, Koppojutsu", Origin = "Ireland", Source = "ImgResources/NinaWilliams.png" });
            Characters.Add(new Profile.Profile() { Name = "Emilie 'Lili' de Rochefort", FightingStyle = "Self-Taught", Origin = "Monaco", Source = "ImgResources/LiliRochefort.png" });
            Characters.Add(new Profile.Profile() { Name = "Ling Xiaoxu", FightingStyle = "Baguazhanq and Piguaquan", Origin = "China", Source = "ImgResources/LingXiaoxu.png" });
            Characters.Add(new Profile.Profile() { Name = "Lucky Chloe", FightingStyle = "Freestyle Dance, Acrobatics", Origin = "Secret", Source = "ImgResources/LuckyChloe.png" });
            Characters.Add(new Profile.Profile() { Name = "Panda", FightingStyle = "Improved Kuma Shinken", Origin = "Japan", Source = "ImgResources/Panda.png" });
            Characters.Add(new Profile.Profile() { Name = "Paul Phoenix", FightingStyle = "Modified Judo", Origin = "USA", Source = "ImgResources/PaulPhoenix.png" });
            Characters.Add(new Profile.Profile() { Name = "Raven", FightingStyle = "Ninjutsu", Origin = "Unknown", Source = "ImgResources/Raven.png" });
            Characters.Add(new Profile.Profile() { Name = "Sergei Dragunov", FightingStyle = "Command Sambo", Origin = "Russia", Source = "ImgResources/SergeiDragunov.png" });
            Characters.Add(new Profile.Profile() { Name = "Shaheen", FightingStyle = "Military Fighting Style", Origin = "Saudi Arabia", Source = "ImgResources/Shaheen.png" });
            Characters.Add(new Profile.Profile() { Name = "Steve Fox", FightingStyle = "Box", Origin = "UK", Source = "ImgResources/SteveFox.png" });
            Characters.Add(new Profile.Profile() { Name = "Yoshimitsu", FightingStyle = "Advanced Manji Ninjutsu", Origin = "Japan", Source = "ImgResources/Yoshimitsu.png" });

            ListViewUser.ItemsSource = Characters;
        }

        private void SelectedCharacter(object sender, ItemTappedEventArgs e)
        {
            

            int index = (ListViewUser.ItemsSource as List<Profile.Profile>).IndexOf(e.Item as Profile.Profile);
            Navigation.PushModalAsync(new ProfilePage(index));
            
            //DisplayAlert(index.ToString(), "message", "cancel");
            //ListViewUser.SelectedItem = null;
        }
    }
}