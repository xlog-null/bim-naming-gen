using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bim_naming_generator
{
    public partial class MainForm : Form, MainFormPresenter.IView
    {

        private FormData formData = new FormData();

        private Dictionary<object, PictureBox> pictureBoxes = new Dictionary<object, PictureBox>();
        private MainFormPresenter presenter;

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainFormPresenter(this);
            pbLoading.BringToFront();
            PopulatePictureBoxDict();
            ExtractFormData();
            DisplayResultFileName();
            SetLoading(false);
        }

        internal void UpdateFileName(string fileName)
        {
            lblFileName.Text = fileName;
        }

        private void ExtractFormData()
        {
            formData.fields["projectCode"].content = cbProjectCode.Text;
            formData.fields["originator"].content = cbOriginator.Text;
            formData.fields["functional_breakdown"].content = cbFunctionalBreakdown.Text;
            formData.fields["spatial_breakdown"].content = cbSpatialBreakdown.Text;
            formData.fields["form"].content = cbForm.Text;
            formData.fields["discipline"].content = cbDiscipline.Text;
            formData.fields["number"].content = tbNumber.Text;
        }

        private void DisplayResultFileName()
        {
            lblFileName.Text = formData.ToString();
        }

        private void OnProjectCodeChanged(object sender, EventArgs e)
        {
            var field = (Control)sender;
            presenter.OnProjectCodeChanged(field.Text.ToString().ToUpper());
            OnFieldInput(sender, e);
        }

        private void OnFieldInput(object sender, EventArgs e)
        {
            var field = (Control) sender;
            var fieldTag = field.Tag.ToString();
            formData.fields[fieldTag].SetContent(field.Text);
            var pbIsFieldValid = pictureBoxes[sender];


            if (formData.fields[fieldTag].IsValid())
            {
                pbIsFieldValid.Visible = true;
            }
            else
            {
                pbIsFieldValid.Visible = false;
            }

            btnGenerate.Enabled = formData.IsValid();
            tbNumber.Text = "";

            btnCopy.Enabled = false;
            btnClaim.Enabled = false;
            lblInfo.Visible = false;
            formData.fields["number"].content = "";
            lblFileName.Text = formData.ToString();
        }

        private void PopulatePictureBoxDict()
        {
            pictureBoxes.Add(cbProjectCode, pbProjectCode);
            pictureBoxes.Add(cbOriginator, pbOriginator);
            pictureBoxes.Add(cbFunctionalBreakdown, pbFunctionalBreakdown);
            pictureBoxes.Add(cbSpatialBreakdown, pbSpatialBreakdown);
            pictureBoxes.Add(cbForm, pbForm);
            pictureBoxes.Add(cbDiscipline, pbDiscipline);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            SetLoading(true);
            btnCopy.Enabled = false;
            lblInfo.Visible = false;
            tbNumber.Text = "";
            formData.fields["number"].content = "";
            var baseName = formData.ToString();
            lblFileName.Text = baseName;
            presenter.OnGenerateClick(baseName);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblFileName.Text);
        }

        private void btnClaim_Click(object sender, EventArgs e)
        {
            SetLoading(true);
            btnGenerate.Focus();
            presenter.OnClaimClick(formData.ToString());
        }

        private void ClearFieldItemsAndInputs()
        {
            cbOriginator.Text = "";
            cbFunctionalBreakdown.Text =
            cbSpatialBreakdown.Text = "";
            cbForm.Text = "";
            cbDiscipline.Text = "";

            cbOriginator.Items.Clear();
            cbFunctionalBreakdown.Items.Clear();
            cbSpatialBreakdown.Items.Clear();
            cbForm.Items.Clear();
            cbDiscipline.Items.Clear();
        }

        public void OnGenerateSuccess(string newNumber)
        {
            tbNumber.Text = newNumber;
            formData.fields["number"].content = newNumber;
            lblFileName.Text = formData.ToString();
            btnClaim.Enabled = true;
        }

        public void OnGenerateFailure(string error)
        {
            DisplayError(error);
        }

        private void OnFileClaimResult(bool success)
        {
            SetLoading(false);
            btnClaim.Enabled = !success;
            lblInfo.Visible = true;
        }

        public void OnFileClaimSuccess(string filename, string dateTime)
        {
            lblInfo.Text = "File name claimed successfully.";
            lblInfo.ForeColor = Color.DarkGreen;
            btnCopy.Enabled = true;
            var lvItem = new ListViewItem(filename);
            lvItem.SubItems.Add(dateTime);
            lvClaimed.Items.Add(lvItem);
            OnFileClaimResult(true);
        }

        public void OnFileClaimFailure(string filename, string error)
        {
            DisplayError(error);
            btnCopy.Enabled = false;
            OnFileClaimResult(false);
        }

        public void LoadProjects(List<string> projects)
        {
            cbProjectCode.Items.Clear();
            cbProjectCode.Items.AddRange(projects.ToArray());
            SetLoading(false);
        }

        public void LoadFieldOptions(List<FieldOption> fieldOptions)
        {
            ClearFieldItemsAndInputs();

            foreach (FieldOption fo in fieldOptions)
            {
                switch (fo.type)
                {
                    case "originator":
                        cbOriginator.Items.Add(fo.ToString());
                        break;
                    case "functional_breakdown":
                        cbFunctionalBreakdown.Items.Add(fo.ToString());
                        break;
                    case "spatial_breakdown":
                        cbSpatialBreakdown.Items.Add(fo.ToString());
                        break;
                    case "form":
                        cbForm.Items.Add(fo.ToString());
                        break;
                    case "discipline":
                        cbDiscipline.Items.Add(fo.ToString());
                        break;
                    default:
                        break;
                }
            }
            SetLoading(false);
        }

        public void SetLoading(bool loading)
        {
            pbLoading.Visible = loading;
            pbLoading.Refresh();
        }

        public void DisplayError(string error)
        {
            lblInfo.Visible = true;
            lblInfo.Text = error;
            lblInfo.ForeColor = Color.DarkRed;
        }

        private void btnExpandClaimed_Click(object sender, EventArgs e)
        {
            tlClaimedPanel.Visible = !tlClaimedPanel.Visible;
            OnResize(EventArgs.Empty);
        }

        public void LoadClaimHistory(List<string> filenames, List<string> dates)
        {
            lvClaimed.Items.Clear();
            //var row = new ListViewItem(filenames[0]);
            //row.SubItems.Add(dates[0]);
            //lvClaimed.Items.Add(row);

            for (int i = 0; i < filenames.Count; i++)
            {
                var row = new ListViewItem(filenames[i]);
                row.SubItems.Add(dates[i]);
                lvClaimed.Items.Add(row);
            }
        }

        public void OnFetchClaimHistoryFailure(string error)
        {
            DisplayError(error);
        }

        private void lvClaimed_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lvClaimed.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
    }

    class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;


        public ListViewItemComparer(int column)
        {
            col = column;
            order = SortOrder.Ascending;
        }

        public int Compare(object x, object y)
        {
            int returnVal;
            // Determine whether the type being compared is a date type.
            try
            {
                // Parse the two objects passed as a parameter as a DateTime.
                System.DateTime firstDate =
                        DateTime.Parse(((ListViewItem)x).SubItems[col].Text);
                System.DateTime secondDate =
                        DateTime.Parse(((ListViewItem)y).SubItems[col].Text);
                // Compare the two dates.
                returnVal = DateTime.Compare(firstDate, secondDate);
            }
            // If neither compared object has a valid date format, compare
            // as a string.
            catch
            {
                // Compare the two items as a string.
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                            ((ListViewItem)y).SubItems[col].Text);
            }
            // Determine whether the sort order is descending.
            if (order == SortOrder.Descending)
            {
                // Invert the value returned by String.Compare.
                returnVal *= -1;
            }
                
            return returnVal;
        }
    }
}
