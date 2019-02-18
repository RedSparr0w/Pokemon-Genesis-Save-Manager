using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
			saveListView.Items.Clear();

			string[] folders = Directory.GetDirectories(backupSaveGameFolder);
			foreach (string folder in folders)
			{
				FileInfo f = new FileInfo(folder);
				ListViewItem item = new ListViewItem(f.Name);
				item.Tag = f.Name;

				saveListView.Items.Add(item);
            }
            PokemonGenesisSaveManagerSettings saveInfo = ReadXML(currentSaveGameFolder + "/PGSM.xml");
            updatebuttonSaveLabel(saveInfo.name);
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
            if (!File.Exists(currentSaveGameFolder + "/PGSM.xml"))
            {
                string input = Prompt.ShowDialog("Enter a name for your save", "Save Current Game");
                if (input.Length >= 1)
                {
                    PokemonGenesisSaveManagerSettings saveInfo = new PokemonGenesisSaveManagerSettings { name = input };
                    SaveXML(saveInfo, currentSaveGameFolder + "/PGSM.xml");
                    saveGame(saveInfo.name);
                }
            }
            else
            {
                PokemonGenesisSaveManagerSettings saveInfo = ReadXML(currentSaveGameFolder + "/PGSM.xml");
                saveGame(saveInfo.name);
            }
            loadSaves();
        }

        public static PokemonGenesisSaveManagerSettings ReadXML(string filePath)
        {
            if (File.Exists(filePath))
            {
                XmlSerializer reader = new XmlSerializer(typeof(PokemonGenesisSaveManagerSettings));
                StreamReader file = new StreamReader(filePath);
                PokemonGenesisSaveManagerSettings overview = (PokemonGenesisSaveManagerSettings)reader.Deserialize(file);
                file.Close();
                return overview;
            }
            return new PokemonGenesisSaveManagerSettings();
        }

        public void SaveXML(PokemonGenesisSaveManagerSettings saveInfo, string filePath)
        {
            XmlSerializer xs = new XmlSerializer(typeof(PokemonGenesisSaveManagerSettings));
            TextWriter txtWriter = new StreamWriter(filePath);
            xs.Serialize(txtWriter, saveInfo);
            txtWriter.Close();
        }

        private void toolStripMenuItemRename_Click(object sender, EventArgs e)
        {
            string currentName = saveListView.SelectedItems[0].Tag.ToString();
            string input = Prompt.ShowDialog("Enter a new name for your save", "Rename Save \"" + currentName + "\"");
            if (input.Length == 0 || input == currentName)
                return;

            PokemonGenesisSaveManagerSettings saveInfo = new PokemonGenesisSaveManagerSettings { name = input };
            Directory.Move(Path.Combine(backupSaveGameFolder, currentName), Path.Combine(backupSaveGameFolder, saveInfo.name));
            SaveXML(saveInfo, Path.Combine(backupSaveGameFolder, saveInfo.name) + "/PGSM.xml");
            loadSaves();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            string currentName = saveListView.SelectedItems[0].Tag.ToString();
            Directory.Delete(Path.Combine(backupSaveGameFolder, currentName), true);
            loadSaves();
        }

        private void toolStripMenuItemLoad_Click(object sender, EventArgs e)
        {
            string currentName = saveListView.SelectedItems[0].Tag.ToString();
            string saveGameFolder = Path.Combine(backupSaveGameFolder, currentName);
            Directory.Delete(currentSaveGameFolder, true);
            Directory.CreateDirectory(currentSaveGameFolder);
            string[] files = Directory.GetFiles(saveGameFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(currentSaveGameFolder, name);
                File.Copy(file, dest, true);
            }
            loadSaves();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            string input = Prompt.ShowDialog("Enter a name for your save", "Start New Save");
            if (input.Length >= 1)
            {
                Directory.Delete(currentSaveGameFolder, true);
                Directory.CreateDirectory(currentSaveGameFolder);
                PokemonGenesisSaveManagerSettings saveInfo = new PokemonGenesisSaveManagerSettings { name = input };
                SaveXML(saveInfo, currentSaveGameFolder + "/PGSM.xml");
                saveGame(saveInfo.name);
            }
            loadSaves();
        }

        private void updatebuttonSaveLabel(string label)
        {
            buttonSave.Text = "Backup Save" + (label.Length > 0 ? " [" + label + "]" : "");
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

public class PokemonGenesisSaveManagerSettings
{
    public String name = "";
}