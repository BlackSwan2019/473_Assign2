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

    // Servers
    public enum Servers {
        Beta4Azeroth, TKWasASetback, ZappyBoi
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
                string line;        // Single entry in guilds.txt file.

                // While there are still lines to be read from guilds file, tokenize each line and add each guild to guildList dictionary.
                while ((line = reader.ReadLine()) != null) {
                    // Split line to isolate the guild ID.
                    string[] guildTokens = line.Split('\t');

                    // Convert gild ID from string to unsigned int.
                    uint guildId = Convert.ToUInt32(guildTokens[0]);
                    
                    // Split second part of line into guild name and guild server.
                    string[] guildInfo = guildTokens[1].Split('-');

                    string guildName = guildInfo[0];
                    string guildServer = guildInfo[1];

                    // Make a Guild object. Just send 0 for last argument since guilds from the file have yet to have a guild Type (Raiding, PVP, etc...).
                    Guild guild = new Guild(guildId, guildName, guildServer, 0);

                    // Finally, add guild to guildList dictionary.
                    guildList.Add(guildId, guild);
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
                listBoxGuilds.Items.Add(String.Format("{0, -20}\t{1, -5}\n", entry.Value.Name, entry.Value.Server));  
            }

            // Populate player list.
            foreach (KeyValuePair<uint, Player> entry in playerList) {
                listBoxPlayers.Items.Add(String.Format("{0, -17}\t{1, -17} {2, -5}\n", entry.Value.Name, entry.Value.CharClass, entry.Value.Level));
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
            comboBoxGServer.Items.Add(Servers.Beta4Azeroth);
            comboBoxGServer.Items.Add(Servers.TKWasASetback);
            comboBoxGServer.Items.Add(Servers.ZappyBoi);

            comboBoxGType.Items.Add(GuildType.Casual);
            comboBoxGType.Items.Add(GuildType.Mythic);
            comboBoxGType.Items.Add(GuildType.PVP);
            comboBoxGType.Items.Add(GuildType.Questing);
            comboBoxGType.Items.Add(GuildType.Raiding);
        }

        private void buttonMusic_Click(object sender, EventArgs e) {
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

        /*  
         *  Method:     buttonPrintGRoster_Click
         *  
         *  Purpose:    Handles when the user clicks "Print Guild Roster" button.
         * 
         *  Arguments:  object      The publisher of the event.
         *              EventArgs   Event data from the publisher.
         */
        private void buttonPrintGRoster_Click(object sender, EventArgs e) {
            // Clear the Output field.
            richTextOutput.Clear();

            // Get selected guild's ID number.
            uint guildId = getSelectedGuildID();

            string guildName = guildList[guildId].Name;

            // Print header for guild roster.
            richTextOutput.Text = String.Format("Guild Listing for {0, -25} [{1}]\n", guildName, guildList[guildId].Server);
            richTextOutput.Text += String.Format("---------------------------------------------------------------------------------\n");

            // Now that we have the guildID, print all player associated with that guildID.
            foreach(KeyValuePair<uint, Player> player in playerList) {
                if (guildId == player.Value.GuildID) {
                    richTextOutput.Text += String.Format( "Name: {0, -20} Race: {1, -15} Level: {2, -10} Guild: {3}\n", player.Value.Name, player.Value.Race, player.Value.Level, guildName);
                }
            }
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
                    errorMessage = new StringBuilder(errorMessage + "\n\u2022 Player Name ");
                }

                if (comboBoxRace.SelectedIndex == -1) {
                    errorMessage = new StringBuilder(errorMessage + "\n\u2022 Player Race ");
                }

                if (comboBoxClass.SelectedIndex == -1) {
                    errorMessage = new StringBuilder(errorMessage + "\n\u2022 Player Class ");
                }
                
                if (comboBoxRole.SelectedIndex == -1) {
                    errorMessage = new StringBuilder(errorMessage + "\n\u2022 Player Role ");
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
                Player newPlayer = new Player(playerId, textBoxPName.Text, (Race) raceNum, (CharClass) classNum, 0, 0, 0);
                
                // Add the new player to the players dictionary (Key: playerId  Value: newPlayer).
                playerList.Add(playerId, newPlayer);

                // Clear player list in the form to make way for the updated list.
                listBoxPlayers.Items.Clear();

                // Display the new player list by adding the updated Player dictionary. 
                foreach (KeyValuePair<uint, Player> entry in playerList) {
                    listBoxPlayers.Items.Add(String.Format("{0, -17}\t{1, -17} {2, -5}\n", entry.Value.Name, entry.Value.CharClass, entry.Value.Level));
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
            richTextOutput.Clear();

            // Error message for when user doesn't put in values in the player creation fields. 
            String guildFieldsError = "Couldn't add guild. Missing Information: ";
            StringBuilder errorMessage = new StringBuilder(guildFieldsError);
            
            // If player doesn't add information to a field(s), display a warning message in the Output with missing fields listed.
            if (textBoxGName.Text == "" || comboBoxGServer.SelectedIndex == -1 || comboBoxGType.SelectedIndex == -1) {
                if (textBoxGName.Text == "") {
                    errorMessage = new StringBuilder(errorMessage + "\n\u2022 Guild Name ");
                }

                if (comboBoxGServer.SelectedIndex == -1) {
                    errorMessage = new StringBuilder(errorMessage + "\n\u2022 Guild Server ");
                }

                if (comboBoxGType.SelectedIndex == -1) {
                    errorMessage = new StringBuilder(errorMessage + "\n\u2022 Guild Type ");
                }

                richTextOutput.Text = errorMessage.ToString();
            } else { // Add the guild to the system.
                // Make a new Guild object with data from form fields.
                Guild newGuild = new Guild(guildId, textBoxGName.Text, comboBoxGServer.SelectedItem.ToString(), 0);

                // Add the new player to the players dictionary (Key: playerId  Value: newPlayer).
                guildList.Add(guildId, newGuild);

                // Clear player list in the form to make way for the updated list.
                listBoxGuilds.Items.Clear();

                // Display the new player list by adding the updated Player dictionary. 
                foreach (KeyValuePair<uint, Guild> entry in guildList) {
                    listBoxGuilds.Items.Add(String.Format("{0, -20}\t{1, -5}\n", entry.Value.Name, entry.Value.Server));
                }

                richTextOutput.Text = String.Format(String.Format("{0} guild has been added. \n", textBoxGName.Text));

                // Reset player creation fields to blank.
                textBoxGName.Text = "";
                comboBoxGServer.SelectedIndex = -1;
                comboBoxGType.SelectedIndex = -1;

                // Increment player ID by one for the next new player.
                guildId++;
            }
        }

        /*  
         *  Method:     buttonDisbandGuild_Click
         *  
         *  Purpose:    Handles when a user clicks the "Disband Guild" button.
         * 
         *  Arguments:  object      The publisher of the event.
         *              EventArgs   Event data from the publisher.
         */
        private void buttonDisbandGuild_Click(object sender, EventArgs e) {
            uint playerCount = 0;
            StringBuilder guildlessPlayers = new StringBuilder("");

            // Reset Output field to blank.
            richTextOutput.Clear();

            // Get the selected guild's ID number.
            uint guildId = getSelectedGuildID();

            // Grab it's name for later output.
            string guildName = guildList[guildId].Name;

            // Remove guild from guild dictionary.
            guildList.Remove(guildId);

            // Display message in Output field that the guild was disbanded.
            richTextOutput.Text = String.Format("{0} has been disbanded. ", guildName);

            // Loop through the player list dictionary and set the disbanded guild's players' guild IDs to 0, since they are no longer in a guild.
            foreach (KeyValuePair<uint, Player> player in playerList) {
                // If player's guild ID is the same as the guild ID of the guild that is being disbanded...
                if (player.Value.GuildID == guildId) {
                    // Set player's guild ID to 0.
                    player.Value.GuildID = 0;

                    guildlessPlayers = new StringBuilder(guildlessPlayers + String.Format("\nName: {0, -15} Race: {1, -10} Level: {2, -10}", player.Value.Name, player.Value.Race, player.Value.Level));

                    playerCount++;
                }
            }

            // Display message in Output field that the guild was disbanded.
            richTextOutput.Text += String.Format("{0} players are now guildless!{1}", playerCount, guildlessPlayers);

            // Clear guild list to make way for new list.
            listBoxGuilds.Items.Clear();

            // Display the new player list by adding the updated Player dictionary. 
            foreach (KeyValuePair<uint, Guild> guild in guildList) {
                listBoxGuilds.Items.Add(String.Format("{0, -20}\t{1, -5}\n", guild.Value.Name, guild.Value.Server));
            }
        }

        /*  
         *  Method:     getSelectedGuildID
         *  
         *  Purpose:    Custom helper function to obtain a guild's ID number via guild name.
         * 
         *  Arguments:  none
         */
        private uint getSelectedGuildID() {
            uint guildId = 0;   // Guild ID. Used to grab all players from a guild with that ID.

            // Get selected guild string from listBox.
            string guildString = listBoxGuilds.SelectedItem.ToString();

            // Tokenize the selection.
            string[] guildInfo = guildString.Split('\t');

            // Grab name of guild.
            string guildName = guildInfo[0];

            // Trim off any trailing white space.
            guildName = guildName.TrimEnd();

            // See if selected guild name exists in guildList dictionary.
            foreach (KeyValuePair<uint, Guild> guild in guildList) {
                if (guildName.Equals(guild.Value.Name)) {
                    // Grab guild ID.
                    guildId = guild.Value.ID;
                }
            }

            return guildId;
        }

        /*  
         *  Method:     getSelectedPlayerID
         *  
         *  Purpose:    Custom helper function to obtain a player's ID number via player name.
         * 
         *  Arguments:  none
         */
        private uint getSelectedPlayerID() {
            uint playerId = 0;   // Player ID. Used to grab all players from a guild with that ID.

            // Get selected player string from listBox.
            string playerString = listBoxPlayers.SelectedItem.ToString();

            // Tokenize the selection.
            string[] playerInfo = playerString.Split('\t');

            // Grab name of player.
            string playerName = playerInfo[0];

            // Trim off any trailing white space.
            playerName = playerName.TrimEnd();

            // See if selected player name exists in playerList dictionary.
            foreach (KeyValuePair<uint, Player> player in playerList) {
                if (playerName.Equals(player.Value.Name)) {
                    // Grab player ID.
                    playerId = player.Value.ID;
                }
            }

            return playerId;
        }

        private void buttonJoinGuild_Click(object sender, EventArgs e) {
            richTextOutput.Clear();

            // Get selected player's ID number.
            uint playerId = getSelectedPlayerID();

            uint guildId = getSelectedGuildID();

            //playerList[playerId].JoinGuild(guildI);

            richTextOutput.Text = playerList[playerId].ToString();

        }
    }
}
