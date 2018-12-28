using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace labosnproginj2
{

    public partial class Form1 : Form
    {
        private static Form1 single = null;
        public static Form1 Instance()
        {

            single = new Form1();
            return single;
        }

        public static Form1 Close()
        {

            if (single != null)
            {
                single = null;
            }
            return single;
        }
        string filename, filename2;
        string txt, str1 = "аоиёеэыуюяАОИЁЕЭЫУЮЯ", str2 = "цкнгшщзхфвпрлджчсмтбйЦКНГШЩЗХФВПРЛДЖЧСМТБЙ",
            str3 = "aeiouAEIOU", str4 = "qwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNM", str5 = "1234567890",
            str6 = "/“”[](){}‘’@#$%^&*-+|=~_", str7 = ".,:;!?—", str8 = "аоиёеэыуюяцкнгшщзхфвпрлджчсмтбйЦКНГШЩЗХФВПРЛДЖЧСМТБЙАОИЁЕЭЫУЮЯ",
            str9 = "aeiouqwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNMAEIOU";
        string fileFormat;
        public Form1()
        {
            InitializeComponent();
        }

        private long FileSize()
        {
            FileInfo file = new FileInfo(filename);
            long a = file.Length / 1024;
            return a;
        }

        private int ColChar()
        {
            string file = File.ReadAllText(filename);
            int col = file.Length;
            return col;
        }

        private int ColAbz()
        {
            string file = File.ReadAllText(filename);
            string[] Lines = file.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int a = Lines.Length;
            
            return a;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // label2.Show();
            // textBox4.Show();
            // button7.Show();

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write_text;
                FileInfo file = new FileInfo(saveFileDialog1.FileName);
                write_text = file.AppendText();
                write_text.WriteLine(richTextBox2.Text);
                write_text.Close();
                this.Text = openFileDialog1.FileName;
            }
        }

        public void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch(System.ArgumentException ex)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = openFileDialog1.FileName;
                filename = openFileDialog1.FileName;
            }
            /*Form2 fm2 = new Form2();
            fm2.Show();
            */
           // label1.Show();
           //textBox3.Show();
          //  button6.Show();



              /*  txt = File.ReadAllText(filename, Encoding.Default);
                int a = txt.Length;
                textBox1.Text = txt;*/
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            filename2 = textBox4.Text;
            File.WriteAllText(filename2, fileFormat, Encoding.Default);
            label2.Hide();
            textBox4.Hide();
            button7.Hide();
        }

        private void форматироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileFormat = File.ReadAllText(filename, Encoding.Default);
            //  fileFormat = Regex.Replace(fileFormat, @"\s+", " ");
            fileFormat = Regex.Replace(fileFormat, @"     ", "");
            fileFormat = Regex.Replace(fileFormat, @"    ", " ");
            fileFormat = Regex.Replace(fileFormat, @"   ", " ");
            fileFormat = Regex.Replace(fileFormat, @"  ", " ");
            fileFormat = Regex.Replace(fileFormat, @"\t+", " ");
            fileFormat = Regex.Replace(fileFormat, @"^\s*(\r\n|\Z)", "", RegexOptions.Multiline);
            // fileFormat = Regex.Replace(fileFormat, @"\s+(?=\.)|\s+(?=\@)", "");
            //   fileFormat = Regex.Replace(fileFormat, @"\.\s+", ".");
            //   fileFormat = Regex.Replace(fileFormat, @"\@\s+", "@");
            richTextBox2.Text = fileFormat;
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s1 = Convert.ToString(FileSize());
            string s2 = Convert.ToString(ColChar());
            string s3 = Convert.ToString(ColAbz());
            string s4 = Convert.ToString(ColNullStr());
            string s5 = Convert.ToString(ColAvtorPage());
            string s6 = Convert.ToString(ColCharAll(str1));
            string s7 = Convert.ToString(ColCharAll(str2));
            string s8 = Convert.ToString(ColCharAll(str3));
            string s9 = Convert.ToString(ColCharAll(str4));
            string s10 = Convert.ToString(ColCharAll(str5));
            string s11 = Convert.ToString(ColCharAll(str6));
            string s12 = Convert.ToString(ColCharAll(str7));
            string s13 = Convert.ToString(ColCharAll(str8));
            string s14 = Convert.ToString(ColCharAll(str9));
            MessageBox.Show("Статистика"
                + "\n\n\n" + "Размер файла:" + s1 + " Кб"
                + "\n" + "Количество символов в файле:" + s2
                + "\n" + "Количество абзацев в файле:" + s3
                + "\n" + "Количество пустых строк в файле:" + s4
                + "\n" + "Количество авторских страниц в файле:" + s5
                + "\n" + "Количество гласных букв кирилицей файле:" + s6
                + "\n" + "Количество согласных букв кирилицей файле:" + s7
                + "\n" + "Количество гласных букв латиницей файле:" + s8
                + "\n" + "Количество согласных букв латиницей файле:" + s9
                + "\n" + "Количество цифр в файле:" + s10
                + "\n" + "Количество спецсимволов файле:" + s11
                + "\n" + "Количество знаков пунктуации файле:" + s12
                + "\n" + "Количество букв кириллицей файле:" + s13
                + "\n" + "Количество букв латиницей файле:" + s14);
        }

        private void вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reg1 = @"[А-Я]{1}[а-я]{1,14} [А-Я]{1}[а-я]{1,14}";
            string s1 = FunckRegex(reg1);
            //MessageBox.Show(s1 + "\n");
            if (richTextBox1.Find(s1) > 0)
            {
                int my1stPosition = richTextBox1.Find(s1);
                richTextBox1.SelectionStart = my1stPosition;
                richTextBox1.SelectionLength = s1.Length;
                richTextBox1.SelectionColor = Color.Red;
            }

        }

        private void вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавнаяБукваТочкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reg2 = @"[А-Я][а-я]+\s[А-Я]\.[А-Я]\.";
            string s2 =FunckRegex(reg2);
            if (richTextBox1.Find(s2) > 0)
            {
                int my1stPosition = richTextBox1.Find(s2);
                richTextBox1.SelectionStart = my1stPosition;
                richTextBox1.SelectionLength = s2.Length;
                richTextBox1.SelectionColor = Color.Orange;
            }

        }

        private void хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reg3 = @"char| if | break |string";
            string s3 = FunckRegex(reg3);
            if (richTextBox1.Find(s3) > 0)
            {
                int my1stPosition = richTextBox1.Find(s3);
                richTextBox1.SelectionStart = my1stPosition;
                richTextBox1.SelectionLength = s3.Length;
                richTextBox1.SelectionColor = Color.Red;
            }
        }

        private void адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reg4 = @"[а-я]{2}\.\s[А-Я]{1}[а-я]{1,15}\,\s[а-я]{1}\.\s[0-9]{1,4}\,\s[а-я]{2}\.\s[0-9]{1,4}\,\s[а-я]{1}\.\s[А-Я]{1}[а-я]{2,15}\,\s[0-9]{5}";
            string s4 = FunckRegex(reg4);
            if (richTextBox1.Find(s4) > 0)
            {
                int my1stPosition = richTextBox1.Find(s4);
                richTextBox1.SelectionStart = my1stPosition;
                richTextBox1.SelectionLength = s4.Length;
                richTextBox1.SelectionColor = Color.Pink;
            }
        }

        private void интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reg5 = @"[a-z]{3,15}\.edu.ua|[a-z]{3,15}\.net.ua|[a-z]{3,15}\.com.ua|[a-z]{3,15}\.in.ua|[a-z]{3,15}\.org.ua";
            string s5 = FunckRegex(reg5);
            if (richTextBox1.Find(s5) > 0)
            {
                int my1stPosition = richTextBox1.Find(s5);
                richTextBox1.SelectionStart = my1stPosition;
                richTextBox1.SelectionLength = s5.Length;
                richTextBox1.SelectionColor = Color.SeaGreen;
            }
        }

        private void целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reg6 = @"\‘[0-9]{1,9}\’|\“[0-9]{1,9}\”";
            string s6 = FunckRegex(reg6);
            if (richTextBox1.Find(s6) > 0)
            {
                int my1stPosition = richTextBox1.Find(s6);
                richTextBox1.SelectionStart = my1stPosition;
                richTextBox1.SelectionLength = s6.Length;
                richTextBox1.SelectionColor = Color.SkyBlue;
            }
        }

        private void вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reg7 = @"\’[0-9]{1,9}\.[0-9]{1,9}\’|\”[0-9]{1,9}\.[0-9]{1,9}\”";
            string s7 = FunckRegex(reg7);
            if (richTextBox1.Find(s7) > 0)
            {
                int my1stPosition = richTextBox1.Find(s7);
                richTextBox1.SelectionStart = my1stPosition;
                richTextBox1.SelectionLength = s7.Length;
                richTextBox1.SelectionColor = Color.Tan;
            }
        }

        private void комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reg8 = @"\‘[0-9]{1,9}\+[a-z]{1}\’|\”[0-9]{1,9}\-[0-9]{1,9}\*[a-z]{1}\”";
            string s8 = FunckRegex(reg8);
            if (richTextBox1.Find(s8) > 0)
            {
                int my1stPosition = richTextBox1.Find(s8);
                richTextBox1.SelectionStart = my1stPosition;
                richTextBox1.SelectionLength = s8.Length;
                richTextBox1.SelectionColor = Color.Violet;
            }
        }

        private void всехКорректныхЭлектронныхАдресовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reg9 = @"\s([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
