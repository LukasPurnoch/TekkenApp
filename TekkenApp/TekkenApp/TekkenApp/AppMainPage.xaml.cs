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

        public AppMainPage()
        {
            InitializeComponent();

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

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Dual Session", Picture = "MoveList/CharactersMoves/Alisa/Alisa_13.png", InAlph = "f+2, 1", Damage = "12, 20" HitLevel = "M, M (DES)",
            Block = "-20~-19", Hit = "CS", Counter = "CS", Speed = "17~18", Video = "MoveList/CharactersMoves/Alisa/Alisa_13.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Session to Destructive", Picture = "MoveList/CharactersMoves/Alisa/Alisa_14.png", InAlph = "f+2, 1+2", Damage = "12" HitLevel = "M (DES)",
            Block = "-4~-3", Hit = "+7~+8", Counter = "+7~+8", Speed = "17~18", Video = "MoveList/CharactersMoves/Alisa/Alisa_14.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Triple Session", Picture = "MoveList/CharactersMoves/Alisa/Alisa_15.png", InAlph = "f+2, 3, 3", Damage = "12, 8, 20" HitLevel = "M, H (TJ), M",
            Block = "-10~-9", Hit = "ED", Counter = "ED", Speed = "js1~12", Video = "MoveList/CharactersMoves/Alisa/Alisa_15.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Lost Access", Picture = "MoveList/CharactersMoves/Alisa/Alisa_16.png", InAlph = "f+3, 2", Damage = "13, 20" HitLevel = "M, H (DES)",
            Block = "-4~-2", Hit = "KND", Counter = "KND", Speed = "14~15", Video = "MoveList/CharactersMoves/Alisa/Alisa_16.mp4", SpecialProperty = "Tailspin"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Automatic Transmission", Picture = "MoveList/CharactersMoves/Alisa/Alisa_17.png", InAlph = "f+3, 1+2", Damage = "13, 25" HitLevel = "H, M (DES)",
            Block = "-13~-12", Hit = "CS", Counter = "CS", Speed = "14~15", Video = "MoveList/CharactersMoves/Alisa/Alisa_17.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Logic Bomb", Picture = "MoveList/CharactersMoves/Alisa/Alisa_18.png", InAlph = "f+4, 1, 4", Damage = "14, 14, 24" HitLevel = "M, H , M",
            Block = "-14~+12(-12)", Hit = "KND", Counter = "KND", Speed = "16", Video = "MoveList/CharactersMoves/Alisa/Alisa_18.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Overflow", Picture = "MoveList/CharactersMoves/Alisa/Alisa_19.png", InAlph = "f+1+2", Damage = "25" HitLevel = "M",
            Block = "-12~-11", Hit = "+7~+8", Counter = "+7~+8", Speed = "14~15", Video = "MoveList/CharactersMoves/Alisa/Alisa_19.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Overflow to Boot", Picture = "MoveList/CharactersMoves/Alisa/Alisa_20.png", InAlph = "f+1+2, 3+4", Damage = "25" HitLevel = "M (SPECIAL)(TJ)(SBT)",
            Block = "-16~-15", Hit = "+3~+4", Counter = "+3~+4", Speed = "14~15a", Video = "MoveList/CharactersMoves/Alisa/Alisa_20.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Overflow to Dual Boot", Picture = "MoveList/CharactersMoves/Alisa/Alisa_21.png", InAlph = "f+1+2, f+3+4", Damage = "25" HitLevel = "M (SPECIAL)(TJ)(DBT)",
            Block = "-16~-15", Hit = "+3~+4", Counter = "+3~+4", Speed = "14~15a", Video = "MoveList/CharactersMoves/Alisa/Alisa_21.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Boot", Picture = "MoveList/CharactersMoves/Alisa/Alisa_22.png", InAlph = "f+3+4", Damage = "0" HitLevel = "0",
            Block = "0", Hit = "0", Counter = "0", Speed = "x", Video = "MoveList/CharactersMoves/Alisa/Alisa_22.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Abort", Picture = "MoveList/CharactersMoves/Alisa/Alisa_23.png", InAlph = "d  /  b", Damage = "0" HitLevel = "0",
            Block = "0", Hit = "0", Counter = "0", Speed = "0", Video = "MoveList/CharactersMoves/Alisa/Alisa_23.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Hard Reset", Picture = "MoveList/CharactersMoves/Alisa/Alisa_24.png", InAlph = "SBT 1, 2, 1, 3+4", Damage = "12, 13, 7, 5, 28" HitLevel = "M, M, M, MM",
            Block = "-18", Hit = "KND", Counter = "KND", Speed = "js1~", Video = "MoveList/CharactersMoves/Alisa/Alisa_24.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Hard Reset to Destructive", Picture = "MoveList/CharactersMoves/Alisa/Alisa_25.png", InAlph = "SBT 1, 2, 1, 3+4, 1+2", Damage = "12, 13, 7, 5, 28" HitLevel = "M, M, M, MM (DES)",
            Block = "-18~-17", Hit = "KND", Counter = "KND", Speed = "js1~", Video = "MoveList/CharactersMoves/Alisa/Alisa_25.mp4", SpecialProperty = "None"};
            
            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Linear Elbow", Picture = "MoveList/CharactersMoves/Alisa/Alisa_26.png", InAlph = "SBT+2", Damage = "25" HitLevel = "M",
            Block = "-8~+3", Hit = "KND", Counter = "KND", Speed = "16~27(41~)js1~", Video = "MoveList/CharactersMoves/Alisa/Alisa_26.mp4", SpecialProperty = "None"};
            
            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Linear Elbow to Destructive", Picture = "MoveList/CharactersMoves/Alisa/Alisa_27.png", InAlph = "SBT+2, 1+2", Damage = "25" HitLevel = "M (DES)",
            Block = "-8~+3", Hit = "KND", Counter = "KND", Speed = "16~27(41~)js1~", Video = "MoveList/CharactersMoves/Alisa/Alisa_27.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Eject Slider", Picture = "MoveList/CharactersMoves/Alisa/Alisa_28.png", InAlph = "SBT+3", Damage = "17" HitLevel = "L",
            Block = "-14~-10", Hit = "+4~+8s", Counter = "KND", Speed = "16~20s(41~)js1~cs9~", Video = "MoveList/CharactersMoves/Alisa/Alisa_28.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Upstream", Picture = "MoveList/CharactersMoves/Alisa/Alisa_29.png", InAlph = "SBT+4", Damage = "22" HitLevel = "M",
            Block = "-27~-26", Hit = "Launch", Counter = "Launch", Speed = "18~19s(43~)js1~", Video = "MoveList/CharactersMoves/Alisa/Alisa_29.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Cyclone Mixer", Picture = "MoveList/CharactersMoves/Alisa/Alisa_30.png", InAlph = "d/f+1, 1, 2", Damage = "10, 20, 4*7" HitLevel = "M, H, H x 7 (DES) ",
            Block = "+6", Hit = "+8", Counter = "+8", Speed = "13", Video = "MoveList/CharactersMoves/Alisa/Alisa_30.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Eject Slider", Picture = "MoveList/CharactersMoves/Alisa/Alisa_31.png", InAlph = "d/f+1, 4", Damage = "10, 17" HitLevel = "M, M",
            Block = "-9~-8", Hit = "+5~+6s", Counter = "KND", Speed = "13", Video = "MoveList/CharactersMoves/Alisa/Alisa_31.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Pickup", Picture = "MoveList/CharactersMoves/Alisa/Alisa_32.png", InAlph = "d/f+2", Damage = "16" HitLevel = "M",
            Block = "-9~-8", Hit = "Launch (JG?)(+7)", Counter = "Launch (JG?)", Speed = "16-17", Video = "MoveList/CharactersMoves/Alisa/Alisa_32.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Double Socket", Picture = "MoveList/CharactersMoves/Alisa/Alisa_33.png", InAlph = "d/f+3, 3", Damage = "14, 17" HitLevel = "M, L",
            Block = "-12~-11", Hit = "+1~+2", Counter = "KND", Speed = "16", Video = "MoveList/CharactersMoves/Alisa/Alisa_33.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Transmission", Picture = "MoveList/CharactersMoves/Alisa/Alisa_34.png", InAlph = "d/f+1+2", Damage = "25" HitLevel = "M (DES)",
            Block = "-11~-10", Hit = "CS", Counter = "CS", Speed = "18-19", Video = "MoveList/CharactersMoves/Alisa/Alisa_34.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Deadlock", Picture = "MoveList/CharactersMoves/Alisa/Alisa_35.png", InAlph = "d+2, 4", Damage = "17, 24" HitLevel = "M, M",
            Block = "-13~-10", Hit = "KND", Counter = "KND", Speed = "24~26a", Video = "MoveList/CharactersMoves/Alisa/Alisa_35.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Deadlock to Destructive", Picture = "MoveList/CharactersMoves/Alisa/Alisa_36.png", InAlph = "d+2, 4, 1+2", Damage = "17, 24" HitLevel = "M, M, (DES)",
            Block = "-13~-10", Hit = "KND", Counter = "KND", Speed = "24~26a", Video = "MoveList/CharactersMoves/Alisa/Alisa_36.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Quick Slider", Picture = "MoveList/CharactersMoves/Alisa/Alisa_37.png", InAlph = "d+3", Damage = "17" HitLevel = "L (TJ), (SPECIAL), TC)",
            Block = "-10~-1", Hit = "+8~+17", Counter = "KND", Speed = "23~32s js9~", Video = "MoveList/CharactersMoves/Alisa/Alisa_37.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Optimizer", Picture = "MoveList/CharactersMoves/Alisa/Alisa_38.png", InAlph = "D+4, 1+2", Damage = "15, 20" HitLevel = "L, H",
            Block = "-1~0", Hit = "KND", Counter = "KND", Speed = "17~18", Video = "MoveList/CharactersMoves/Alisa/Alisa_38.mp4", SpecialProperty = "Tailspin"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Harpoon Sweep", Picture = "MoveList/CharactersMoves/Alisa/Alisa_39.png", InAlph = "d+3+4", Damage = "20" HitLevel = "L (TJ)",
            Block = "-37", Hit = "KND", Counter = "KND", Speed = "27~28 js5~ cs20~", Video = "MoveList/CharactersMoves/Alisa/Alisa_39.mp4", SpecialProperty = "Homing"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Harpoon Sweep to Destructive", Picture = "MoveList/CharactersMoves/Alisa/Alisa_40.png", InAlph = "d+3+4, 1+2", Damage = "20" HitLevel = "L (TJ)",
            Block = "-37", Hit = "KND", Counter = "KND", Speed = "27~28 js5~ cs20~", Video = "MoveList/CharactersMoves/Alisa/Alisa_40.mp4", SpecialProperty = "Homing"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Backup", Picture = "MoveList/CharactersMoves/Alisa/Alisa_41.png", InAlph = "d/b", Damage = "0" HitLevel = "None",
            Block = "0", Hit = "0", Counter = "0", Speed = "x", Video = "MoveList/CharactersMoves/Alisa/Alisa_41.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Recovery Hook", Picture = "MoveList/CharactersMoves/Alisa/Alisa_42.png", InAlph = "d/b+1~1]", Damage = "31" HitLevel = "H",
            Block = "+4~+6", Hit = "KMED", Counter = "KMED", Speed = "11~13", Video = "MoveList/CharactersMoves/Alisa/Alisa_42.mp4", SpecialProperty = "Tailspin"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Rocket Punch", Picture = "MoveList/CharactersMoves/Alisa/Alisa_43.png", InAlph = "d/b+1~2]", Damage = "20" HitLevel = "H",
            Block = "KND", Hit = "KND", Counter = "KND", Speed = "34~75", Video = "MoveList/CharactersMoves/Alisa/Alisa_43.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Meteor Kick", Picture = "MoveList/CharactersMoves/Alisa/Alisa_44.png", InAlph = "d/b+1~3]", Damage = "30" HitLevel = "M (TJ)",
            Block = "-10~-7", Hit = "KND", Counter = "KND", Speed = "24~27(39~) js15~", Video = "MoveList/CharactersMoves/Alisa/Alisa_44.mp4", SpecialProperty = "None"};

            Profile.Attack_TYPE save = new Profile.Attack_TYPE() { Name = "Uplink Knee", Picture = "MoveList/CharactersMoves/Alisa/Alisa_45.png", InAlph = "d/b+1~4]", Damage = "30" HitLevel = "M",
            Block = "-9~-4", Hit = "Launch", Counter = "Launch", Speed = "18~23(33~) js17~", Video = "MoveList/CharactersMoves/Alisa/Alisa_45.mp4", SpecialProperty = "None"};

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