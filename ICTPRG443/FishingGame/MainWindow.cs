using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.Extensions.Logging.Internal;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FishingGame
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class FishAttr
        {
            public uint Index { get; set; }
            public String? Name { get; set; }
            public char IsKeeper { get; set; }
            public char IsFish { get; set; }
            public int AmtKept { get; set; }
            public int AmtReleased { get; set; }
        }

        public class ImportData
        {
            public int Points { get; set; }
            public String? KoR { get; set; }
            public String? Name { get; set; }
        }

        private readonly List<FishAttr> fishAttrList = new();

        
        private void ClearGenFish()
        {
            numberGenDisplay.Clear();
            fishNameDisplay.Clear();
            pointsEarnedDisplay.Clear();
        }
        

        private void UpdateTotals()
        {
            TotalFishCaught.Text = ViewFishCaught.Items.Count.ToString();
            TotalPointsEarned.Text = ViewFishCaught.Items.Cast<ListViewItem>().Sum(item => int.Parse(item.SubItems[0].Text)).ToString();
        }


        private int GetReleasedAmount(String fishName)
        {
            if (String.IsNullOrEmpty(fishName) == false)
            {
                foreach (var fishFind in fishAttrList)
                {
                    if (String.IsNullOrEmpty(fishFind.Name) == true)
                    {
                        return 0;
                    }
                    else if (fishFind.Name.Equals(fishName) == true)
                    {
                        return fishFind.AmtReleased;
                    }
                }
            }
            return 0;
        }

        public void Log(String message)
        {
            var stackTrace = new StackTrace();
            var caller = stackTrace.GetFrame(1).GetMethod().Name;
            Debug.WriteLine(caller + ": " + message);
        }


        private void LoadWindow(object sender, EventArgs e)
        {
            StreamReader reader = new("fishData.csv");
            CsvReader csv = new(reader, CultureInfo.InvariantCulture);
            FishAttr fishData;

            label9.Text = loginform.username;

            csv.Read();
            csv.ReadHeader();
            while (csv.Read() == true)
            {
                fishData = new FishAttr
                {
                    Index = csv.GetField<uint>("Index"),
                    Name = csv.GetField("Name"),
                    IsKeeper = csv.GetField<char>("Keeper Y/N"),
                    IsFish = csv.GetField<char>("Fish Y/N"),
                    AmtKept = csv.GetField<int>("Points if kept"),
                    AmtReleased = csv.GetField<int>("Points if released")
                };
                fishAttrList.Add(fishData);
            }

        }

        private void ButtonUserLogOut(object sender, EventArgs e)
        {
            DialogResult logoutdialog = MessageBox.Show("are you sure you wanna log out?", "Logout", MessageBoxButtons.YesNo);

            this.Hide();
            new loginform().Show();



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonUserSave(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new()
            {
                Filter = "Comma Seperated Value Files (*.csv)|*.csv",
                RestoreDirectory = true
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    StreamWriter sw = new StreamWriter(saveDialog.FileName);
                    sw.WriteLine("Points,KoR,Name");
                    foreach (ListViewItem item in ViewFishCaught.Items)
                    {
                        sw.WriteLine(item.Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text);
                    }
                    sw.Close();
                    CurrentLoadedFile.Text = Path.GetFileName(saveDialog.FileName);
                }
                catch (IOException ex)
                {
                    Log(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                    MessageBox.Show("Error please make sure this file isn't already open", "Error", MessageBoxButtons.OK);
                }

            }


        }

        private void ButtonUserLoad(object sender, EventArgs e)
        {
            DialogResult confContinue = MessageBox.Show("Loading a file will cause your current progress to be lost, proceed?", "Load a File", MessageBoxButtons.YesNo);
            if (confContinue == DialogResult.Yes)
            {
                Log("User confirmed they would like to pick a file");

                OpenFileDialog fileDialog = new()
                {
                    Filter = "csv files (*.csv)|*.csv",
                    RestoreDirectory = true,
                };
                DialogResult loadResult = fileDialog.ShowDialog();
                if (loadResult == DialogResult.Cancel)
                {
                    Log("User cancelled the load file dialog");
                }
                else if (loadResult == DialogResult.OK)
                {
                    CurrentLoadedFile.Clear();
                    Log("Attempting to load a file");
                    try
                    {
                        ViewFishCaught.Items.Clear();
                        int lineNum = 0;
                        try
                        {
                            StreamReader reader = new(fileDialog.FileName);
                            var config = new CsvConfiguration(CultureInfo.GetCultureInfo("en-AU"))
                            {
                                HeaderValidated = (args) =>
                                {
                                    ConfigurationFunctions.HeaderValidated(args);
                                }
                            };
                            CsvReader csv = new(reader, config);
                            Debug.WriteLine("Loading CSV Contents:");
                            csv.Read();
                            csv.ReadHeader();
                            foreach (var record in csv.GetRecords<ImportData>())
                            {
                                try
                                {
                                    if (String.IsNullOrEmpty(record.Points.ToString()) == true ||
                                        String.IsNullOrEmpty(record.KoR) == true ||
                                        String.IsNullOrEmpty(record.Name) == true)
                                    {
                                        ViewFishCaught.Items.Clear();
                                        Log("Error one of: 'Points', 'Name' or 'Kept or Released' fields Null or Empty");
                                        Log("Error - One of 'Points', 'Kept or Released', 'Name' fields Null or Empty");
                                        Log(String.Format("Problem Record: [{0}] [{1}] [{2}]", record.Points.ToString(), record.KoR, record.Name));
                                        MessageBox.Show("Please make sure data is not corrupted and try again.", "Error while reading save", MessageBoxButtons.OK);
                                        return;
                                    }
                                    else
                                    {
                                        ViewFishCaught.Items.Add(new ListViewItem(new string[]
                                        {
                                            record.Points.ToString(),
                                            record.KoR,
                                            record.Name
                                        }));
                                        Log(String.Format("{0}: {1} {2} {3}", lineNum, record.Points.ToString(), record.KoR, record.Name));
                                        lineNum++;
                                    }
                                }
                                catch (CsvHelper.TypeConversion.TypeConverterException ex)
                                {
                                    Log(ex.Message);
                                }
                            }
                            reader.Close();
                            UpdateTotals();
                            CurrentLoadedFile.Text = Path.GetFileName(fileDialog.FileName);
                        }
                        catch (IOException ex)
                        {
                            ViewFishCaught.Items.Clear();
                            CurrentLoadedFile.Clear();
                            Log("Exception Caught: " + ex.Message);
                            MessageBox.Show("File cannot be accessed! Please make sure it is not open in another program or is not being modified", "Error", MessageBoxButtons.OK);
                        }
                    }
                    catch (CsvHelperException ex)
                    {
                        ViewFishCaught.Items.Clear();
                        Log("Exception Details: ");
                        Log("\t" + (ex.InnerException != null ? ex.InnerException.Message : ex.Message));
                        MessageBox.Show("Please make sure data is not corrupted and try again. ", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else if (confContinue == DialogResult.No)
            {
                Log("User does not want to pick a file, proceeding back to game");
            }
        }

        private void tf_FishType(object sender, EventArgs e)
        {
        }
        private void lstFishGroup(object sender, EventArgs e)
        {

        }

        private void tf_NumGen(object sender, EventArgs e)
        {

        }

        private void tf_PointsEarned(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CurrentLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRelease(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fishNameDisplay.Text) == false
                && String.IsNullOrEmpty(numberGenDisplay.Text) == false
                && String.IsNullOrEmpty(pointsEarnedDisplay.Text) == false)
            {
                DialogResult prompt = MessageBox.Show("Are you sure you want to release this fish?", "Release the fish?", MessageBoxButtons.YesNo);
                switch (prompt)
                {
                    case DialogResult.Yes:
                        ViewFishCaught.Items.Add(new ListViewItem(new string[]
                        {
                            GetReleasedAmount(fishNameDisplay.Text).ToString(),
                            "Released",
                            fishNameDisplay.Text
                        }));
                        UpdateTotals();
                        ClearGenFish();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            button3.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)


        {
            if (String.IsNullOrEmpty(fishNameDisplay.Text) == false
                && String.IsNullOrEmpty(numberGenDisplay.Text) == false
                && String.IsNullOrEmpty(pointsEarnedDisplay.Text) == false)
            {
                ViewFishCaught.Items.Add(new ListViewItem(new string[]
                {
                    pointsEarnedDisplay.Text,
                    "Kept",
                    fishNameDisplay.Text
                }));
                UpdateTotals();
                ClearGenFish();
            }
            button3.Enabled = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void IsLoggedIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rndNum = new Random().Next(1, 7);

            numberGenDisplay.Text = rndNum.ToString();
            foreach (var indexFind in fishAttrList)
            {
                if (indexFind.Index == rndNum)
                {
                    Log(String.Format("Generated Fish Details: {0} {1} {2} {3} {4} {5}", indexFind.Index, indexFind.Name, indexFind.IsKeeper, indexFind.IsFish, indexFind.AmtKept, indexFind.AmtReleased));
                    fishNameDisplay.Text = indexFind.Name;
                    pointsEarnedDisplay.Text = indexFind.AmtKept.ToString();
                }
            }
            button3.Enabled = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}