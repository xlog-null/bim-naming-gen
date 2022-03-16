using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bim_naming_generator
{
    public partial class MainForm : Form
    {

        private FormData formData = new FormData();
        private Generator generator = new Generator();
        private Repository repo = new Repository();

        private Dictionary<object, PictureBox> pictureBoxes = new Dictionary<object, PictureBox>();



        public MainForm()
        {
            InitializeComponent();
            LoadDataIntoFields();
            PopulatePictureBoxDict();
            ExtractFormData();
            DisplayResultFileName();
        }

        internal void UpdateFileName(string fileName)
        {
            lblFileName.Text = fileName;
        }


        private void ExtractFormData()
        {
            formData.fields["projectCode"].content = cbProjectCode.Text;
            formData.fields["originator"].content = cbOriginator.Text;
            formData.fields["volOrSystem"].content = cbVolumeOrSystem.Text;
            formData.fields["levelsAndLocations"].content = cbLevelsAndLocations.Text;
            formData.fields["type"].content = cbType.Text;
            formData.fields["role"].content = cbRole.Text;
            formData.fields["number"].content = tbNumber.Text;
        }

        private void LoadDataIntoFields()
        {
            // todo: don't keep data filenames in the MainForm file - bad design.
            cbProjectCode.Items.AddRange(repo.LoadData("project_codes.txt"));
            cbOriginator.Items.AddRange(repo.LoadData("originators.txt"));
            cbVolumeOrSystem.Items.AddRange(repo.LoadData("vol_or_systems.txt"));
            cbLevelsAndLocations.Items.AddRange(repo.LoadData("levels.txt"));
            cbType.Items.AddRange(repo.LoadData("types.txt"));
            cbRole.Items.AddRange(repo.LoadData("roles.txt"));
        }

        private void DisplayResultFileName()
        {
            lblFileName.Text = formData.ToString();
        }


        // EVENT
        private void OnFieldInput(object sender, EventArgs e)
        {
            var field = (Control) sender;
            var fieldTag = field.Tag.ToString();
            formData.fields[fieldTag].SetContent(field.Text);
            lblFileName.Text = formData.ToString();

            var pbIsFieldValid = pictureBoxes[sender];
            if (formData.fields[fieldTag].IsValid()) {
                pbIsFieldValid.Visible = true;
            } else
            {
                pbIsFieldValid.Visible = false;
            }
            

        }
        // EVENT
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
        }

        private void PopulatePictureBoxDict()
        {
            pictureBoxes.Add(cbProjectCode, pbProjectCode);
            pictureBoxes.Add(cbOriginator, pbOriginator);
            pictureBoxes.Add(cbVolumeOrSystem, pbVolume);
            pictureBoxes.Add(cbLevelsAndLocations, pbLevel);
            pictureBoxes.Add(cbType, pbType);
            pictureBoxes.Add(cbRole, pbRole);

        }
    }
}
