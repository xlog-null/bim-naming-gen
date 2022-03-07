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

        public MainForm()
        {
            InitializeComponent();

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

        private void DisplayResultFileName()
        {
            lblFileName.Text = formData.ToString();
        }

        private void OnFieldInput(object sender, EventArgs e)
        {
            var field = (Control) sender;
            formData.fields[field.Tag.ToString()].SetContent(field.Text);
            lblFileName.Text = formData.ToString();

        }
    }
}
