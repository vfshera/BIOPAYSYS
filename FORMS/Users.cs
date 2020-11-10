using BiometricPayroll.HELPERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricPayroll.FORMS
{
    public partial class Users : Form
    {
        public string SelectedRowID;
        public string SelectedUserSurname;
        public string searchQuery = "";

        public static Users userFM;
        public Users()
        {
            InitializeComponent();
            userFM = this;
        }


        private void Users_Load(object sender, EventArgs e)
        {
            loadUsers();
        }


        public void loadUsers()
        {
            Database db = new Database();
            string Search = $"SELECT id AS ID,name AS NAME ,email AS EMAIL, type AS TYPE FROM users WHERE name LIKE '{searchQuery}%' OR  email LIKE '{searchQuery}%' ORDER BY id ASC";


            if (searchQuery.Length == 0)
            {
                db.LoadDTG(usersTableGrid, Constants.USERS_QUERY);
            }
            else if (searchQuery.Length > 0)
            {
                db.LoadDTG(usersTableGrid, Search);
            }


        }

        private void txtBxSearch_TextChanged(object sender, EventArgs e)
        {
           searchQuery = txtBxSearch.Text.ToUpper();
           loadUsers();
        }

        private void usersTableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (usersTableGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    usersTableGrid.CurrentRow.Selected = true;

                    SelectedRowID = usersTableGrid.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    SelectedUserSurname = usersTableGrid.Rows[e.RowIndex].Cells["NAME"].FormattedValue.ToString();
                                      
                }
            }
            catch (System.ArgumentOutOfRangeException OutOfRange)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            if (SelectedRowID != null && SelectedUserSurname != null)
            {
                EditUser eu = new EditUser();
                eu.userID = SelectedRowID;
                eu.Show();
               
            }
            else
            {

                Alert.Popup("Please Select A Field!", Alert.AlertType.warning);
            }
        }
    }
}
