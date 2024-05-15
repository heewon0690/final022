using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class manage : UserControl
    {
        public manage()
        {
            InitializeComponent();
            ShowGrid();
        }

        public void ShowGrid()
        {
            login_grid.Rows.Clear();

            string connectionString = "Server=10.10.32.237;Database=final;Uid=final;Pwd=final1234!;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // 여기서부터 원하는 쿼리를 실행할 수 있습니다.
                string query = "SELECT * FROM login";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // 조회된 데이터 처리
                        login_grid.Rows.Add(reader["pnum"], reader["name"], reader["depart"], reader["position"], reader["cdate"]); // 첫 번째 열 값 출력 예시
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL 연결 실패: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void askBt_Click(object sender, EventArgs e)
        {
            int pnum;
            if (int.TryParse(pnumTxt.Text, out pnum))
            {
                Console.WriteLine("성공");
            }
            else
            {
                Console.WriteLine("실패");
            }
            string name = nameTxt.Text;
            string depart = (departCom.SelectedItem != null) ? departCom.SelectedItem.ToString() : "";
            string position = (positionCom.SelectedItem != null) ? positionCom.SelectedItem.ToString() : "";
            string cdate = (cdatePicker.Value != new DateTime(1989, 01, 01)) ? cdatePicker.Value.ToString() : "";

            AskGrid(pnum, name, depart, position, cdate);
        }

        public void AskGrid(int pnum, string name, string depart, string position, string cdate)
        {
            login_grid.Rows.Clear();

            string connectionString = "Server=10.10.32.237;Database=final;Uid=final;Pwd=final1234!;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // 여기서부터 원하는 쿼리를 실행할 수 있습니다.
                string query = "SELECT * FROM login WHERE 1=1";

                if (pnum != 0)
                    query += " AND pnum=@pnum";
                if (!string.IsNullOrEmpty(name))
                    query += " AND name=@name";
                if (!string.IsNullOrEmpty(depart))
                    query += " AND depart=@depart";
                if (!string.IsNullOrEmpty(position))
                    query += " AND position=@position";
                if (!string.IsNullOrEmpty(cdate))
                    query += " AND cdate=@cdate";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@pnum", pnum);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@depart", depart);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@cdate", cdate);

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 조회된 데이터 처리
                            login_grid.Rows.Add(reader["pnum"], reader["name"], reader["depart"], reader["position"], reader["cdate"]); // 첫 번째 열 값 출력 예시
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("쿼리 실행 실패: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL 연결 실패: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
