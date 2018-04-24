using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TekkenApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilePage : ContentPage
	{
        public int adding = 3;

        List<Profile.MoveList> MoveList_List = new List<Profile.MoveList>();

        public ProfilePage (Profile.Profile profile)
		{
			InitializeComponent ();

            Name.Text = profile.Name;
            FStyle.Text = profile.FightingStyle;
            Origin.Text = profile.Origin;
            Source.Source = profile.Source;

            StorySelect(profile.Name);

            CharactersMoves.Alisa alisa = new CharactersMoves.Alisa();
            alisa.AlisaMoves(MoveList);
		}

        private void BackBT(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AppMainPage());
        }

        private void SelectedMove(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new MovePage(e.Item as Profile.MoveList));
            MoveList.SelectedItem = null;
        }

        public void StorySelect(string Name)
        {
            if (Name == "Alisa Bosconovitch")
            {
                BaseStory.Text = "Unlike most robots, Alisa possesses emotions and acts more like a human than a robot. " +
                    "She is a very kind-hearted individual who speaks in a polite manner and is sensitive to others' feelings. " +
                    "Alisa can also appear rather childish, resembling Ling Xiaoyu characteristically. " +
                    "In Tekken: Blood Vengeance, it is shown that she is also very capable of deception, " +
                    "as well as being quick to make friends with anyone, even Panda.";
            }
            if (Name == "Asuka Kazama")
            {
                BaseStory.Text = "Asuka is surprisingly brash and arrogant. Although her profile states that she breaks up fights regularly, " +
                    "she seems to have no qualms about fighting and seemingly revels in it despite being beautiful. In her story" +
                    " mode, after defeating her target, Feng Wei, she decides to remain in the tournament in order to 'have fun'.";
            }
            if (Name == "'Bob' Robert Richards")
            {
                BaseStory.Text = "Bob is portrayed as likeable and charismatic with a strong sense of justice, usually using his fighting " +
                    "skills to help those in need. He is also quite cocky, appearing as a smooth talker and a bit of a ladies man. As Bob is " +
                    "fully confident in his abilities with his current figure, he is ironically far more insecure about losing weight than " +
                    "gaining it and his demeanor becomes far less enthusiastic when subject to weight loss.";
            }
            if (Name == "Bryan Fury")
            {
                BaseStory.Text = "Bryan is brutish, unfeeling, and overall psychotic. Throughout the entire Tekken series, it is clear that " +
                    "Bryan's motivation is nothing more than to create havoc and misery wherever he goes. His selfishness has been shown multiple " +
                    "times, like when he betrayed Doctor Bosconovitch and Yoshimitsu very shortly after Yoshimitsu saved him from death. Bryan barely " +
                    "talks and usually expresses his delight in watching others suffering through maniacal laughter and smirks.";
            }
            if (Name == "Claudio Serafino")
            {
                BaseStory.Text = "The Archers of Sirius are a group of exorcists who have been banishing supernatural entities from this world " +
                    "since ancient times. A highly secretive organization, its existence is unknown to the public. Although it is not known " +
                    "how their existence was revealed, the Archers of Sirius were suddenly approached by the Mishima Zaibatsu. They were heavy-handedly " +
                    "requested by the Mishima Zaibatsu to join their conglomerate but naturally refused.";
            }
            if (Name == "Devil Jin")
            {
                BaseStory.Text = "When the Devil Gene takes over Jin's mind after a struggle completely, he becomes extremely arrogant, aggressive and brooding. " +
                    "He seeks to achieve ultimate power, and will do what ever it takes to achieve it. He is also very sadistic, as he has a habit of laughing " +
                    "at the suffering of his foes during his win animations. The only other person that also seems to bring Jin back to his human senses, is his mother Jun.";
            }
            if (Name == "Eddy Gordo")
            {
                BaseStory.Text = "Eddy was born into one of the richest families in Brazil. Ever since he was a small boy, he knew he would one day take over the family business. " +
                    "He was well-liked in his home town because he was a hard worker who treated others as his equals. One day, when he was 19, Eddy came home from school to find his " +
                    "father shot and dying. He recalled that his father had been unusually nervous and fearful in recent weeks.";
            }
            if (Name == "Feng Wei")
            {
                BaseStory.Text = "A ruthless and merciless martial artist. Feng has a lust for power and fighting, which can be seen as both a strength and " +
                    "weakness, as while he was skilled enough to be the best in his class, his greatest flaw is that his addiction and impulsive urge to start fighting " +
                    "eventually got the better of him, causing him to murder his master after he scolded him for fighting outside the dojo. He seeks to become the " +
                    "strongest fighter in the world, and is not afraid to show his full power against any opponent.";
            }
            if (Name == "Gigas")
            {
                BaseStory.Text = "Gigas is revealed as the adoptive father of Katarina Alves, whom he adopts from the orphanage she was sent to after the deaths " +
                    "of both of her parents. He is also the one who taught Katarina in the art of Savate before his sudden disappearance. It is later revealed during " +
                    "his disappearance that he was captured by the G Corporation and was experimented on to be mutated into a red hulking beast by using other fighter's " +
                    "DNA as a biotechnological weapon.";
            }
            if (Name == "Heihachi Mishima")
            {
                BaseStory.Text = "Heihachi Mishima is the host of the 1st, 3rd, 4th, and 7th King of Iron Fist Tournaments. He is the son of Jinpachi Mishima, " +
                    "serving as the final boss of 1 and 4 and the sub-boss of 3 and 7. He is the father of Kazuya Mishima and Lars Alexandersson, adoptive father " +
                    "of Lee Chaolan, grandfather of Jin Kazama, and the husband of Kazumi Mishima. Heihachi's fighting style is Mishima Style Fighting Karate. He is " +
                    "also the inaugural 'Commander' of the Tekken Force Unit.";
            }
            if (Name == "Hwoarang")
            {
                BaseStory.Text = "Hwoarang is a hot-headed, impulsive person who enjoys fighting. He is sometimes arrogant and brash as he likes to boast about his " +
                    "skills and strength. He still holds his focus on his opponents to not lose himself in his pride. He is very rebellious and does not like to obey " +
                    "orders, but this changes in regard to his master, Baek, whom he dearly respects. Hwoarang tends to hold a grudge towards his enemies, and he has a " +
                    "strong sense of determination to fight his rivals, especially Jin Kazama.";
            }
            if (Name == "Jack")
            {
                BaseStory.Text = "The first Jack was built by the Russian military, a killing machine built purely for destruction. After proving himself in the first " +
                    "King of Iron Fist Tournament, updated Jack robots were put into mass production and utilized in battlegrounds. During this time, one of the Jack-2 " +
                    "robots came across a young girl. Suddenly developing a conscience, Jack-2 took it upon himself to look after the girl, up until the point he was " +
                    "destroyed by Doctor Abel.";
            }
            if (Name == "Jin Kazama")
            {
                BaseStory.Text = "Jin Kazama is the son of Jun Kazama and Kazuya Mishima. Jun's intimate relationship with Kazuya grew and she became pregnant with " +
                    "Jin. The devil within Kazuya attempted to enter Jin while he was still in his mother's womb, but Jun managed to fight it off. Afterwards, " +
                    "Jun moved to a remote location in the mountains where she raised Jin and trained him in the Kazama family's self-defense fighting style.";
            }
            if (Name == "Josie Rizal")
            {
                BaseStory.Text = "Josie has been described to be bright, cheerful and quite energetic, but she has become more prone to crying because of something " +
                    "that happened in the past. It later reveals in her backstory that she was a big crybaby at the young age and is unable to ease it. During her " +
                    "training course and confrontation against Kuma, Josie was revealed to be afraid of bears and makes her flee in tears when it was encountered " +
                    "as well as being interrogated by it which caused her to faint.";
            }
            if (Name == "Katarina Alves")
            {
                BaseStory.Text = "Katarina is an aggressive and sassy-mouthed talker with a cocky and slightly flirtatious personality. She did however greatly " +
                    "respect her adoptive father, who recently disappeared and was transformed into G Corporation's brainwashed, mutated human, Gigas. Katarina seems " +
                    "to be very confident in her abilities as a fighter; alongside her cocky attitude, her fighting pose has her guard totally lowered (contrary " +
                    "to a traditional savate stance), and her posture is completely relaxed.";
            }
            if (Name == "Kazumi Mishima")
            {
                BaseStory.Text = "Kazumi is described in her introduction gameplay as being a serious and very determined woman who is ready to fight her opponents " +
                    "along with her pet tiger but she is also mysterious, cunning and seductive as seen in her pre-quotes when she calls her ex-husband, Heihachi. " +
                    "Especially when she summons her pet tiger to attack her opponents. Another of her pre-quotes is shown that she was very sad and disappointed " +
                    "implying that she becomes very upset towards her ex-husband for his actions.";
            }
            if (Name == "Kazuya")
            {
                BaseStory.Text = "In the original entry to the franchise, Kazuya was considered to be the primary protagonist, and for all intents and purposes, " +
                    "there was no reason to believe differently. According to differing sources (such as Tekken: The Motion Picture and a brief scene in Ling Xiaoyu's " +
                    "Tekken 5 ending), Kazuya was actually quite frail and timid as a boy and was the victim of years of abuse at the hands of Heihachi.";
            }
            if (Name == "Kuma")
            {
                BaseStory.Text = "Kuma was a bear cub found abandoned in the forests of the Mishima estate by Heihachi Mishima, who took him in as a pet. As he grew to " +
                    "adulthood, Kuma began to show a superior intellect, and Heihachi, upon realizing this, began to train him, teaching him sign language, fighting techniques " +
                    "and basic Japanese.";
            }
            if (Name == "King")
            {
                BaseStory.Text = "King used to be a street brawling orphan with no care in the world except fighting. In one of his fights, King was grievously wounded " +
                    "and collapsed in front of a monastery. The Marquez priests took him in, saving him from death. After recovering, King realized the error of his ways " +
                    "and resolved to start a new life. He became a Catholic priest and renounced his old fighting ways.";
            }
            if (Name == "Lars Alexandersson")
            {
                BaseStory.Text = "Lars has a heroic personality, as he led the coup d'etat that defeated the Mishima Zaibatsu. He also has the fighting spirit and " +
                    "determination of his half-nephew, Jin Kazama, and the charisma of his adopted brother Lee Chaolan, but is the complete opposite to Heihachi and Kazuya, " +
                    "being much like Jun Kazama in terms of personality. He strongly resembles Jin Kazama at times. Lars' actions and surroundings fit the mold of an archetypical " +
                    "hero.";
            }
            if (Name == "Law Marshall")
            {
                BaseStory.Text = "Marshall Law is a very talented martial artist. He's mostly known for owning a dojo and then owning a restaurant (although he had to resort " +
                    "to being dishwasher in Japan since he was penniless after being defeated in the 4th tournament). Marshall is best friends with Paul Phoenix, despite of " +
                    "having their fair share of arguments.";
            }
            if (Name == "Lee Chaolan")
            {
                BaseStory.Text = "Lee is an incredibly smug and conceited ladies man with an immense sense of class, unafraid to flaunt his wealth. Though eccentric to the " +
                    "point of femininity and just as scheming as his adoptive father, Lee is ultimately good-natured and holds a great contempt towards Kazuya and Heihachi.";
            }
            if (Name == "Leo Kliesen")
            {
                BaseStory.Text = "Leo was part of a very talented family. Leo's father was a world-famous spelunker, while Leo's mother served as a G Corporation executive. " +
                    "Although his father disappeared during an expedition when Leo was a child, Leo still wanted to follow in the family tradition and become a spelunker. " +
                    "Leo possessed a strong sense of character, thanks to a proper upbringing. Life was pleasant and relatively uneventful until one fateful day, when Leo's " +
                    "mother was killed by an unknown assailant.";
            }
            if (Name == "Miguel Caballero Rojo")
            {
                BaseStory.Text = "Miguel is a rather blood-thirsty and rebellious character, whose reckless nature can be seen as both his weakness and his strength. Miguel " +
                    "is depicted as an undisciplined Spaniard with a very intense passion for fighting, which often brought him into conflict with others.Despite being born " +
                    "into a conservative family, his wild and unruly nature made him the black sheep.";
            }
            if (Name == "Nina Williams")
            {
                BaseStory.Text = "Nina's persona seems to be cold and indifferent. In fact, she had been drugged by an underground force when she was young in order to create " +
                    "the perfect assassin, regarding the chronology of Death by Degrees. Her bitterness and hatred towards men could be a result of her defilation after Tekken " +
                    "2. The only man she had ever trusted was her father, who died shortly before Tekken 2. Ironically, after her father's death, Nina was controlled by Ogre, " +
                    "and was thus unable to feel any emotion.";
            }
            if (Name == "Emilie 'Lili' de Rochefort")
            {
                BaseStory.Text = "Even though Lili appears selfish and stuck-up, she is actually a very gentle and sweet young lady. However, like her rival Asuka Kazama, she " +
                    "revels in fighting despite being beautiful. This is proven throughout Scenario Campaign if the player chooses her. In almost every stage, it is shown that she " +
                    "sees most of the fighters as 'toys to play with' and also in her stage if the player plays as anyone except Lili, Asuka, Jin or Lars. In fact, if they play " +
                    "as Nina.";
            }
            if (Name == "Ling Xiaoxu")
            {
                BaseStory.Text = "Ling Xiaoyu infiltrated the Mishima Zaibatsu building in search of information relating to Jin Kazama's disappearance. Creeping deeper into the " +
                    "enemy territory under the guards' noses, she eventually hears Heihachi Mishima's voice coming from a room; he was giving orders about locating Jin. Just as " +
                    "Xiaoyu was about to sneak into the room, a man dressed all in white emerged and pushed her back. 'Take me to Jin!' Xiaoyu demanded, unflinching.";
            }
            if (Name == "Lucky Chloe")
            {
                BaseStory.Text = "As a child, Chloe's parents took her to a Expo and exposed her to the Japanese Idol culture and since then, she has always wanted to be an Idol. " +
                    "With her good looks, she set out on being the world's best Idol and named herself Lucky Chloe. Donning her cute costume, she went out to show the world her dance " +
                    "moves and put other pros to shame. She quickly became world famous when her dancing became viral on internet video sites. (However, North Americans hates her)";
            }
            if (Name == "Panda")
            {
                BaseStory.Text = "Panda, Ling Xiaoyu's pet and personal bodyguard, was concerned because she hadn't seen Xiaoyu since she'd left in search of Jin Kazama. Panda " +
                    "deduced that Xiaoyu was likely at a King of Iron Fist Tournament match, so she headed off to the arena.";
            }
            if (Name == "Paul Phoenix")
            {
                BaseStory.Text = "Paul Phoenix is a tough American fighter. Something of a drifter, Paul has no real career, instead making money by streetfighting and taking occasional " +
                    "work as a bouncer while he pursues his real passion - to prove himself to be the toughest fighter in the universe. Paul trains with Marshall Law, who would go on to " +
                    "become his good friend, and Lee Chaolan, and remains undefeated in battle, with the exception of a young fighter named Kazuya, who held him to a draw.";
            }
            if (Name == "Raven")
            {
                BaseStory.Text = "Master Raven is a black woman of unknown nationality (presumably North American) with faded scars across her face, who wears her dark brown and " +
                    "blonde hair in dreads gathered into a very long ponytail, leaving three bangs in front of her face, while she shaves the sides and bottom of the rest of her hair, " +
                    "leaving those areas with a low buzz cut. Her body is voluptuous and muscle-toned, fitting for a well-trained master ninja.";
            }
            if (Name == "Jin Kazama")
            {
                BaseStory.Text = "Jin Kazama is the son of Jun Kazama and Kazuya Mishima. Jun's intimate relationship with Kazuya grew and she became pregnant with Jin. The devil " +
                    "within Kazuya attempted to enter Jin while he was still in his mother's womb, but Jun managed to fight it off. Afterwards, Jun moved to a remote location in the " +
                    "mountains where she raised Jin and trained him in the Kazama family's self-defense fighting style.";
            }
            if (Name == "Sergei Dragunov")
            {
                BaseStory.Text = "Dragunov is cold, calculating, and totally impassive when fighting opponents. Aside from a few lines of dialogue, Dragunov is an elective mute, " +
                    "barely uttering a single word throughout the entire series.This tends to either annoy, confuse or unsettle other characters. He serves his motherland with " +
                    "utmost diligence and loyally follows orders when given. He also enjoys singing as a hobby.";
            }
            if (Name == "Shaheen")
            {
                BaseStory.Text = "Shaheen appears to be a calm and collected individual with a strong sense of justice. However, he is also humble and forgiving, believing that " +
                    "revenge is not the answer and that even people as diabolical as Kazuya deserve a second chance.";
            }
            if (Name == "Steve Fox")
            {
                BaseStory.Text = "Steve is a polite and gentlemanlike individual who's main motivation is to fight in the ring. He has very few enemies and has made many friends " +
                    "and friendly rivals throughout the series, including Marshall Law and Paul Phoenix. Despite these qualities, Steve has a mysterious and troublesome past which " +
                    "he does not seem to remember and he is constantly searching to uncover the truth about it.";
            }
            if (Name == "Yoshimitsu")
            {
                BaseStory.Text = "Has NO personality";
            }
        }


	}
}