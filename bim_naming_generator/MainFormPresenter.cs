using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bim_naming_generator
{
    internal class MainFormPresenter : GeneratorListener, DbListener
    {
        private MainForm form;
        private Database db;
        private Generator generator;

        public MainFormPresenter(MainForm form)
        {
            this.form = form;
            db = new Database(this);
            generator = new Generator(db, this);
        }

        public void OnGenerateClick(string baseName)
        {
            generator.GenerateNewNumber(baseName);
        }

        public void OnClaimClick(string fileName)
        {
            db.ClaimFileName(fileName);
        }

        public void OnGenerateResult(string newNumber, bool result)
        {
            form.OnGeneratorResult(newNumber, result);
        }

        public void OnFileClaimResult(string fileName, bool success, string errorMessage)
        {
            form.OnFileClaimResult(fileName, success, errorMessage);
        }

        internal void OnFormClose()
        {

        }
    }
}
