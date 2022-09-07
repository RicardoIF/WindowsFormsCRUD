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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetContactType();
            GetClientType();
            GetPermissions();
            GetRestriction();
        }

        private void GetRestriction()
        {
            var restrictions  = db.Restrictions.ToList();
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
    }
}
