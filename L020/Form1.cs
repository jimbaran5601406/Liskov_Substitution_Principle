using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using L020.Objects;

namespace L020
{
    public partial class Form1 : Form
    {
        private MemberKind _loginMemberKind = MemberKind.Gold;
        private IMember _member;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _member = MemberFactory.Create(_loginMemberKind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(PriceTextBox.Text);
            button1.Text = _member.GetPoint(price).ToString();
        }
    }
}
