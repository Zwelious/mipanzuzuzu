using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CA_W12_ALFRED_W
{
    public partial class Form1 : Form
    {
        string connection;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtPlayer, dtManager, dtNationality, dtTeam, dtTeams, dtmanagerTeam;
        
        public Form1()
        {
            connection = "server=localhost;user=root;pwd=;database=premier_league";
            try
            {
                sqlConnection = new MySqlConnection(connection);
            }
            catch (Exception e)
            { 
                MessageBox.Show(e.Message);
            } 
            InitializeComponent();
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string id = playerID.Text;
            string name = playerName.Text;
            string teamno = teamNum.Text;
            string natID = cmb_Nationality.SelectedValue.ToString();
            string pos = position.Text;
            string heights = height.Text;
            string weights = weight.Text;
            string birth = birthdate.Value.ToString("yyyy-MM-dd");
            string teamID = cmb_Team.SelectedValue.ToString();

            if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(teamno) || string.IsNullOrEmpty(pos) || string.IsNullOrEmpty(heights) || string.IsNullOrEmpty(weights) || string.IsNullOrEmpty(cmb_Team.Text) || string.IsNullOrEmpty(cmb_Nationality.Text))
            {
                MessageBox.Show("Enter all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string command = $"insert into player values ('{id}', '{teamno}', '{name}', '{natID}', '{pos}', '{heights}', '{weights}', '{birth}', '{teamID}',1,0)";
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new MySqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    updateDGV_Player();
                    playerID.Text = "";
                    playerName.Text = "";
                    teamNum.Text = "";
                    cmb_Nationality.Text = "";
                    position.Text = "";
                    height.Text = "";
                    weight.Text = "";
                    cmb_Team.Text = "";
                }
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            int count = 0;
            for(int i = 0; i < dtPlayer.Rows.Count; i++)
            {
                if (dtPlayer.Rows[i][10].ToString() == "0")
                {
                    count++;
                }
            }
            if(lbl_chosenPlayer.Text == "")
            {
                MessageBox.Show("Choose a player", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (count == 11)
            {
                MessageBox.Show("Can't remove player, minimum requirement for a team is 11 players", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string command = $"update player set `status` = 0 where player_id = '{lbl_chosenPlayer.Text}';";
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new MySqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    updateDGV_Player();
                    btn_Del.Enabled = false;
                }
            }            
        }

        private void cmb_mTeam_SelectionChangeCommitted(object sender, EventArgs e)
        { 
            try
            {
                string command = $"select * from manager m, team t where m.manager_id = t.manager_id and t.team_id = '{cmb_chooseTeam.SelectedValue.ToString()}'";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void cmb_chooseTeam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btn_Del.Enabled = true;
            dtPlayer.Clear();
            try
            {
                string command = $"select * from player where team_id = '{cmb_chooseTeam.SelectedValue.ToString()}' and status = 1";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtPlayer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Players_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string playerID = dgv_Players.CurrentRow.Cells[0].Value.ToString();
            lbl_chosenPlayer.Text = playerID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Del.Enabled = false;
            dtPlayer = new DataTable();
            dtManager = new DataTable();
            dtNationality = new DataTable();
            dtTeam = new DataTable();
            dtTeams = new DataTable();
            dtmanagerTeam = new DataTable();
            dgv_Players.DataSource = dtPlayer;
            dgv_Manager.DataSource = dtManager;
            updateDGV_Player();
            updateDGV_Manager();

            try
            {
                string command = "select * from nationality";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtNationality);
                cmb_Nationality.DataSource = dtNationality;
                cmb_Nationality.DisplayMember = "nation";
                cmb_Nationality.ValueMember = "nationality_id";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string command2 = "select * from team";
                sqlCommand = new MySqlCommand(command2, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtTeam);
                cmb_Team.DataSource = dtTeam;
                cmb_Team.DisplayMember = "team_name";
                cmb_Team.ValueMember = "team_id";

                sqlDataAdapter.Fill(dtTeams);
                cmb_chooseTeam.DataSource = dtTeams;
                cmb_chooseTeam.DisplayMember = "team_name";
                cmb_chooseTeam.ValueMember = "team_id";

                sqlDataAdapter.Fill(dtmanagerTeam);
                cmb_mTeam.DataSource = dtmanagerTeam;
                cmb_mTeam.DisplayMember = "team_name";
                cmb_mTeam.ValueMember = "team_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void updateDGV_Player()
        {
            dtPlayer.Clear();
            try
            {
                string command = "select * from player";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtPlayer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateDGV_Manager()
        {
            dtManager.Clear();
            try
            {
                string command = "select * from manager";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtManager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
