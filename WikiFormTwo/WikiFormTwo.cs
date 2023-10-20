using System.Configuration;
using System.Diagnostics;
using System.DirectoryServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace WikiFormTwo
{
    public partial class WikiFormTwo : Form
    {
        public WikiFormTwo()
        {
            InitializeComponent();
        }

        //
        // Global Variables
        //

        /// <summary>
        /// List of objects
        /// </summary>
        // 6.2 Create a global List<T> of type Information called Wiki.
        private List<Information> records = new();

        //
        // Misc Methods
        //

        //6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name and returns a Boolean after checking for duplicates.
        //Use the built in List<T> method “Exists” to answer this requirement.
        private bool ValidName(string name) // check for duplicate records by name
        {
            /*for (int index = 0; index < records.Count; index++) // for each record
            {
                for (int otherIndex = 0; otherIndex < records.Count; otherIndex++) // loop through all records
                {
                    if (index != otherIndex) // do not check self
                    {
                        if (records[index].GetName() == records[otherIndex].GetName()) // check if names are the same
                        {
                            records[index].SetName(records[index].GetName() + "-clone"); // append text to make values unique
                        }
                    }
                }
            }*/

            if (records.Exists(dup => dup.GetName() == name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int GetSelectedIndex()
        {
            try
            {
                return recordBox.SelectedItems[0].Index;
            }
            catch
            {
                return -1;
            }
        }
        private void SetSelectedIndex(int index)
        {
            recordBox.Items[index].Selected = true;
        }

        // on load

        //6.4 Create a custom method to populate the ComboBox when the Form Load method is called.
        //The six categories must be read from a simple text file.
        private void WikiFormTwo_Load(object sender, System.EventArgs e)
        {
            // read category values and place them in the combobox
            using (StreamReader reader = new(@"Categories.txt"))
            {
                string? readLine = reader.ReadLine();

                while (readLine != null)
                {
                    categoryComboBox.Items.Add(readLine);

                    readLine = reader.ReadLine();
                };
            }
        }

        // toggle dark mode
        private void darkModeToggle_Click(object sender, EventArgs e)
        {
            darkModeToggle.Checked = !darkModeToggle.Checked;

            System.Drawing.Color mainColour;
            System.Drawing.Color secondaryColour;

            if (darkModeToggle.Checked)
            {
                mainColour = SystemColors.ControlDark;
                secondaryColour = SystemColors.ControlDarkDark;
            }
            else
            {
                mainColour = SystemColors.ControlLight;
                secondaryColour = SystemColors.ControlLightLight;
            }

            foreach (Control c in Controls)
            {
                TextBox txt = c as TextBox;
                if (txt != null)
                {
                    txt.BackColor = mainColour;
                }

                RichTextBox rtxt = c as RichTextBox;
                if (rtxt != null)
                {
                    rtxt.BackColor = mainColour;
                }
            }

            BackColor = secondaryColour;
            searchButton.BackColor = mainColour;
            linearButton.BackColor = mainColour;
            nonLinearButton.BackColor = mainColour;
            recordBox.BackColor = mainColour;
            categoryComboBox.BackColor = mainColour;
            structureGroupBox.BackColor = mainColour;
        }

        //on form closing

        //6.15 The Wiki application will save data when the form closes. 
        private void WikiFormTwo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the wiki
            if (QueryConfirmation("Exit without saving?", "Exit", MessageBoxButtons.YesNo, DialogResult.No))
            {
                SaveData(records);
            }
        }


        //
        // save and load
        //

        // Save
        private void saveAsButton_Click(object sender, EventArgs e)
        {
            SaveData(records);
        }

        // Load
        private void loadButton_Click(object sender, EventArgs e)
        {
            records = LoadData();
            DisplayRecords();
        }


        //
        // Record Modification
        //

        // 6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.
        private void DisplayRecords()
        {

            int indexCache = GetSelectedIndex();
            recordBox.Items.Clear(); // clear old values

            records.Sort();

            foreach (Information record in records) // for each record
            {
                // put values into a list view item
                ListViewItem lvi = new(record.GetName());

                lvi.SubItems.Add(record.GetCategory());

                recordBox.Items.Add(lvi); // add new values
            }

            try
            {
                SetSelectedIndex(indexCache);
            }
            catch (Exception e)
            {
                removeButton.Enabled = false;
                editButton.Enabled = false;
                Debug.WriteLine(e);
            }
        }

        //6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the associated information will be displayed in the related text boxes combo box and radio button.
        private void DisplayFeilds(Information record)
        {
            nameTextBox.Text = record.GetName();

            categoryComboBox.Text = record.GetCategory();

            if (record.GetStructure() == "Linear")
            {
                SetStructureValue(0);
            }
            else
            {
                SetStructureValue(1);
            }

            definitionTextBox.Text = record.GetDefinition();
        }

        //6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio button
        private void ClearFeilds()
        {
            nameTextBox.Clear();
            SetStructureValue(-1);
            categoryComboBox.Text = "";
            definitionTextBox.Clear();
        }

        //6.3 Create a button method to ADD a new item to the list.
        //Use a TextBox for the Name input, ComboBox for the Category, Radio group for the Structure and Multiline TextBox for the Definition.

        // add a new record
        private void AddRecord()
        {
            Information record = new(); // create new record object

            string defaultName = "NewRecord";
            while (ValidName(defaultName))
            {
                defaultName += "-copy";
            }

            record.SetName(defaultName);

            records.Add(record); // add the record to the list

            statusStrip.Text = "Added new record";
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddRecord();
            DisplayRecords();
        }

        // remove a record

        //6.7 Create a button method that will delete the currently selected record in the ListView.
        //Ensure the user has the option to backout of this action by using a dialog box.
        //Display an updated version of the sorted list at the end of this process.
        private void RemoveRecord(Information record)
        {
            if (QueryConfirmation("Are you sure?", "Remove Record", MessageBoxButtons.YesNo, DialogResult.Yes))
            {
                records.Remove(record);
                DisplayRecords();
                statusStrip.Text = "Removed record";
            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (GetSelectedIndex() != -1)
            {
                if (records.Count > 0)
                {
                    RemoveRecord(records[GetSelectedIndex()]);
                }
            }
        }

        // edit a record

        //6.8 Create a button method that will save the edited record of the currently selected item in the ListView.
        //All the changes in the input controls will be written back to the list.
        //Display an updated version of the sorted list at the end of this process.
        private void EditRecord(Information record)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameTextBox.Text = "~";
            }
            else
            {
                string name = nameTextBox.Text;

                record.SetName("");

                while (ValidName(name))
                {
                    name += "-copy";
                }
                record.SetName(name);
            }

            if (string.IsNullOrEmpty(categoryComboBox.Text))
            {
                categoryComboBox.Text = "~";
            }
            else
            {
                record.SetCategory(categoryComboBox.Text);
            }

            if (!string.IsNullOrEmpty(GetStructureValue()))
            {
                record.SetStructure(GetStructureValue());
            }

            if (string.IsNullOrEmpty(definitionTextBox.Text))
            {
                definitionTextBox.Text = "~";
            }
            else
            {
                record.SetDefinition(definitionTextBox.Text);
            }

            statusStrip.Text = "Modified record";
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (GetSelectedIndex() != -1)
            {
                EditRecord(records[GetSelectedIndex()]);
            }
            DisplayRecords();
        }

        // record box
        private void recordBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GetSelectedIndex() != -1)
            {
                DisplayFeilds(records[GetSelectedIndex()]);
                removeButton.Enabled = true;
                editButton.Enabled = true;
            }
            else
            {
                removeButton.Enabled = false;
                editButton.Enabled = false;
                ClearFeilds(); // If nothing is selected clear the feilds
            }
        }


        //
        // Inputs
        //

        //6.6 Create two methods to highlight and return the values from the Radio button GroupBox.
        //The first method must return a string value from the selected radio button (Linear or Non-Linear).
        //The second method must send an integer index which will highlight an appropriate radio button.
        private string GetStructureValue()
        {
            if (linearButton.Checked)
            {
                return linearButton.Text;
            }
            else if (nonLinearButton.Checked)
            {
                return nonLinearButton.Text;
            }
            else
            {
                return "~";
            }
        }
        private void SetStructureValue(int index)
        {
            if (index == 0)
            {
                linearButton.Checked = true;
            }
            else if (index == 1)
            {
                nonLinearButton.Checked = true;
            }
        }

        //Name

        //6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox and Radio button.
        private void nameTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearFeilds();
        }
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z-\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13) // Enter key pressed
            {
                categoryComboBox.Focus();
            }
        }

        // Category
        private void categoryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z-\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13) // Enter key pressed
            {
                definitionTextBox.Focus();
            }
        }

        // Definition
        private void definitionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z-\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        // Search
        //6.10 Create a button method that will use the builtin binary search to find a Data Structure name.
        //If the record is found the associated details will populate the appropriate input controls and highlight the name in the ListView.
        //At the end of the search process the search input TextBox must be cleared.
        private void Search(String searchCriteria)
        {
            List<string> names = new();

            foreach (Information record in records)
            {
                names.Add(record.GetName().ToLower());
            }

            int result = names.BinarySearch(searchCriteria.ToLower());

            if (result >= 0)
            {
                statusStrip.Text = "Record found";
                SetSelectedIndex(result);
                searchTextBox.Clear();
                nameTextBox.Focus();
            }
            else
            {
                statusStrip.Text = "Record not found";
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z-\b\s]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13) // Enter key pressed
            {
                e.Handled = true;

                Search(searchTextBox.Text);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            Search(searchTextBox.Text);
        }

        //
        // Save and Load
        //

        // 6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or rename a saved file.
        // All Wiki data is stored/retrieved using a binary reader/writer file format.

        // Save
        private void SaveData(List<Information> data)
        {
            string filePath = QuerySaveFile();

            if (string.IsNullOrEmpty(filePath))
            {
                // default name
                filePath = "AutoSave";
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    foreach (Information record in data)
                    {
                        binaryWriter.Write(record.GetName());
                        binaryWriter.Write(record.GetCategory());
                        binaryWriter.Write(record.GetStructure());
                        binaryWriter.Write(record.GetDefinition());
                    }
                }
            }

            statusStrip.Text = "Saved wiki";
        }

        // Load
        private List<Information> LoadData()
        {
            List<Information> output = new List<Information>();

            string filePath = QueryLoadFile();

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                    {
                        Information record = new();

                        record.SetName(binaryReader.ReadString());
                        record.SetCategory(binaryReader.ReadString());
                        record.SetStructure(binaryReader.ReadString());
                        record.SetDefinition(binaryReader.ReadString());

                        output.Add(record);
                    }
                }
            }

            statusStrip.Text = "Loaded wiki";
            return output;
        }

        //
        // confirmation boxes
        //

        // query load file
        private string QueryLoadFile()
        {
            OpenFileDialog opf = new OpenFileDialog()
            {
                Title = "Load record",
                InitialDirectory = Application.UserAppDataPath,
                Filter = "Binary files (*.dat)|*.dat|All files (*.*)|*.*",
                FilterIndex = 0,
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false
            };

            opf.ShowDialog();

            return opf.FileName;
        }

        // query save file
        private string QuerySaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Title = "Save Record",
                InitialDirectory = Application.UserAppDataPath,
                Filter = "Binary files (*.dat)|*.dat",
                FilterIndex = 0,
                CheckFileExists = false,
                CheckPathExists = true,
            };

            sfd.ShowDialog();

            return sfd.FileName;
        }

        // Confirmation box
        private bool QueryConfirmation(string title, string tag, MessageBoxButtons buttons, DialogResult trueResult)
        {
            var confimResult = MessageBox.Show(title, tag, buttons);

            if (confimResult == trueResult)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}