@"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
@".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)";
            string s9 = FunckRegex(reg9);
            if (richTextBox1.Find(s9) > 0)
            {
                int my1stPosition = richTextBox1.Find(s9);
                richTextBox1.SelectionStart = my1stPosition;
                richTextBox1.SelectionLength = s9.Length;
                richTextBox1.SelectionColor = Color.Yellow;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3.count--;
           // count = count - 1;
        }

        public void button6_Click(object sender, EventArgs e)
        {
             filename = textBox3.Text;
            if (System.IO.File.Exists(filename))
            {
                txt = File.ReadAllText(filename, Encoding.Default);
                int a = txt.Length;
                richTextBox1.Text = txt;
                label1.Hide();
                textBox3.Hide();
                button6.Hide();
            }
            else
            {
                MessageBox.Show("Неверное имя файла");
            }

        }

        private int ColNullStr()
        {
            string[] file = File.ReadAllLines(filename);
            int count = 0;
            foreach (string s in file)
            {
                if (s == String.Empty)
                {
                    count++;
                }
            }
            return count;
        }



        private double ColAvtorPage()
        {
            string file = File.ReadAllText(filename);
            double a = file.Length;
            double col = a / 1800;
            return col;
        }



        private int ColCharAll(string str)
        {
            string file = File.ReadAllText(filename, Encoding.Default);
            int a = file.Length;
            char[] textFile = file.ToCharArray();
            int b = str.Length;
            char[] alf = str.ToCharArray();
            int count = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (textFile[i] == alf[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private string FunckRegex(string s)
        {
            string file = File.ReadAllText(filename, Encoding.Default);
            string s1 = Convert.ToString(Regex.Match(file, s));
            return s1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
                  
        }

    }
}
