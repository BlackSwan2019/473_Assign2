namespace Assign2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonPrintGRoster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxServer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonLeaveGuild = new System.Windows.Forms.Button();
            this.buttonJoinGuild = new System.Windows.Forms.Button();
            this.buttonDisbandGuild = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxGType = new System.Windows.Forms.ComboBox();
            this.comboBoxGServer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxGName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAddGuild = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonMusic = new System.Windows.Forms.Button();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.listBoxGuilds = new System.Windows.Forms.ListBox();
            this.richTextOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrintGRoster
            // 
            this.buttonPrintGRoster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPrintGRoster.Location = new System.Drawing.Point(6, 19);
            this.buttonPrintGRoster.Name = "buttonPrintGRoster";
            this.buttonPrintGRoster.Size = new System.Drawing.Size(138, 26);
            this.buttonPrintGRoster.TabIndex = 0;
            this.buttonPrintGRoster.Text = "Print Guild Roster";
            this.buttonPrintGRoster.UseVisualStyleBackColor = true;
            this.buttonPrintGRoster.Click += new System.EventHandler(this.buttonPrintGRoster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSearchName);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonLeaveGuild);
            this.groupBox1.Controls.Add(this.buttonJoinGuild);
            this.groupBox1.Controls.Add(this.buttonDisbandGuild);
            this.groupBox1.Controls.Add(this.buttonPrintGRoster);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Management  Functions";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(345, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.resetServerSearch_Click);
            // 
            // comboBoxServer
            // 
            this.comboBoxServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServer.FormattingEnabled = true;
            this.comboBoxServer.Location = new System.Drawing.Point(165, 87);
            this.comboBoxServer.Name = "comboBoxServer";
            this.comboBoxServer.Size = new System.Drawing.Size(173, 26);
            this.comboBoxServer.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search Player (by Name)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search Guild (by Server)";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchName.Location = new System.Drawing.Point(165, 33);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(173, 26);
            this.textBoxSearchName.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearch.Location = new System.Drawing.Point(6, 147);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(138, 26);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Apply Search Criteria";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonLeaveGuild
            // 
            this.buttonLeaveGuild.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLeaveGuild.Location = new System.Drawing.Point(6, 115);
            this.buttonLeaveGuild.Name = "buttonLeaveGuild";
            this.buttonLeaveGuild.Size = new System.Drawing.Size(138, 26);
            this.buttonLeaveGuild.TabIndex = 3;
            this.buttonLeaveGuild.Text = "Leave Guild";
            this.buttonLeaveGuild.UseVisualStyleBackColor = true;
            this.buttonLeaveGuild.Click += new System.EventHandler(this.buttonLeaveGuild_Click);
            // 
            // buttonJoinGuild
            // 
            this.buttonJoinGuild.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonJoinGuild.Location = new System.Drawing.Point(6, 83);
            this.buttonJoinGuild.Name = "buttonJoinGuild";
            this.buttonJoinGuild.Size = new System.Drawing.Size(138, 26);
            this.buttonJoinGuild.TabIndex = 2;
            this.buttonJoinGuild.Text = "Join Guild";
            this.buttonJoinGuild.UseVisualStyleBackColor = true;
            this.buttonJoinGuild.Click += new System.EventHandler(this.buttonJoinGuild_Click);
            // 
            // buttonDisbandGuild
            // 
            this.buttonDisbandGuild.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDisbandGuild.Location = new System.Drawing.Point(6, 51);
            this.buttonDisbandGuild.Name = "buttonDisbandGuild";
            this.buttonDisbandGuild.Size = new System.Drawing.Size(138, 26);
            this.buttonDisbandGuild.TabIndex = 1;
            this.buttonDisbandGuild.Text = "Disband Guild";
            this.buttonDisbandGuild.UseVisualStyleBackColor = true;
            this.buttonDisbandGuild.Click += new System.EventHandler(this.buttonDisbandGuild_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(405, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player/Guild Management System";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxRole);
            this.groupBox2.Controls.Add(this.comboBoxClass);
            this.groupBox2.Controls.Add(this.comboBoxRace);
            this.groupBox2.Controls.Add(this.buttonAddPlayer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 149);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Player";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(165, 87);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(140, 26);
            this.comboBoxRole.TabIndex = 11;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(9, 87);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(140, 26);
            this.comboBoxClass.TabIndex = 10;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(165, 37);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(140, 26);
            this.comboBoxRace.TabIndex = 9;
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddPlayer.Location = new System.Drawing.Point(324, 37);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(97, 26);
            this.buttonAddPlayer.TabIndex = 12;
            this.buttonAddPlayer.Text = "Add Player";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Player Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxPName
            // 
            this.textBoxPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPName.Location = new System.Drawing.Point(9, 38);
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.Size = new System.Drawing.Size(135, 26);
            this.textBoxPName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Race";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxGType);
            this.groupBox3.Controls.Add(this.comboBoxGServer);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxGName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.buttonAddGuild);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 460);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 149);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create New Guild";
            // 
            // comboBoxGType
            // 
            this.comboBoxGType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGType.FormattingEnabled = true;
            this.comboBoxGType.Location = new System.Drawing.Point(165, 88);
            this.comboBoxGType.Name = "comboBoxGType";
            this.comboBoxGType.Size = new System.Drawing.Size(140, 26);
            this.comboBoxGType.TabIndex = 15;
            // 
            // comboBoxGServer
            // 
            this.comboBoxGServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGServer.FormattingEnabled = true;
            this.comboBoxGServer.Location = new System.Drawing.Point(165, 38);
            this.comboBoxGServer.Name = "comboBoxGServer";
            this.comboBoxGServer.Size = new System.Drawing.Size(140, 26);
            this.comboBoxGServer.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Guild Name";
            // 
            // textBoxGName
            // 
            this.textBoxGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGName.Location = new System.Drawing.Point(9, 38);
            this.textBoxGName.Name = "textBoxGName";
            this.textBoxGName.Size = new System.Drawing.Size(135, 26);
            this.textBoxGName.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Server";
            // 
            // buttonAddGuild
            // 
            this.buttonAddGuild.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddGuild.Location = new System.Drawing.Point(324, 38);
            this.buttonAddGuild.Name = "buttonAddGuild";
            this.buttonAddGuild.Size = new System.Drawing.Size(97, 26);
            this.buttonAddGuild.TabIndex = 16;
            this.buttonAddGuild.Text = "Add Guild";
            this.buttonAddGuild.UseVisualStyleBackColor = true;
            this.buttonAddGuild.Click += new System.EventHandler(this.buttonAddGuild_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(485, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Players";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(835, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 30);
            this.label12.TabIndex = 16;
            this.label12.Text = "Guilds";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(7, 634);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 30);
            this.label13.TabIndex = 18;
            this.label13.Text = "Output";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // buttonMusic
            // 
            this.buttonMusic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMusic.Location = new System.Drawing.Point(1081, 17);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(97, 26);
            this.buttonMusic.TabIndex = 9;
            this.buttonMusic.Text = "Stop Music";
            this.buttonMusic.UseVisualStyleBackColor = true;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxPlayers.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 16;
            this.listBoxPlayers.Location = new System.Drawing.Point(490, 93);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(320, 516);
            this.listBoxPlayers.TabIndex = 17;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayers_SelectedIndexChanged);
            // 
            // listBoxGuilds
            // 
            this.listBoxGuilds.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxGuilds.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGuilds.FormattingEnabled = true;
            this.listBoxGuilds.ItemHeight = 16;
            this.listBoxGuilds.Location = new System.Drawing.Point(840, 93);
            this.listBoxGuilds.Name = "listBoxGuilds";
            this.listBoxGuilds.Size = new System.Drawing.Size(338, 516);
            this.listBoxGuilds.TabIndex = 18;
            this.listBoxGuilds.SelectedIndexChanged += new System.EventHandler(this.listBoxGuilds_SelectedIndexChanged);
            // 
            // richTextOutput
            // 
            this.richTextOutput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextOutput.Location = new System.Drawing.Point(12, 663);
            this.richTextOutput.Name = "richTextOutput";
            this.richTextOutput.Size = new System.Drawing.Size(1166, 132);
            this.richTextOutput.TabIndex = 23;
            this.richTextOutput.Text = "";
            this.richTextOutput.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1201, 814);
            this.Controls.Add(this.richTextOutput);
            this.Controls.Add(this.listBoxGuilds);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.buttonMusic);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintGRoster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonLeaveGuild;
        private System.Windows.Forms.Button buttonJoinGuild;
        private System.Windows.Forms.Button buttonDisbandGuild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxGName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAddGuild;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.ListBox listBoxGuilds;
        private System.Windows.Forms.RichTextBox richTextOutput;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.ComboBox comboBoxGType;
        private System.Windows.Forms.ComboBox comboBoxGServer;
        private System.Windows.Forms.ComboBox comboBoxServer;
        private System.Windows.Forms.Button button1;
    }
}

