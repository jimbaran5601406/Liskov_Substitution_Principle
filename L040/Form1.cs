using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using L040.Objects;

namespace L040
{
    public partial class Form1 : Form
    {
        private Member.MemberKind _loginMemberKind = Member.MemberKind.Gold;
        private Member _member;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _member = Member.Create(_loginMemberKind);
            this.Text = _loginMemberKind.ToString() + _member.GetId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(PriceTextBox.Text);
            button1.Text = _member.GetPoint(price).ToString();

            var gold = _member as Gold;
            if (gold != null)
            {
                button1.Text = gold.GetDoublePoint(price).ToString();
            }

            var platinum = _member as Gold;
            if (platinum != null)
            {
                button1.Text = platinum.GetDoublePoint(price).ToString();
            }
        }
    }
}
