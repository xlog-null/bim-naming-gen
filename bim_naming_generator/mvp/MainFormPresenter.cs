using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bim_naming_generator
{
    internal class MainFormPresenter : Repository.IRepositoryListener
    {
        private IView view;
        private Repository repo;
        private Generator generator;
        private List<FieldOption> fieldOptions = new List<FieldOption>();
        private string fieldOptionsSource = "general";
        // Special projects are projects that have a seperate fields table in the db.
        private List<string> specialProjects = new List<string>();

        public MainFormPresenter(IView view)
        {
            this.view = view;
            repo = new Repository(this);
            generator = new Generator(repo);
            specialProjects.Add("E21356");
            repo.FetchProjects();
            repo.FetchFieldOptions(fieldOptionsSource);
            repo.FetchClaimHistory(Environment.UserName);
        }

        private void SetFieldOptionsSource(string project)
        {
            if (!project.ToUpper().Equals(fieldOptionsSource.ToUpper()))
            {
                view.SetLoading(true);
                repo.FetchFieldOptions(project);
            }
        }

        public void OnGenerateClick(string baseName)
        {
            view.SetLoading(true);
            bool success;
            string number = "";
            try
            {
                number = generator.GenerateNewNumber(baseName);
                success = true;
            } catch {
                success = false;
               
            }

            if (success)
            {
                view.OnGenerateSuccess(number);
            } else
            {
                view.OnGenerateFailure("Error generating file name.");
            }
            view.SetLoading(false);
        }

        public void OnClaimClick(string fileName)
        {
            view.SetLoading(true);
            repo.ClaimFileName(fileName);
        }

        internal void OnProjectCodeChanged(string project)
        {
            project = project.Split(' ').First(); // yikes
            if (specialProjects.Contains(project)) {
                SetFieldOptionsSource(project);
            } else
            {
                SetFieldOptionsSource("general");
            }
        }

        public void OnFetchProjectsSuccess(List<string> projects)
        {
            view.LoadProjects(projects);
        }

        public void OnFetchProjectsFailure(string error)
        {
            view.SetLoading(false);
            view.DisplayError(error);
        }

        public void OnFetchFieldOptionsSuccess(List<FieldOption> options, string project)
        {
            fieldOptionsSource = project;
            view.LoadFieldOptions(options);
        }

        public void OnFetchFieldOptionsFailure(string error)
        {
            view.SetLoading(false);
            view.DisplayError(error);
        }

        public void OnFileClaimSuccess(string filename, string dateTime)
        {
            view.OnFileClaimSuccess(filename, dateTime);
        }

        public void OnFileClaimFailure(string filename, string error)
        {
            view.OnFileClaimFailure(filename, error);
        }

        public void OnFetchClaimHistorySuccess(List<string> filenames, List<string> dates)
        {
            view.LoadClaimHistory(filenames, dates);
        }

        public void OnFetchClaimHistoryFailure(string error)
        {
            view.OnFetchClaimHistoryFailure(error);
        }

        public interface IView
        {
            void LoadProjects(List<string> projects);
            void LoadFieldOptions(List<FieldOption> fieldOptions);
            void OnGenerateSuccess(string newNumber);
            void OnGenerateFailure(string error);
            void OnFileClaimSuccess(string filename, string dateTime);
            void OnFileClaimFailure(string filename, string error);
            void SetLoading(bool loading);
            void DisplayError(string error);
            void LoadClaimHistory(List<string> filenames, List<string> dates);
            void OnFetchClaimHistoryFailure(string error);
        }
    }
}
