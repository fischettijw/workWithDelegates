using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workWithDelegates
{
    public delegate string DelSSs(string s1, string s2);
    public delegate void DelSSv(string s1, string s2);

    public partial class FrmTesting : Form
    {
        public FrmTesting() { InitializeComponent(); }

        private void FrmTesting_Load(object sender, EventArgs e) { }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            ListBoxPrint p = new ListBoxPrint(LbxOutput);
            DelSSs testStringDel = new DelSSs(ConCatFunc);
            DelSSs anotherStrDel = new DelSSs(TwoString);
            DelSSv voidStrDel = new DelSSv(TwoStringVoid);
            p.Print(testStringDel("abc", "def"));
            p.Print(testStringDel("ABC", "DEF"));
            p.Print(StringDelPassed(5, testStringDel));
            p.Print(StringDelPassed(5, anotherStrDel));
            voidStrDel("123", "ABC");
        }

        public static string ConCatFunc(string str1, string str2) { return str1 + str2; }

        public static string TwoString(string s1, string s2) { return s2 + s1; }

        public void TwoStringVoid(string s1, string s2)
        {
            ListBoxPrint p = new ListBoxPrint(LbxOutput);
            p.Print("~~~~");
            p.Print(s1.RJ(10));
            p.Print(s2.RJ(10));
        }

        public static string StringDelPassed(int k, DelSSs del) { return del(k.RJ(5, '0'), (k + 1).RJ(5, '0')); }
    }
}
