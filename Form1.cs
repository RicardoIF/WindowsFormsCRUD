using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCRUD
{
    public partial class Form1 : Form
    {
        INTEC_AGU_OCT22Entities db = new INTEC_AGU_OCT22Entities();
        List<string> Msg = new List<string>();
        string Peopleid = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("F");
            GetContactType();
            GetClientType();
            GetPermissions();
            GetRestriction();
            GetPeople();
        }

        private void GetPeople()
        {
            var people = db.People.ToList();
            dgvPeople.DataSource = people;
        }

        private void GetRestriction()
        {
            var restrictions = db.Restrictions.ToList();
            foreach (var item in restrictions)
            {
                cblRestrictions.Items.Add(item.Name);
            }
        }

        private void GetPermissions()
        {
            var permissions = db.Permissions.ToList();
            foreach (var item in permissions)
            {
                cblPermisons.Items.Add(item.Name);
            }

        }

        private void GetClientType()
        {
            var clientType = db.ClientTypes.ToList();
            cbClientType.DataSource = clientType;
            cbClientType.DisplayMember = "Name";
            cbClientType.ValueMember = "Id";
        }

        private void GetContactType()
        {
            var contactType = db.ContactTypes.ToList();
            cbContactType.DataSource = contactType;
            cbContactType.DisplayMember = "Name";
            cbContactType.ValueMember = "Id";
        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            pnlForm.Enabled = true;
            btAdd.Enabled = false;
            btSave.Enabled = true;
            btCancel.Enabled = true;
            btSave.ForeColor = Color.Green;
        }

        private void SaveForm()
        {
            var people = new Person();
            people.Id = Guid.NewGuid().ToString();
            people.FirstName = txtFirstName.Text;
            people.MiddleName = txtMidleName.Text;
            people.LastName = txtLastName.Text;
            people.ClientTypeId = Convert.ToInt32(cbClientType.SelectedValue);
            if (cbContactType.SelectedIndex != 0)
            {
                people.ContactTypeId = Convert.ToInt32(cbContactType.SelectedIndex);
            }
            people.SupportStaff = chkSupportStaff.Checked;
            people.PhoneNumber = txtPhoneNumber.Text;
            people.EmailAddress = txtEmail.Text;
            people.Enabled = true;
            people.CreatedDate = DateTime.Now;

            db.People.Add(people);
            var peopleSaved = db.SaveChanges() > 0;

            if (peopleSaved)
            {
                var user = new User();

                user.Id = Guid.NewGuid().ToString();
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.LicenseTypeId = Convert.ToInt32(cbLicenceType.SelectedIndex);
                user.PeopleId = people.Id;
                user.Enabled = true;
                user.CreatedDate = DateTime.Now;
                db.Users.Add(user);
                var userSaved = db.SaveChanges() > 0;

                if (userSaved)
                {
                    MessageBox.Show("The person has been added!");
                    GetPeople();
                    DefaultControl();

                    btAdd.Enabled = true;
                    btSave.Enabled = false;
                    btCancel.Enabled = false;
                    btSave.ForeColor = Color.Black;
                    pnlForm.Enabled = false;
                }
            }
        }

        private void DefaultControl()
        {
            txtFirstName.Text = string.Empty;
            txtMidleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cbClientType.SelectedIndex = 0;
            cbContactType.SelectedIndex = 0;
            chkSupportStaff.Checked = false;
            chkSupportStaff.Text = "NO";
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCreateDate.Text = string.Empty;
            cbLicenceType.SelectedIndex = 0;
        }

        private bool ValidateForm()
        {
            Msg = new List<string>();
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblPassword.Visible = false;
            lblUser.Visible = false;
            lblPhone.Visible = false;
            bool result = true;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                result = false;
                Msg.Add("The field (First name ) is requeried.");
                lblFirstName.Visible = true;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                result = false;
                Msg.Add("The field (Last name ) is requeried.");
                lblLastName.Visible = true;
            }
            if (cbClientType.SelectedIndex == 0)
            {
                result = false;
                Msg.Add("The field (Client Type ) is requeried.");
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                result = false;
                Msg.Add("The field (Phone Number ) is requeried.");
                lblPhone.Visible = true;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                result = false;
                Msg.Add("The field (Username ) is requeried.");
                lblUser.Visible = true;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                result = false;
                Msg.Add("The field (Password ) is requeried.");
                lblPassword.Visible = true;
            }
            return result;
        }

        private void btSave_Click_1(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                SaveForm();
            }
            else
            {
                string error = string.Empty;
                int errorIndex = 1;
                foreach (var item in Msg)
                {
                    error += $"{errorIndex}, - {item.ToString()}\n";
                    errorIndex++;
                }
                MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            GetPeople();
            DefaultControl();

            btAdd.Enabled = true;
            btSave.Enabled = false;
            btCancel.Enabled = false;
            btSave.ForeColor = Color.Black;
            pnlForm.Enabled = false;
        }

        private void dgvPeople_Click(object sender, EventArgs e)
        {
            Peopleid = string.Empty;
            if (!string.IsNullOrEmpty(dgvPeople.SelectedRows[0].Cells["Id"].Value.ToString()))
            {
                Peopleid = dgvPeople.SelectedRows[0].Cells["Id"].Value.ToString();
                btUpdate.Visible = true;
                btDelete.Visible = true;
                btUpdate.Enabled = true;
                btDelete.Enabled = true;
                pnlForm.Enabled = true;
                GetPeopleById(Peopleid);
            }
            else
            {
                btUpdate.Visible = false;
                btDelete.Visible = false;
                btUpdate.Enabled = false;
                btDelete.Enabled = false;
            }
        }

        private void GetPeopleById(string peopleid)
        {
            DefaultControl();
            var people = db.People.FirstOrDefault(x => x.Id == peopleid);
            if (people != null)
            {
                txtFirstName.Text = people.FirstName;
                txtMidleName.Text = people.MiddleName;
                txtLastName.Text = people.LastName;
                txtPhoneNumber.Text = people.PhoneNumber;
                chkSupportStaff.Checked = people.SupportStaff;
                chkSupportStaff.Text = people.SupportStaff ? "SI" : "NO";
                txtEmail.Text = people.EmailAddress;
                txtCreateDate.Text = people.CreatedDate.ToString("MM/dd/yyyy");


                var user = db.Users.FirstOrDefault(x => x.PeopleId == peopleid);
                if (user != null)
                {
                    txtUsername.Text = user.Username;
                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            var res = MessageBox.Show("Esta seguro de actualizar este registro!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (res.Equals(DialogResult.OK))
            {
                UpdatePeople(Peopleid);
            }
        }

        private void UpdatePeople(string peopleid)
        {
            var people = db.People.FirstOrDefault(x => x.Id == peopleid);
            people.FirstName = txtFirstName.Text;
            people.MiddleName = txtMidleName.Text;
            people.LastName = txtLastName.Text;
            people.ClientTypeId = Convert.ToInt32(cbClientType.SelectedValue);
            if (cbContactType.SelectedIndex != 0)
            {
                people.ContactTypeId = Convert.ToInt32(cbContactType.SelectedIndex);
            }
            people.SupportStaff = chkSupportStaff.Checked;
            people.PhoneNumber = txtPhoneNumber.Text;
            people.EmailAddress = txtEmail.Text;
            people.Enabled = true;
            people.CreatedDate = DateTime.Now;

            db.Entry(people).State = System.Data.Entity.EntityState.Modified;
            var peopleSaved = db.SaveChanges() > 0;

            if (peopleSaved)
            {
                var user = db.Users.FirstOrDefault(x => x.PeopleId == peopleid);

                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                user.LicenseTypeId = Convert.ToInt32(cbLicenceType.SelectedIndex);
                user.Enabled = true;
                user.CreatedDate = DateTime.Now;


                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                var userSaved = db.SaveChanges() > 0;

                if (userSaved)
                {
                    MessageBox.Show("The person has been added!");
                    GetPeople();
                    DefaultControl();


                    btAdd.Enabled = true;
                    pnlForm.Enabled = false;
                    btCancel.Enabled = false;
                    btSave.Enabled = false;
                    btUpdate.Enabled = false;
                    btDelete.Enabled = false;
                    btUpdate.Visible = false;
                    btDelete.Visible = false;
                }
            }
        }

        private void chkSupportStaff_CheckedChanged(object sender, EventArgs e)
        {
            chkSupportStaff.Text = chkSupportStaff.Checked ? "SI" : "NO";
        }

        private void clientTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void contactTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de eliminar este registro!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (res.Equals(DialogResult.OK))
            {
                DeletePeopleType(Peopleid);
            }
        }

        private void DeletePeopleType(string peopleid)
        {
            DefaultControl();
            var people = db.People.FirstOrDefault(x => x.Id == peopleid);
            db.People.Remove(people);
            var res = db.SaveChanges() > 0;
            if (res)
            {
                MessageBox.Show("The client type has been added!");

                GetClientType();
                DefaultControl();

                btAdd.Enabled = true;
                pnlForm.Enabled = false;
                btCancel.Enabled = false;
                btSave.Enabled = false;
                btUpdate.Enabled = false;
                btDelete.Enabled = false;
                btUpdate.Visible = false;
                btDelete.Visible = false;
            }
        }
    }
}
