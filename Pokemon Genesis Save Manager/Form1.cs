using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Genesis_Save_Manager
{

    public partial class Form1 : Form
    {
        public string currentSaveGameFolder = "./Pokemon Generations Reboot_Data/Data";
        public string backupSaveGameFolder = "./Pokemon Genesis Save Manager/Saves";

        public Form1()
		{
			InitializeComponent();
			checkFirstTimeSetup();
			loadSaves();
		}

        private void checkFirstTimeSetup()
		{
			// Our data folder
			Directory.CreateDirectory(backupSaveGameFolder);
			// Pokemon Genesis (Generations [Reboot]) save file location
			Directory.CreateDirectory(currentSaveGameFolder);
		}

		private void loadSaves()
		{
			// Check if the current save has a name or not, if not give it a name
			FileStream fs = new FileStream(currentSaveGameFolder + "/PGSM.xml", FileMode.OpenOrCreate);
			string dataasstring = "<?xml version=\"1.0\" encoding=\"utf-8\"?><Settings xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><name>New Save x</name></Settings>"; //your data
			byte[] info = new UTF8Encoding(true).GetBytes(dataasstring);
			fs.Write(info, 0, info.Length);
			fs.Close();

			saveListView.Items.Clear();

			string[] folders = Directory.GetDirectories(backupSaveGameFolder);
			foreach (string folder in folders)
			{

				FileInfo f = new FileInfo(folder);
				ListViewItem item = new ListViewItem(f.Name);
				item.Tag = f.Name;

				saveListView.Items.Add(item);

			}
		}

		public void saveGame(string saveFolderName)
		{
            string saveGameFolder = Path.Combine(backupSaveGameFolder, saveFolderName);
            Directory.CreateDirectory(saveGameFolder);				
			string[] files = Directory.GetFiles(currentSaveGameFolder);
			foreach (string file in files)
			{
				string name = Path.GetFileName(file);
				string dest = Path.Combine(saveGameFolder, name);
				File.Copy(file, dest, true);
			}
		}

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (input.Length >= 1)
                saveGame(input);
                string input = Prompt.ShowDialog("Enter a name for your save", "Save Current Game");
            loadSaves();
        }
    }

}

public static class Prompt
{
    public static string ShowDialog(string text, string caption)
    {
        Form prompt = new Form()
        {
            Width = 245,
            Height = 100,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };
        Label textLabel = new Label() { Left = 10, Top = 10, Width = 210, Text = text };
        TextBox textBox = new TextBox() { Left = 10, Top = 30, Width = 210 };
        Button confirmation = new Button() { Text = "Ok", Left = 230, Width = 60, Top = 10, Height = 40, DialogResult = DialogResult.OK };
        confirmation.Click += (sender, e) => { prompt.Close(); };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        return prompt.ShowDialog() == DialogResult.OK ? textBox.Text.Trim() : "";
    }
}