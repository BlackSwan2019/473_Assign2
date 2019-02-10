using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign2 {
    // The types of items a character can have.
    public enum ItemType {
        Helmet, Neck, Shoulders, Back, Chest, Wrists,
        Gloves, Belt, Pants, Boots, Ring, Trinket
    };

    // The available races for the character.
    public enum Race {
        Orc, Troll, Tauren, Forsaken
    }

    // The player classes.
    public enum CharClass {
        Warrior, Mage, Druid, Priest, Warlock, Rogue, Paladin, Hunter, Shaman
    }

    // Guild types.
    public enum GuildType {
        Casual, Questing, Mythic, Raiding, PVP
    }

    public partial class Form1 : Form {
        uint playerId = 0;
        uint guildId = 0;

        bool musicStatus = false;

        private static Dictionary<uint, Player> playerList = new Dictionary<uint, Player>();    // Player dictionary.
        private static Dictionary<uint, Guild> guildList = new Dictionary<uint, Guild>();       // Player dictionary.


        public Form1() {
            InitializeComponent();

            // Build Guild dictionary
            using (var reader = new StreamReader(@"..\..\..\Resources\guilds.txt")) {
                string line;

                while ((line = reader.ReadLine()) != null) {
                    string[] itemTokens = line.Split('\t');

                    uint guildId = Convert.ToUInt32(itemTokens[0]);

                    string[] guildInfo = line.Split('-');

                    string guildName = guildInfo[0];
                    string guildServer = guildInfo[1];


                    // Make a Guild object.
                    Guild guild = new Guild(guildId, guildName, guildServer, 0);

                    guildList.Add(Convert.ToUInt32(itemTokens[0]), guild);
                }
            }

            // Build Player dictionary
            using (var reader = new StreamReader(@"..\..\..\Resources\players.txt")) {
                string line;

                while ((line = reader.ReadLine()) != null) {
                    string[] itemTokens = line.Split('\t');

                    //uint id, string name, Race race, Class class, uint level, uint exp, uint guildID

                    Player player = new Player(
                        Convert.ToUInt32(itemTokens[0]),
                        itemTokens[1],
                        (Race)Convert.ToUInt32(itemTokens[2]),
                        (CharClass) Convert.ToUInt32(itemTokens[3]),
                        Convert.ToUInt32(itemTokens[4]),
                        Convert.ToUInt32(itemTokens[5]),
                        Convert.ToUInt32(itemTokens[6])
                    );

                    playerList.Add(Convert.ToUInt32(itemTokens[0]), player);
                }
            }

            // Populate guild list.
            foreach(KeyValuePair<uint, Guild> entry in guildList) {
                listBoxGuilds.Items.Add(entry.Value.ToString() + "\n"); /////////////////////////////////////////////////////////////////////// 
            }

            // Populate player list.
            foreach (KeyValuePair<uint, Player> entry in playerList) {
                listBoxPlayers.Items.Add(String.Format("{0, -17} {1, -17} {2, -5}\n", entry.Value.Name, entry.Value.CharClass, entry.Value.Level));
            }

            // Populate create player comboBoxes.
            comboBoxRace.Items.Add(Race.Forsaken);
            comboBoxRace.Items.Add(Race.Orc);
            comboBoxRace.Items.Add(Race.Tauren);
            comboBoxRace.Items.Add(Race.Troll);

            comboBoxClass.Items.Add(CharClass.Warrior);
            comboBoxClass.Items.Add(CharClass.Mage);
            comboBoxClass.Items.Add(CharClass.Druid);
            comboBoxClass.Items.Add(CharClass.Priest);
            comboBoxClass.Items.Add(CharClass.Warlock);
            comboBoxClass.Items.Add(CharClass.Rogue);
            comboBoxClass.Items.Add(CharClass.Paladin);
            comboBoxClass.Items.Add(CharClass.Hunter);
            comboBoxClass.Items.Add(CharClass.Shaman);

            // Populate create guild comboBoxes.

        }

        private void button7_Click(object sender, EventArgs e) {
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\..\Resources\out.wav");

            if (!musicStatus) {
                simpleSound.Play();
                musicStatus = true;
            } else {
                simpleSound.Stop();
                musicStatus = false;
            }
        }

        private void richTextGuilds_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void guildButton_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label13_Click(object sender, EventArgs e) {

        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e) {
            ListBox listbox = sender as ListBox;

            richTextOutput.Text = listbox.SelectedItem.ToString();
        }

        /*  
         *  Method:     buttonAddPlayer_Click
         *  
         *  Purpose:    Handles when the user clicks "Add Player" button.
         * 
         *  Arguments:  object      The publisher of the event.
         *              EventArgs   Event data from the publisher.
         */
        private void buttonAddPlayer_Click(object sender, EventArgs e) {
            // Reset output field to blank.
            richTextOutput.Text = "";

            // Error message for when user doesn't put in values in the player creation fields. 
            String playerFieldsError = "Couldn't add player. Missing: ";
            StringBuilder errorMessage = new StringBuilder(playerFieldsError);

            // If player doesn't add information to a field(s), display a warning message in the Output with missing fields listed.
            if (textBoxPName.Text == "" || comboBoxRace.SelectedIndex == -1 || comboBoxClass.SelectedIndex == -1 || comboBoxRole.SelectedIndex == -1) {
                if (textBoxPName.Text == "") {
                    errorMessage = new StringBuilder(errorMessage + "\n\t Player Name ");
                }

                if (comboBoxRace.SelectedIndex == -1) {
                    errorMessage = new StringBuilder(errorMessage + "\n\t Player Race ");
                }

                if (comboBoxClass.SelectedIndex == -1) {
                    errorMessage = new StringBuilder(errorMessage + "\n\t Player Class ");
                }
                
                if (comboBoxRole.SelectedIndex == -1) {
                    errorMessage = new StringBuilder(errorMessage + "\n\t Player Role ");
                }

                richTextOutput.Text = errorMessage.ToString();
            } else { // Add player to the system.
                //var classNum = Enum.IsDefined(typeof(CharClass), comboBoxClass.SelectedItem.ToString());
                Race raceEnum = (Race)System.Enum.Parse(typeof(Race), comboBoxRace.SelectedItem.ToString());
                
                // Get enum value of race.
                int raceNum = (int) raceEnum;

                //var classNum = Enum.IsDefined(typeof(CharClass), comboBoxClass.SelectedItem.ToString());
                CharClass classEnum = (CharClass) System.Enum.Parse(typeof(CharClass), comboBoxClass.SelectedItem.ToString());
                
                // Get enum value of class.
                int classNum = (int) classEnum;

                // Make a new player based on information grabbed from the four player fields in the form.
                Player newPlayer = new Player(playerId, textBoxPName.Text, (Race) raceNum, (CharClass) classNum, 0, 0, 154794);
                
                // Add the new player to the players dictionary (Key: playerId  Value: newPlayer).
                playerList.Add(playerId, newPlayer);

                // Clear player list in the form to make way for the updated list.
                listBoxPlayers.Items.Clear();

                // Display the new player list by adding the updated Player dictionary. 
                foreach (KeyValuePair<uint, Player> entry in playerList) {
                    listBoxPlayers.Items.Add(String.Format("{0, -17} {1, -17} {2, -5}\n", entry.Value.Name, entry.Value.CharClass, entry.Value.Level));
                }

                richTextOutput.Text = String.Format("{0} the {1} has been added.", newPlayer.Name, newPlayer.CharClass);

                // Reset player creation fields to blank.
                textBoxPName.Text = "";
                comboBoxRace.SelectedIndex = -1;
                comboBoxClass.SelectedIndex = -1;
                comboBoxRole.SelectedIndex = -1;

                // Increment player ID by one for the next new player.
                playerId++;
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e) {
            // Depending on what Class the user selected, populate the Role comboBox with certain roles.
            switch(comboBoxClass.Text) {
                case "Warrior":
                    comboBoxRole.SelectedIndex = -1;
                    comboBoxRole.Items.Clear();
                    comboBoxRole.Items.Add("Tank");
                    comboBoxRole.Items.Add("DPS");
                    break;
                case "Mage":
                    comboBoxRole.SelectedIndex = -1;
                    comboBoxRole.Items.Clear();
                    comboBoxRole.Items.Add("DPS");
                    break;
                case "Druid":
                    comboBoxRole.SelectedIndex = -1;
                    comboBoxRole.Items.Clear();
                    comboBoxRole.Items.Add("Tank");
                    comboBoxRole.Items.Add("Healer");
                    comboBoxRole.Items.Add("DPS");
                    break;
                case "Priest":
                    comboBoxRole.SelectedIndex = -1;
                    comboBoxRole.Items.Clear();
                    comboBoxRole.Items.Add("Healer");
                    comboBoxRole.Items.Add("DPS");
                    break;
                case "Warlock":
                    comboBoxRole.SelectedIndex = -1;
                    comboBoxRole.Items.Clear();
                    comboBoxRole.Items.Add("DPS");
                    break;
                case "Rogue":
                    comboBoxRole.SelectedIndex = -1;
                    comboBoxRole.Items.Clear();
                    comboBoxRole.Items.Add("DPS");
                    break;
                case "Paladin":
                    comboBoxRole.SelectedIndex = -1;
                    comboBoxRole.Items.Clear();
                    comboBoxRole.Items.Add("Tank");
                    comboBoxRole.Items.Add("Healer");
                    comboBoxRole.Items.Add("DPS");
                    break;
                case "Hunter":
                    comboBoxRole.SelectedIndex = -1;
                    comboBoxRole.Items.Clear();
                    comboBoxRole.Items.Add("DPS");
                    break;
                case "Shaman":
                    comboBoxRole.SelectedIndex = -1;
                    comboBoxRole.Items.Clear();
                    comboBoxRole.Items.Add("Healer");
                    comboBoxRole.Items.Add("DPS");
                    break;
            }
        }

        /*  
         *  Method:     buttonAddGuild_Click
         *  
         *  Purpose:    Handles when the user clicks "Add Guild" button.
         * 
         *  Arguments:  object      The publisher of the event.
         *              EventArgs   Event data from the publisher.
         */
        private void buttonAddGuild_Click(object sender, EventArgs e) {
            // Reset output field to blank.
            richTextOutput.Text = "";

            // Error message for when user doesn't put in values in the player creation fields. 
            String guildFieldsError = "Couldn't add guild. Missing Information: ";
            StringBuilder errorMessage = new StringBuilder(guildFieldsError);
            
            // If player doesn't add information to a field(s), display a warning message in the Output with missing fields listed.
            if (textBoxGName.Text == "" || comboBoxGServer.SelectedIndex == -1 || comboBoxGType.SelectedIndex == -1) {
                if (textBoxGName.Text == "") {
                    errorMessage = new StringBuilder(errorMessage + "\n\t Guild Name ");
                }

                if (comboBoxGServer.SelectedIndex == -1) {
                    errorMessage = new StringBuilder(errorMessage + "\n\t Guild Server ");
                }

                if (comboBoxGType.SelectedIndex == -1) {
                    errorMessage = new StringBuilder(errorMessage + "\n\t Guild Type ");
                }

                richTextOutput.Text = errorMessage.ToString();
            } else { // Add the guild to the system.
                // Objectify!
                Guild newGuild = new Guild(guildId, textBoxGName.Text, comboBoxGServer.SelectedItem.ToString(), 0);

                // Add the new player to the players dictionary (Key: playerId  Value: newPlayer).
                guildList.Add(guildId, newGuild);

                // Clear player list in the form to make way for the updated list.
                listBoxGuilds.Items.Clear();

                // Display the new player list by adding the updated Player dictionary. 
                foreach (KeyValuePair<uint, Guild> entry in guildList) {
                    listBoxGuilds.Items.Add(String.Format("{0, -17} \n", entry.Value));
                }

                richTextOutput.Text = String.Format(String.Format("{0, -17} guild has been added. \n", textBoxGName.Text));

                // Reset player creation fields to blank.
                textBoxGName.Text = "";
                comboBoxGServer.SelectedIndex = -1;
                comboBoxGType.SelectedIndex = -1;

                // Increment player ID by one for the next new player.
                guildId++;
            }
        }
    }
}
