using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace JSON
{
    public partial class Form1 : Form
    {
        protected Christian christian;
        public Form1()
        {
            InitializeComponent();
        }
        private void Initialize()
        {
            new ChristianProvider().Provide(out Christian christian_obj);
            christian = christian_obj;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
