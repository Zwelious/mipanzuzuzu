namespace CA_W12_ALFRED_W
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Players = new System.Windows.Forms.DataGridView();
            this.dgv_Manager = new System.Windows.Forms.DataGridView();
            this.lbl_add = new System.Windows.Forms.Label();
            this.lbl_del = new System.Windows.Forms.Label();
            this.lbl_editmanager = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pos = new System.Windows.Forms.Label();
            this.lbl_teamnum = new System.Windows.Forms.Label();
            this.lbl_nationality = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_birth = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.teamNum = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.cmb_Nationality = new System.Windows.Forms.ComboBox();
            this.cmb_Team = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_playerid = new System.Windows.Forms.Label();
            this.playerID = new System.Windows.Forms.TextBox();
            this.cmb_chooseTeam = new System.Windows.Forms.ComboBox();
            this.lbl_chooseteam = new System.Windows.Forms.Label();
            this.btn_Del = new System.Windows.Forms.Button();
            this.lbl_idplayer = new System.Windows.Forms.Label();
            this.lbl_chosenPlayer = new System.Windows.Forms.Label();
            this.cmb_mTeam = new System.Windows.Forms.ComboBox();
            this.lbl_mteam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Players)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Players
            // 
            this.dgv_Players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Players.Location = new System.Drawing.Point(237, 43);
            this.dgv_Players.Name = "dgv_Players";
            this.dgv_Players.Size = new System.Drawing.Size(240, 364);
            this.dgv_Players.TabIndex = 0;
            this.dgv_Players.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Players_CellClick);
            // 
            // dgv_Manager
            // 
            this.dgv_Manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Manager.Location = new System.Drawing.Point(678, 45);
            this.dgv_Manager.Name = "dgv_Manager";
            this.dgv_Manager.Size = new System.Drawing.Size(240, 179);
            this.dgv_Manager.TabIndex = 1;
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add.Location = new System.Drawing.Point(25, 25);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(68, 13);
            this.lbl_add.TabIndex = 2;
            this.lbl_add.Text = "Add Player";
            // 
            // lbl_del
            // 
            this.lbl_del.AutoSize = true;
            this.lbl_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_del.Location = new System.Drawing.Point(25, 313);
            this.lbl_del.Name = "lbl_del";
            this.lbl_del.Size = new System.Drawing.Size(83, 13);
            this.lbl_del.TabIndex = 3;
            this.lbl_del.Text = "Delete Player";
            // 
            // lbl_editmanager
            // 
            this.lbl_editmanager.AutoSize = true;
            this.lbl_editmanager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editmanager.Location = new System.Drawing.Point(486, 25);
            this.lbl_editmanager.Name = "lbl_editmanager";
            this.lbl_editmanager.Size = new System.Drawing.Size(82, 13);
            this.lbl_editmanager.TabIndex = 4;
            this.lbl_editmanager.Text = "Edit Manager";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(25, 74);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_pos
            // 
            this.lbl_pos.AutoSize = true;
            this.lbl_pos.Location = new System.Drawing.Point(25, 151);
            this.lbl_pos.Name = "lbl_pos";
            this.lbl_pos.Size = new System.Drawing.Size(44, 13);
            this.lbl_pos.TabIndex = 6;
            this.lbl_pos.Text = "Position";
            // 
            // lbl_teamnum
            // 
            this.lbl_teamnum.AutoSize = true;
            this.lbl_teamnum.Location = new System.Drawing.Point(25, 98);
            this.lbl_teamnum.Name = "lbl_teamnum";
            this.lbl_teamnum.Size = new System.Drawing.Size(52, 13);
            this.lbl_teamnum.TabIndex = 6;
            this.lbl_teamnum.Text = "Team no:";
            // 
            // lbl_nationality
            // 
            this.lbl_nationality.AutoSize = true;
            this.lbl_nationality.Location = new System.Drawing.Point(25, 124);
            this.lbl_nationality.Name = "lbl_nationality";
            this.lbl_nationality.Size = new System.Drawing.Size(59, 13);
            this.lbl_nationality.TabIndex = 7;
            this.lbl_nationality.Text = "Nationality:";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(25, 180);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(38, 13);
            this.lbl_height.TabIndex = 8;
            this.lbl_height.Text = "Height";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(25, 207);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(41, 13);
            this.lbl_weight.TabIndex = 9;
            this.lbl_weight.Text = "Weight";
            // 
            // lbl_birth
            // 
            this.lbl_birth.AutoSize = true;
            this.lbl_birth.Location = new System.Drawing.Point(25, 232);
            this.lbl_birth.Name = "lbl_birth";
            this.lbl_birth.Size = new System.Drawing.Size(49, 13);
            this.lbl_birth.TabIndex = 10;
            this.lbl_birth.Text = "Birthdate";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(25, 258);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(66, 13);
            this.lbl_team.TabIndex = 11;
            this.lbl_team.Text = "Team name:";
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(87, 71);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(100, 20);
            this.playerName.TabIndex = 12;
            // 
            // teamNum
            // 
            this.teamNum.Location = new System.Drawing.Point(87, 95);
            this.teamNum.Name = "teamNum";
            this.teamNum.Size = new System.Drawing.Size(100, 20);
            this.teamNum.TabIndex = 13;
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(87, 148);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(100, 20);
            this.position.TabIndex = 14;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(87, 177);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 20);
            this.height.TabIndex = 15;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(87, 204);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 20);
            this.weight.TabIndex = 16;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(87, 230);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(134, 20);
            this.birthdate.TabIndex = 17;
            // 
            // cmb_Nationality
            // 
            this.cmb_Nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nationality.FormattingEnabled = true;
            this.cmb_Nationality.Location = new System.Drawing.Point(87, 121);
            this.cmb_Nationality.Name = "cmb_Nationality";
            this.cmb_Nationality.Size = new System.Drawing.Size(121, 21);
            this.cmb_Nationality.TabIndex = 18;
            // 
            // cmb_Team
            // 
            this.cmb_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Team.FormattingEnabled = true;
            this.cmb_Team.Location = new System.Drawing.Point(87, 255);
            this.cmb_Team.Name = "cmb_Team";
            this.cmb_Team.Size = new System.Drawing.Size(121, 21);
            this.cmb_Team.TabIndex = 19;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(28, 282);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 20;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_playerid
            // 
            this.lbl_playerid.AutoSize = true;
            this.lbl_playerid.Location = new System.Drawing.Point(25, 48);
            this.lbl_playerid.Name = "lbl_playerid";
            this.lbl_playerid.Size = new System.Drawing.Size(53, 13);
            this.lbl_playerid.TabIndex = 21;
            this.lbl_playerid.Text = "Player ID:";
            // 
            // playerID
            // 
            this.playerID.Location = new System.Drawing.Point(87, 45);
            this.playerID.Name = "playerID";
            this.playerID.Size = new System.Drawing.Size(100, 20);
            this.playerID.TabIndex = 22;
            // 
            // cmb_chooseTeam
            // 
            this.cmb_chooseTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chooseTeam.FormattingEnabled = true;
            this.cmb_chooseTeam.Location = new System.Drawing.Point(87, 329);
            this.cmb_chooseTeam.Name = "cmb_chooseTeam";
            this.cmb_chooseTeam.Size = new System.Drawing.Size(121, 21);
            this.cmb_chooseTeam.TabIndex = 23;
            this.cmb_chooseTeam.SelectionChangeCommitted += new System.EventHandler(this.cmb_chooseTeam_SelectionChangeCommitted);
            // 
            // lbl_chooseteam
            // 
            this.lbl_chooseteam.AutoSize = true;
            this.lbl_chooseteam.Location = new System.Drawing.Point(25, 332);
            this.lbl_chooseteam.Name = "lbl_chooseteam";
            this.lbl_chooseteam.Size = new System.Drawing.Size(37, 13);
            this.lbl_chooseteam.TabIndex = 24;
            this.lbl_chooseteam.Text = "Team:";
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(28, 384);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 25;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // lbl_idplayer
            // 
            this.lbl_idplayer.AutoSize = true;
            this.lbl_idplayer.Location = new System.Drawing.Point(25, 357);
            this.lbl_idplayer.Name = "lbl_idplayer";
            this.lbl_idplayer.Size = new System.Drawing.Size(53, 13);
            this.lbl_idplayer.TabIndex = 26;
            this.lbl_idplayer.Text = "Player ID:";
            // 
            // lbl_chosenPlayer
            // 
            this.lbl_chosenPlayer.AutoSize = true;
            this.lbl_chosenPlayer.Location = new System.Drawing.Point(84, 357);
            this.lbl_chosenPlayer.Name = "lbl_chosenPlayer";
            this.lbl_chosenPlayer.Size = new System.Drawing.Size(0, 13);
            this.lbl_chosenPlayer.TabIndex = 27;
            // 
            // cmb_mTeam
            // 
            this.cmb_mTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mTeam.FormattingEnabled = true;
            this.cmb_mTeam.Location = new System.Drawing.Point(538, 45);
            this.cmb_mTeam.Name = "cmb_mTeam";
            this.cmb_mTeam.Size = new System.Drawing.Size(121, 21);
            this.cmb_mTeam.TabIndex = 28;
            this.cmb_mTeam.SelectionChangeCommitted += new System.EventHandler(this.cmb_mTeam_SelectionChangeCommitted);
            // 
            // lbl_mteam
            // 
            this.lbl_mteam.AutoSize = true;
            this.lbl_mteam.Location = new System.Drawing.Point(486, 52);
            this.lbl_mteam.Name = "lbl_mteam";
            this.lbl_mteam.Size = new System.Drawing.Size(37, 13);
            this.lbl_mteam.TabIndex = 29;
            this.lbl_mteam.Text = "Team:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Non-working managers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(489, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 161);
            this.dataGridView1.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mteam);
            this.Controls.Add(this.cmb_mTeam);
            this.Controls.Add(this.lbl_chosenPlayer);
            this.Controls.Add(this.lbl_idplayer);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.lbl_chooseteam);
            this.Controls.Add(this.cmb_chooseTeam);
            this.Controls.Add(this.playerID);
            this.Controls.Add(this.lbl_playerid);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cmb_Team);
            this.Controls.Add(this.cmb_Nationality);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.position);
            this.Controls.Add(this.teamNum);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_birth);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_nationality);
            this.Controls.Add(this.lbl_teamnum);
            this.Controls.Add(this.lbl_pos);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_editmanager);
            this.Controls.Add(this.lbl_del);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.dgv_Manager);
            this.Controls.Add(this.dgv_Players);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Players)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Players;
        private System.Windows.Forms.DataGridView dgv_Manager;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.Label lbl_del;
        private System.Windows.Forms.Label lbl_editmanager;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pos;
        private System.Windows.Forms.Label lbl_teamnum;
        private System.Windows.Forms.Label lbl_nationality;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_birth;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.TextBox teamNum;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.ComboBox cmb_Nationality;
        private System.Windows.Forms.ComboBox cmb_Team;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_playerid;
        private System.Windows.Forms.TextBox playerID;
        private System.Windows.Forms.ComboBox cmb_chooseTeam;
        private System.Windows.Forms.Label lbl_chooseteam;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Label lbl_idplayer;
        private System.Windows.Forms.Label lbl_chosenPlayer;
        private System.Windows.Forms.ComboBox cmb_mTeam;
        private System.Windows.Forms.Label lbl_mteam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

