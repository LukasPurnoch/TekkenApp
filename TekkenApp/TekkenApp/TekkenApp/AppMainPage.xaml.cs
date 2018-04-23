﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TekkenApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppMainPage : ContentPage
	{
        List<Profile.Profile> Characters = new List<Profile.Profile>();

		public AppMainPage ()
		{
			InitializeComponent ();

            ChacterShow();
        }

        private void ChacterShow()
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
            Characters.Add(new Profile.Profile() { Name = "Jin Kazama", FightingStyle = "Karate", Origin = "Japan", Source = "ImgResources/JinKazama.png" });
            Characters.Add(new Profile.Profile() { Name = "Sergei Dragunov", FightingStyle = "Command Sambo", Origin = "Russia", Source = "ImgResources/SergeiDragunov.png" });
            Characters.Add(new Profile.Profile() { Name = "Shaheen", FightingStyle = "Military Fighting Style", Origin = "Saudi Arabia", Source = "ImgResources/Shaheen.png" });
            Characters.Add(new Profile.Profile() { Name = "Steve Fox", FightingStyle = "Box", Origin = "UK", Source = "ImgResources/SteveFox.png" });
            Characters.Add(new Profile.Profile() { Name = "Yoshimitsu", FightingStyle = "Advanced Manji Ninjutsu", Origin = "Japan", Source = "ImgResources/Yoshimitsu.png" });

            ListViewUser.ItemsSource = Characters;
        }

        private void SelectedCharacter(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new ProfilePage(e.Item as Profile.Profile));
            ListViewUser.SelectedItem = null;
        }
    }
}