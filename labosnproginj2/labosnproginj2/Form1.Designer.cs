namespace labosnproginj2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавнаяБукваТочкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всехКорректныхЭлектронныхАдресовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.форматироватьToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // форматироватьToolStripMenuItem
            // 
            this.форматироватьToolStripMenuItem.Name = "форматироватьToolStripMenuItem";
            this.форматироватьToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.форматироватьToolStripMenuItem.Text = "Форматировать";
            this.форматироватьToolStripMenuItem.Click += new System.EventHandler(this.форматироватьToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияToolStripMenuItem,
            this.вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавнаяБукваТочкаToolStripMenuItem,
            this.хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem,
            this.адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem,
            this.интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem,
            this.целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem,
            this.вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem,
            this.комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem,
            this.всехКорректныхЭлектронныхАдресовToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияToolStripMenuItem
            // 
            this.вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияToolStripMenuItem.Name = "вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияTo" +
    "olStripMenuItem";
            this.вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияToolStripMenuItem.Size = new System.Drawing.Size(728, 22);
            this.вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияToolStripMenuItem.Text = "вхождения двух слов, начинающихся с заглавных букв и разделенных одним (!) пробел" +
    "ом (имя и фамилия)";
            this.вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияToolStripMenuItem.Click += new System.EventHandler(this.вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияToolStripMenuItem_Click);
            // 
            // вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавнаяБукваТочкаToolStripMenuItem
            // 
            this.вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавнаяБукваТочкаToolStripMenuItem.Name = "вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавная" +
    "БукваТочкаToolStripMenuItem";
            this.вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавнаяБукваТочкаToolStripMenuItem.Size = new System.Drawing.Size(728, 22);
            this.вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавнаяБукваТочкаToolStripMenuItem.Text = "вхождение фамилии с инициалами (слово с заглавной буквы, пробел, заглавная буква," +
    " точка, заглавная буква, точка)";
            this.вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавнаяБукваТочкаToolStripMenuItem.Click += new System.EventHandler(this.вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавнаяБукваТочкаToolStripMenuItem_Click);
            // 
            // хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem
            // 
            this.хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem.Name = "хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem";
            this.хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem.Size = new System.Drawing.Size(728, 22);
            this.хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem.Text = "хотя бы одного из ключевых слов языка C#";
            this.хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem.Click += new System.EventHandler(this.хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem_Click);
            // 
            // адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem
            // 
            this.адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem.Name = "адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem";
            this.адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem.Size = new System.Drawing.Size(728, 22);
            this.адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem.Text = " адреса в соответствии с правилами указания почтовых адресов в Украине";
            this.адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem.Click += new System.EventHandler(this.адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem_Click);
            // 
            // интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem
            // 
            this.интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem.Name = "интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem";
            this.интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem.Size = new System.Drawing.Size(728, 22);
            this.интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem.Text = "интернет адресов из доменных зон edu.ua, net.ua, com.ua, in.ua, org.ua";
            this.интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem.Click += new System.EventHandler(this.интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem_Click);
            // 
            // целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem
            // 
            this.целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Name = "целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem";
            this.целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Size = new System.Drawing.Size(728, 22);
            this.целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Text = "целочисленных констант, заключенных в двойные или одинарные кавычки";
            this.целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Click += new System.EventHandler(this.целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem_Click);
            // 
            // вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem
            // 
            this.вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Name = "вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem";
            this.вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Size = new System.Drawing.Size(728, 22);
            this.вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Text = "вещественных констант, заключенных в двойные или одинарные кавычки.";
            this.вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Click += new System.EventHandler(this.вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem_Click);
            // 
            // комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem
            // 
            this.комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Name = "комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem";
            this.комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Size = new System.Drawing.Size(728, 22);
            this.комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Text = "комплексных констант, заключенных в двойные или одинарные кавычки";
            this.комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem.Click += new System.EventHandler(this.комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem_Click);
            // 
            // всехКорректныхЭлектронныхАдресовToolStripMenuItem
            // 
            this.всехКорректныхЭлектронныхАдресовToolStripMenuItem.Name = "всехКорректныхЭлектронныхАдресовToolStripMenuItem";
            this.всехКорректныхЭлектронныхАдресовToolStripMenuItem.Size = new System.Drawing.Size(728, 22);
            this.всехКорректныхЭлектронныхАдресовToolStripMenuItem.Text = "всех корректных электронных адресов";
            this.всехКорректныхЭлектронныхАдресовToolStripMenuItem.Click += new System.EventHandler(this.всехКорректныхЭлектронныхАдресовToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя файла";
            this.label1.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(301, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя файла";
            this.label2.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(81, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(214, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(301, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "OK";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(559, 656);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(599, 21);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(591, 656);
            this.richTextBox2.TabIndex = 16;
            this.richTextBox2.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "text files|*.txt|RTF files|*.rtf|all files|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1202, 707);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text_editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вхожденияДвухСловНачинающихсяСЗаглавныхБуквИРазделенныхОднимПробеломимяИФамилияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вхождениеФамилииСИнициаламисловоСЗаглавнойБуквыПробелЗаглавнаяБукваТочкаЗаглавнаяБукваТочкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хотяБыОдногоИзКлючевыхСловЯзыкаCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адресаВСоответствииСПравиламиУказанияПочтовыхАдресовВУкраинеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интернетАдресовИзДоменныхЗонEduuaNetuaComuaInuaOrguaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem целочисленныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вещественныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem комплексныхКонстантЗаключенныхВДвойныеИлиОдинарныеКавычкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всехКорректныхЭлектронныхАдресовToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

