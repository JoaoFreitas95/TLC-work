using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.commons;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MyParser MyParser = new MyParser();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Button "Check"
            button1.Enabled = false;

            if (MyParser.Parse(new StringReader(richTextBox1.Text)))
            {
                DrawReductionTree(MyParser.Root);
            }
            else
            {
                Parse_Tree_textBox.Text = MyParser.FailMessage;
            }

            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Loads EGT enabeling action => "Browse" and "Check"
            MyParser.Setup(Application.StartupPath + "\\project 1.egt");
            button3.Enabled = false;
        }

        private void DrawReductionTree(GOLD.Reduction Root)
        {
            //This procedure starts the recursion that draws the parse tree.
            StringBuilder tree = new StringBuilder();

            tree.AppendLine("+-" + Root.Parent.Text(false));
            DrawReduction(tree, Root, 1);

            Parse_Tree_textBox.Text = tree.ToString();
        }

        private void DrawReduction(StringBuilder tree, GOLD.Reduction reduction, int indent)
        {
            //Recursive procedure that draws an ASCII version of the parse
            //Tree
            int n;
            string indentText = "";

            for (n = 1; n <= indent; n++)
            {
                indentText += "| ";
            }

            //Displays the children of the reduction
            for (n = 0; n < reduction.Count(); n++)
            {
                switch (reduction[n].Type())
                {
                    case GOLD.SymbolType.Nonterminal:
                        GOLD.Reduction branch = (GOLD.Reduction)reduction[n].Data;

                        tree.AppendLine(indentText + "+-" + branch.Parent.Text(false));
                        DrawReduction(tree, branch, indent + 1);
                        break;

                    default:
                        string leaf = (string)reduction[n].Data;

                        tree.AppendLine(indentText + "+-" + leaf);
                        break;
                }
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();//Enables file browse and select

        private void button2_Click(object sender, EventArgs e)
        {
            //Button "Browse"
            ofd.Filter = "TXT|*.txt";//Filter to only show type=txt
            ofd.ShowDialog();//Shows file modally
            textBox2.Text = ofd.FileName;//Save file name
            textBox3.Text = ofd.SafeFileName;//Save file location
            if (textBox2.Text != null) { button3.Enabled = true; }//Enables file load
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            //Button "Load"
            Stream myStream;//Enables read file

                if((myStream = ofd.OpenFile()) != null)
                {
                    string strfilename = textBox2.Text;//File name
                    string fileText = File.ReadAllText(strfilename);//Reads file text
                    richTextBox1.Text = fileText;//Displays file text
                }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
