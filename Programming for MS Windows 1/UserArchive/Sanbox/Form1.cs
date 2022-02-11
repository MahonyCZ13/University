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
using System.Threading;
using System.Globalization;
using System.Resources;

namespace UserArchive
{
    
    public partial class Form1 : Form
    {
        // Deklarujeme si zdrojovy dokument
        ResourceManager rm = new ResourceManager(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }
        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string City = lstCity.GetItemText(lstCity.SelectedItem);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Nacteme si lokalizacni retezce
            string question = rm.GetString("closeQuestion");
            string closeTitle = rm.GetString("closeTitle");

            // Pred ukoncenim aplikace se zeptame uzivatele
            if (MessageBox.Show(question, closeTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
            // Inicializujeme a deklarujeme promenne
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string city = lstCity.GetItemText(lstCity.SelectedItem);
            string gender;
            string programming = "";
            string driving = "";
            string languages = "";

            // Zkontrolujeme o jake radio se jedna
            if (rdMale.Checked) gender = rdMale.Text;
            else gender = rdFemale.Text;

            // Overime zaskrtnute checkboxy
            if (chkProgramming.Checked) programming = chkProgramming.Text;
            if (chkDriving.Checked) driving = chkDriving.Text;
            if (chkLanguages.Checked) languages = chkLanguages.Text;

            // Vytvorime si nazev a cestu pro ulozeni souboru
            string file = "export_" + surname + ".txt";
            string path = @"C:\Users\user\Documents\" + file;

            // Na kazdou radku si napiseme udaje z formulare
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(name);
                sw.WriteLine(surname);
                sw.WriteLine(city);
                sw.WriteLine(gender);
                sw.WriteLine(programming);
                sw.WriteLine(driving);
                sw.WriteLine(languages);
            }

            // Aktualizujeme notifikaci
            ExportedMessage();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Zeptame se uzivatele, jaky soubor chce nahrat
            OpenFileDialog od = new OpenFileDialog();


            od.InitialDirectory = @"C:\Users\user\Documents\";
            od.Filter = "Text Files|*.txt";
            od.ShowDialog();         

            string path = od.FileName;
            string name, surname, city, gender, programming, driving, languages;
            string genderCtrl = rm.GetString("rdMale.Text");
            
            // Precteme kazdy radek souboru a naplnime promenne
            using(StreamReader sr = new StreamReader(path))
            {
                name = sr.ReadLine();
                surname = sr.ReadLine();
                city = sr.ReadLine();
                gender = sr.ReadLine();
                programming = sr.ReadLine();
                driving = sr.ReadLine();
                languages = sr.ReadLine();
            }

            // Naplnime formular
            txtName.Text = name;
            txtSurname.Text = surname;
            lstCity.Text = city;

            // Overime si radio
            //if (gender == "Male" || gender == "Muž") rdMale.Checked = true;
            if (gender == genderCtrl) rdMale.Checked = true;
            else rdFemale.Checked = true;

            // Overime si checkboxy
            if (programming != "") chkProgramming.Checked = true;
            if (driving != "") chkDriving.Checked = true;
            if (languages != "") chkLanguages.Checked = true;

            // Aktualizujeme notifikaci
            ImportedMessage();

        }
        public void ImportedMessage()
        {
            // Nastavime label na pozadovanou hodnotu a obarvime na zeleno
            lblAction.Text = rm.GetString("messageImported");
            lblAction.ForeColor = Color.Green;
            lblAction.Font = new Font(DefaultFont, FontStyle.Bold);
        }

        public void ExportedMessage()
        {
            // Nastavime label na pozadovanou hodnotu a obarvime na zeleno
            lblAction.Text = rm.GetString("messageExported");
            lblAction.ForeColor = Color.Green;
            lblAction.Font = new Font(DefaultFont, FontStyle.Bold);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nastaveni jazyka
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    // NENI MOJE TVORBA
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("cs-CZ");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("cs-CZ");   
                    break;
                case 1:
                    // NENI MOJE TVORBA
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    break;

            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            string question = rm.GetString("closeQuestion");
            string closeTitle = rm.GetString("closeTitle");

            if (MessageBox.Show(question, closeTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Dialogove okno pro informace o programu
            About ab = new About();
            ab.ShowDialog();
        }
    }
}
