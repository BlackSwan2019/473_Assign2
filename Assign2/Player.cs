using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2 {
    /*
    * Class:       Player
    * Description: Game character.
    */
    public class Player {
        //private static Dictionary<uint, string> guildList = new Dictionary<uint, string>();     // Guild dictionary.

        private static uint MAX_LEVEL = 60;     // Highest level a player can be.

        readonly uint id;               // ID of player.
        readonly string name;           // Name of player.
        readonly Race race;             // Race of player.
        readonly CharClass charClass;   // Race of player.
        uint level;                     // Level of player.
        uint exp;                       // Player's accumulated experience within a level. Resets to 0 every level up.
        uint guildID;                   // ID of guild that player is in.

        public Player() {
            this.id = 0;
            this.name = "Ben";
            this.race = 0;
            this.charClass = 0;
            this.level = 3;
            this.exp = 0;
            this.guildID = 0;
        }

        public Player(uint id, string name, Race race, CharClass newClass, uint level, uint exp, uint guildID) {
            this.id = id;
            this.name = name;
            this.race = race;
            this.charClass = newClass;
            this.level = level;
            this.exp = exp;
            this.guildID = guildID;
        }

        public uint ID {
            get { return this.id; }
        }

        public string Name {
            get { return this.name; }
        }

        public Race Race {
            get { return this.race; }
        }

        public CharClass CharClass {
            get { return this.charClass; }
        }

        public uint Level {
            set {
                if (value >= 0 && value <= MAX_LEVEL)
                    this.level = value;
                else
                    this.level = 0;
            }

            get { return this.level; }
        }

        public uint Exp {
            set {

                if (Level == MAX_LEVEL) {
                    return;
                }

                // Add new experience points to existing experience points.
                this.exp += value;


                // Determine what the next level-up experience threshold is.
                uint nextLevelExp = (this.level * 1000);

                // While the total character experience is greater than level-up threshold, level up and readjust threshold.
                while (this.exp >= nextLevelExp) {
                    // Level up character by 1.
                    this.Level += 1;
                    Console.WriteLine("Ding!");

                    //XP = 35000
                    //NextLvL = 10000
                    this.exp = this.exp - nextLevelExp;

                    // Redetermine what the next level-up experience threshold is, now that the character is 1 level higher.
                    nextLevelExp = (this.level * 1000);
                }
            }

            get { return this.exp; }
        }

        public uint GuildID {
            get { return guildID; }
            set { guildID = value; }
        }

        public int CompareTo(object newRightOp) {
            if (newRightOp == null) return 1;

            Player rightOp = newRightOp as Player;

            if (rightOp != null)
                return this.name.CompareTo(rightOp.name);
            else
                throw new ArgumentException("The argument being compared is not of type Player.");
        }

        public void JoinGuild(uint guildID) {
            // Need to leave before you can join another guild
            if (this.GuildID != 0) {
                LeaveGuild();
            }

            this.GuildID = guildID;
        }

        public void LeaveGuild() {
            // Need to be in a guild to leave a guild
            if (this.GuildID != 0) {
                this.GuildID = 0;
            }
        }

        public override string ToString() {
            return "" + String.Format("Name: {0,-20}", this.Name) +
                   "" + String.Format("Race: {0,-20}", this.Race) +
                   "" + String.Format("Level: {0,-15}", this.Level);
        }

    }
}
