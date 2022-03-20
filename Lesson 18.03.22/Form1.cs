using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lesson_18._03._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet data_chr = new DataSet();
            //не ругайтесь, пожалуйста, на полный путь к файлу, он у меня лежит в bin-debug, но когда я запускаю прогу, то 
            //у меня выходит икслючение, что этот файл не найден((( поэтому написала так, иначе не работало бы
            data_chr.ReadXml(@"C:\Users\asus\OneDrive\Рабочий стол\прога\2 семестр\Lesson 18.03.22\Lesson 18.03.22\bin\Debug\christian.xml");
            ChristianTable.DataSource = data_chr.Tables[0];
            DataSet data_mus = new DataSet();
            data_mus.ReadXml(@"C:\Users\asus\OneDrive\Рабочий стол\прога\2 семестр\Lesson 18.03.22\Lesson 18.03.22\bin\Debug\muslim.xml");
            MuslimTable.DataSource = data_mus.Tables[0];
            DataSet data_sec = new DataSet();
            data_sec.ReadXml(@"C:\Users\asus\OneDrive\Рабочий стол\прога\2 семестр\Lesson 18.03.22\Lesson 18.03.22\bin\Debug\securities.xml");
            SecurityTable.DataSource = data_sec.Tables[0];
        }
    }
}
