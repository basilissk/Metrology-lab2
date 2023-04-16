using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace lab1
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        MatchCollection conditionalOperatorsMatches;
        MatchCollection operatorsMatches;
        MatchCollection switchMathes;

        Dictionary<string, int> operatorsHash = new Dictionary<string, int>();
        Dictionary<string, int> conditionalOperatorsHash = new Dictionary<string, int>();

        string code = "";
        int operatorsCount = 0;
        int conditionalOperatorsCount = 0;
        int maxMastedLevel = 0;
      
        public Form1()
        {
            InitializeComponent();

            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 2;

        }

        static string DeleteComments(string text)
        {
            return Regex.Replace(text, "/\\*.*?\\*/|//.*\r\n", "");
        }

        static string DeleteIncludes(string text)
        {
            return Regex.Replace(text, "#include.*\r?\n", "");
        }

        static string DeleteUsing(string text)
        {
            return Regex.Replace(text, "using.*\r?\n", "");
        }

        static void AddToHash(Match match, Dictionary<string, int> HashMap)
        {
            HashMap[match.Value] = HashMap.ContainsKey(match.Value) ? HashMap[match.Value] + 1 : 1;
        }

        void Analys()
        {
            Regex switchReg = new Regex("switch");
            Regex operators = new Regex(@"!=|==|=");
            Regex conditionalOperators = new Regex("else if|if|case|while|for");

            code = DeleteComments(code);
            code = DeleteIncludes(code);
            code = DeleteUsing(code);

            operatorsMatches = operators.Matches(code);
            conditionalOperatorsMatches = conditionalOperators.Matches(code);
            switchMathes = switchReg.Matches(code);

            operatorsHash.Clear();
            conditionalOperatorsHash.Clear();
            
         
            foreach (Match match in operatorsMatches)
            {
                AddToHash(match, operatorsHash);
            }

            foreach (Match match in conditionalOperatorsMatches)
            {
                AddToHash(match, conditionalOperatorsHash);
            }

        }

        private void bAnalys_Click(object sender, EventArgs e)
        {

            int rowCount = 0;
            int rowInd = 0;

            Analys();

            rowCount = operatorsHash.Count + conditionalOperatorsHash.Count;
            rowCount++;
            table.RowCount = rowCount;

            for (int i = 0; i < rowCount; i++)
            {
                table[0, i].Value = i + 1 + ".";
                table[3, i].Value = i + 1 + ".";
            }

            foreach (KeyValuePair<string, int> kvp in operatorsHash)
            {
                table[1, rowInd].Value = kvp.Key;
                table[2, rowInd].Value = kvp.Value;
                rowInd++;
            }

            foreach (KeyValuePair<string, int> kvp in conditionalOperatorsHash)
            {
                table[1, rowInd].Value = kvp.Key;
                table[2, rowInd].Value = kvp.Value;

                rowInd++;
            }

            rowInd = 0;
            rowInd = table.RowCount - 1;
            
           
            operatorsCount = GetOperatorsAmount(operatorsHash,operatorsMatches);
            conditionalOperatorsCount = conditionalOperatorsMatches.Count - switchMathes.Count;
            maxMastedLevel = CalculateMaxNestedLevel(code);
            textBox1.Text = $"CL = {conditionalOperatorsCount}\r\n" +
                $"cl = {((float)conditionalOperatorsCount / (operatorsCount + conditionalOperatorsCount)):F2}\r\n" +
                $"CLI = {maxMastedLevel}\r\n";
        }

        private void bSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    code = reader.ReadToEnd();
                }

                bAnalys.Enabled = true;

                tBSourceText.Text = code;

            }
            else
            {
                bAnalys.Enabled = false;
            }
        }

        static int GetOperatorsAmount(Dictionary<string, int> hash, MatchCollection match)
        {
            int amount = 0;
            
            foreach (KeyValuePair<string, int> kvp in hash)
            {
                if (kvp.Key == "==" || kvp.Key == "!=") amount+=kvp.Value;
            }
            return match.Count - amount;
        }

        static int CalculateMaxNestedLevel(string code)
        {
           
            return 0;
        }



    }
}
