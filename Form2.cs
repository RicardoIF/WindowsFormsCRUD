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
    public partial class Form2 : Form
    {
        INTEC_AGU_OCT22Entities db = new INTEC_AGU_OCT22Entities();
        List<string> Msg = new List<string>();
        int ClientTypeID = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblDateClientTypeUpp.Text = DateTime.Now.ToString("F");
            lblDateClientType.Text = DateTime.Now.ToString("F");
            GetClientType();
        }

        private void GetClientType()
        {
            var clientType = db.ClientTypes.ToList();
            dgvClientType.DataSource = clientType;
        }

        private void btSaveClientType_Click(object sender, EventArgs e)
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
            var clientType = new ClientType();
            clientType.Name = txtClientTypeName.Text;
            clientType.Description = txtClientTypeDescription.Text;
            clientType.Enabled = chkStatusClientType.Checked;
            clientType.CreatedDate = DateTime.Now;

            db.ClientTypes.Add(clientType);
            var client = db.SaveChanges() > 0;
            if (client)
            {
                MessageBox.Show("The client type has been added!");
                GetClientType();
                DefaultControl();

                btAddClientType.Enabled = true;
                btSaveClientType.Enabled = false;
                btCancelClentType.Enabled = false;
                btSaveClientType.ForeColor = Color.Black;
                pnlFormClientType.Enabled = false;
            }
        }

        private void DefaultControl()
        {
            txtClientTypeDescription.Text = string.Empty;
            txtClientTypeName.Text = string.Empty;
            chkStatusClientType.Checked = false;
            chkStatusClientType.Text = "Enable";
        }

        private bool ValidateForm()
        {
            Msg = new List<string>();
            lblClientTypeName.Visible = false;
            lblClientTypeDescription.Visible = false;
            bool result = true;

            if (string.IsNullOrEmpty(txtClientTypeName.Text))
            {
                result = false;
                Msg.Add("The field (Client tipe name ) is requeried.");
                lblClientTypeName.Visible = true;
            }
            if (string.IsNullOrEmpty(txtClientTypeDescription.Text))
            {
                result = false;
                Msg.Add("The field (Client tipe description) is requeried.");
                lblClientTypeDescription.Visible = true;
            }
            return result;
        }

        private void btCancelClentType_Click(object sender, EventArgs e)
        {
            GetClientType();
            DefaultControl();

            btAddClientType.Enabled = true;
            btSaveClientType.Enabled = false;
            btCancelClentType.Enabled = false;
            btSaveClientType.ForeColor = Color.Black;
            pnlFormClientType.Enabled = false;
        }

        private void btAddClientType_Click(object sender, EventArgs e)
        {
            pnlFormClientType.Enabled = true;
            btAddClientType.Enabled = false;
            btSaveClientType.Enabled = true;
            btCancelClentType.Enabled = true;
            btSaveClientType.ForeColor = Color.Green;
        }

        private void btUpdateClientType_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de actualizar este registro!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (res.Equals(DialogResult.OK))
            {
                UpdateClientType(ClientTypeID);
            }
        }

        private void UpdateClientType(int clientTypeID)
        {
            var clientType = db.ClientTypes.FirstOrDefault(x => x.Id == clientTypeID);
            clientType.Name = txtClientTypeName.Text;
            clientType.Description = txtClientTypeDescription.Text;
            clientType.Enabled = chkStatusClientType.Checked;
            clientType.CreatedDate = DateTime.Now;

            db.Entry(clientType).State = System.Data.Entity.EntityState.Modified;

            var client = db.SaveChanges() > 0;
            if (client)
            {
                MessageBox.Show("The client type has been added!");
                DefaultControl();

                btAddClientType.Enabled = true;
                btSaveClientType.Enabled = false;
                btCancelClentType.Enabled = false;
                btSaveClientType.ForeColor = Color.Black;
                pnlFormClientType.Enabled = false;
                btUpdateClientType.Enabled = false;
                btDeleteClientType.Enabled = false;
                btUpdateClientType.Visible = false;
                btDeleteClientType.Visible = false;
                GetClientType();
            }
        }

        private void GetClientTypeById(int clientid)
        {
            DefaultControl();
            var client = db.ClientTypes.FirstOrDefault(x => x.Id == clientid);
            if (client != null)
            {
                txtClientTypeName.Text = client.Name;
                txtClientTypeDescription.Text = client.Description;
                chkStatusClientType.Checked = client.Enabled;
                chkStatusClientType.Text = client.Enabled ? "SI" : "NO";
                lblDateClientType.Text = client.CreatedDate.ToString("MM/dd/yyyy");
            }
        }

        private void dgvClientType_Click(object sender, EventArgs e)
        {
            ClientTypeID = 0;
            if (!string.IsNullOrEmpty(dgvClientType.SelectedRows[0].Cells["Id"].Value.ToString()))
            {
                ClientTypeID = int.Parse(dgvClientType.SelectedRows[0].Cells["Id"].Value.ToString());
                btUpdateClientType.Visible = true;
                btDeleteClientType.Visible = true;
                btUpdateClientType.Enabled = true;
                btDeleteClientType.Enabled = true;
                pnlFormClientType.Enabled = true;
                GetClientTypeById(ClientTypeID);
            }
            else
            {
                btUpdateClientType.Visible = false;
                btDeleteClientType.Visible = false;
                btUpdateClientType.Enabled = false;
                btDeleteClientType.Enabled = false;
            }
        }

        private void chkStatusClientType_CheckedChanged(object sender, EventArgs e)
        {
            chkStatusClientType.Text = chkStatusClientType.Checked ? "SI" : "NO";
        }

        private void btDeleteClientType_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de eliminar este registro!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (res.Equals(DialogResult.OK))
            {
                DeleteClientType(ClientTypeID);
            }
        }

        private void DeleteClientType(int clientTypeID)
        {
            DefaultControl();
            var client = db.ClientTypes.FirstOrDefault(x => x.Id == clientTypeID);
            db.ClientTypes.Remove(client);
            var res = db.SaveChanges() > 0;
            if (res)
            {
                MessageBox.Show("The client type has been added!");

                GetClientType();
                DefaultControl();

                btAddClientType.Enabled = true;
                pnlFormClientType.Enabled = false;
                btCancelClentType.Enabled = false;
                btSaveClientType.Enabled = false;
                btUpdateClientType.Enabled = false;
                btDeleteClientType.Enabled = false;

            }
        }
    }
}
