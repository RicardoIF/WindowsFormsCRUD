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
    public partial class Form3 : Form
    {
        INTEC_AGU_OCT22Entities db = new INTEC_AGU_OCT22Entities();
        List<string> Msg = new List<string>();
        int ContactTypeID = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblDateContactTypeUpp.Text = DateTime.Now.ToString("F");
            lblDateContactType.Text = DateTime.Now.ToString("F");
            GetContactType();
        }

        private void GetContactType()
        {
            var contact = db.ContactTypes.ToList();
            dgvContactType.DataSource = contact;
        }

        private void btSaveContactType_Click(object sender, EventArgs e)
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

        private void SaveForm()
        {
            var contactType = new ContactType();
            contactType.Name = txtContactTypeName.Text;
            contactType.Description = txtContactTypeDescription.Text;
            contactType.Enabled = chkStatusContactType.Checked;
            contactType.CreatedDate = DateTime.Now;

            db.ContactTypes.Add(contactType);
            var client = db.SaveChanges() > 0;
            if (client)
            {
                MessageBox.Show("The client type has been added!");
                GetContactType();
                DefaultControl();

                btAddContactType.Enabled = true;
                btSaveContactType.Enabled = false;
                btCancelContactType.Enabled = false;
                btSaveContactType.ForeColor = Color.Black;
                pnlFormContactType.Enabled = false;
                btUpdateContactType.Enabled = false;
                btDeleteContactType.Enabled = false;
                btUpdateContactType.Visible = false;
                btDeleteContactType.Visible = false;

            }
        }

        private void DefaultControl()
        {
            txtContactTypeDescription.Text = string.Empty;
            txtContactTypeName.Text = string.Empty;
            chkStatusContactType.Checked = false;
            chkStatusContactType.Text = "Enable";
        }

        private bool ValidateForm()
        {
            Msg = new List<string>();
            lblContactTypeName.Visible = false;
            lblContactTypeDescription.Visible = false;
            bool result = true;

            if (string.IsNullOrEmpty(txtContactTypeName.Text))
            {
                result = false;
                Msg.Add("The field (Client tipe name ) is requeried.");
                lblContactTypeName.Visible = true;
            }
            if (string.IsNullOrEmpty(txtContactTypeDescription.Text))
            {
                result = false;
                Msg.Add("The field (Client tipe description) is requeried.");
                lblContactTypeDescription.Visible = true;
            }
            return result;
        }

        private void btCancelContactType_Click(object sender, EventArgs e)
        {
            GetContactType();
            DefaultControl();

            btAddContactType.Enabled = true;
            btSaveContactType.Enabled = false;
            btCancelContactType.Enabled = false;
            btSaveContactType.ForeColor = Color.Black;
            pnlFormContactType.Enabled = false;
            btUpdateContactType.Enabled = false;
            btDeleteContactType.Enabled = false;
            btUpdateContactType.Visible = false;
            btDeleteContactType.Visible = false;

        }

        private void btAddContactType_Click(object sender, EventArgs e)
        {
            pnlFormContactType.Enabled = true;
            btAddContactType.Enabled = false;
            btSaveContactType.Enabled = true;
            btCancelContactType.Enabled = true;
            btSaveContactType.ForeColor = Color.Green;
            btUpdateContactType.Enabled = false;
            btDeleteContactType.Enabled = false;
            btUpdateContactType.Visible = false;
            btDeleteContactType.Visible = false;
        }

        private void btUpdateContactType_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de actualizar este registro!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (res.Equals(DialogResult.OK))
            {
                UpdateContactType(ContactTypeID);
            }
            else
            {
                btAddContactType.Enabled = false;
                pnlFormContactType.Enabled = true;
                btCancelContactType.Enabled = true;
                btSaveContactType.Enabled = true;
                btUpdateContactType.Enabled = false;
                btDeleteContactType.Enabled = false;
            }
        }

        private void UpdateContactType(int contactid)
        {
            var contactType = db.ContactTypes.FirstOrDefault(x => x.Id == contactid);
            contactType.Name = txtContactTypeName.Text;
            contactType.Description = txtContactTypeDescription.Text;
            contactType.Enabled = chkStatusContactType.Checked;
            contactType.CreatedDate = DateTime.Now;

            db.Entry(contactType).State = System.Data.Entity.EntityState.Modified;

            var client = db.SaveChanges() > 0;
            if (client)
            {
                MessageBox.Show("The client type has been added!");
                DefaultControl();

                btAddContactType.Enabled = true;
                btSaveContactType.Enabled = false;
                btCancelContactType.Enabled = false;
                btSaveContactType.ForeColor = Color.Black;
                pnlFormContactType.Enabled = false;
                btUpdateContactType.Enabled = false;
                btDeleteContactType.Enabled = false;
                btUpdateContactType.Visible = false;
                btDeleteContactType.Visible = false;
                GetContactType();

            }
        }

        private void GetContactTypeById(int contactTypeID)
        {
            DefaultControl();
            var contact = db.ContactTypes.FirstOrDefault(x => x.Id == contactTypeID);
            if (contact != null)
            {
                txtContactTypeName.Text = contact.Name;
                txtContactTypeDescription.Text = contact.Description;
                chkStatusContactType.Checked = contact.Enabled;
                chkStatusContactType.Text = contact.Enabled ? "SI" : "NO";
                lblDateContactType.Text = contact.CreatedDate.ToString("MM/dd/yyyy");
            }
        }

        private void dgvContactType_Click(object sender, EventArgs e)
        {

            ContactTypeID = 0;
            if (!string.IsNullOrEmpty(dgvContactType.SelectedRows[0].Cells["Id"].Value.ToString()))
            {
                ContactTypeID = int.Parse(dgvContactType.SelectedRows[0].Cells["Id"].Value.ToString());
                btUpdateContactType.Visible = true;
                btDeleteContactType.Visible = true;
                btUpdateContactType.Enabled = true;
                btDeleteContactType.Enabled = true;
                pnlFormContactType.Enabled = true;

                GetContactTypeById(ContactTypeID);

            }
            else
            {
                btUpdateContactType.Visible = false;
                btDeleteContactType.Visible = false;
                btUpdateContactType.Enabled = false;
                btDeleteContactType.Enabled = false;
            }
        }

        private void chkStatusContactType_CheckedChanged(object sender, EventArgs e)
        {
            chkStatusContactType.Text = chkStatusContactType.Checked ? "SI" : "NO";
        }

        private void btDeleteContactType_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de eliminar este registro!","", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (res.Equals(DialogResult.OK))
            {
                DeleteContactType(ContactTypeID);
            }
            btAddContactType.Enabled = true;
            pnlFormContactType.Enabled = false;
            btCancelContactType.Enabled = false;
            btSaveContactType.Enabled = false;
            btUpdateContactType.Enabled = false;
            btDeleteContactType.Enabled = false;
            btUpdateContactType.Visible = false;
            btDeleteContactType.Visible = false;
        }

        private void DeleteContactType(int contactTypeID)
        {
            DefaultControl();
            var client = db.ContactTypes.FirstOrDefault(x => x.Id == contactTypeID);
            db.ContactTypes.Remove(client);
            var res = db.SaveChanges() > 0;
            if (res)
            {
                MessageBox.Show("The client type has been added!");

                GetContactType();
                DefaultControl();
            }
        }
    }
}
