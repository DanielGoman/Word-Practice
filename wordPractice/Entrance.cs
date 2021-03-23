using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordPractice
{
    public partial class Entrance : Form
    {
        public static Random rand;
        public static List<Unit.Word>[] english_units = new List<Unit.Word>[10];
        public static List<Unit.Word>[] hebrew_units = new List<Unit.Word>[11];
        public Entrance()
        {
            InitializeComponent();
            rand = new Random();
        }

        private void hebrewClick(object sender, EventArgs e)
        {
            UnitSelection hebrewMode = new UnitSelection(UnitSelection.HEBREW_MODE);
            hebrewMode.Owner = this;        //Setting the parent form to the new form
            this.Hide();
            hebrewMode.ShowDialog();        //Showing the new form    
        }

        private void englishClick(object sender, EventArgs e)
        {
            UnitSelection englishMode = new UnitSelection(UnitSelection.ENGLISH_MODE);
            englishMode.Owner = this;
            this.Hide();
            englishMode.ShowDialog();
        }

        private void Entrance_Load(object sender, EventArgs e)
        {

        }
    }
}
