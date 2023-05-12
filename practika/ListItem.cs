using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practika
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private string _ProductName;
        private string _ProductDecember;
        private string _ProductManifacture;
        private string _ProductCost;
        private string _InStore;
        private Image _icon;




        public string PName
        {
            get { return _ProductName; }
            set { _ProductName = value; ProductName.Text = value; }
        }
        public string December
        {
            get { return _ProductDecember; }
            set { _ProductDecember = value; ProductDecember.Text = value; }
        }
        public string Manifacture
        {
            get { return _ProductManifacture; }
            set { _ProductManifacture = value; ProductManifacture.Text = value; }
        }
        public string Cost
        {
            get { return _ProductCost; }
            set { _ProductCost = value; ProductCost.Text = value; }
        }
        public string Store
        {
            get { return _InStore; }
            set { _InStore = value; InStore.Text = value; }
        }
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }
    }
}
