using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace bim_naming_generator
{

    // TODO: MAKE CACHABLE INSTEAD OF ALWAYS NETWORK RETRIEVE.
    public class Repository
    {

        Database db;
        IRepositoryListener listener;

        public Repository(IRepositoryListener listener)
        {
            db = new Database(listener);
            this.listener = listener;
        }

        internal bool CheckIfExists(string filename)
        {
            return db.CheckIfExists(filename);
        }

        internal string GetLatestName(string baseName)
        {
            return db.GetLatestName(baseName);
        }

        internal void FetchFieldOptions(string fieldOptionsSource)
        {
            try
            {
                db.FetchFieldOptions(fieldOptionsSource);
            } catch (Exception ex)
            {
                listener.OnFetchFieldOptionsFailure(ex.Message);
            }
        }

        internal void FetchClaimHistory(string userName)
        {
            try
            {
                db.FetchClaimHistory(userName);
            } catch (Exception ex)
            {
                listener.OnFetchClaimHistoryFailure(ex.Message);
            }
        }

        internal void ClaimFileName(string filename)
        {
            try
            {
                db.ClaimFileName(filename);
            } catch (Exception ex) {
                listener.OnFileClaimFailure(filename, ex.Message);
            }
        }

        internal void FetchProjects()
        {
            try
            {
                db.FetchProjects();
            } catch (Exception ex) {
                listener.OnFetchProjectsFailure(ex.Message);
            }
        }

        public interface IRepositoryListener
        {
            void OnFileClaimSuccess(string filename, string dateTime);
            void OnFileClaimFailure(string filename, string error);
            void OnFetchProjectsSuccess(List<string> projects);
            void OnFetchProjectsFailure(string error);
            void OnFetchFieldOptionsSuccess(List<FieldOption> options, string project);
            void OnFetchFieldOptionsFailure(string error);
            void OnFetchClaimHistorySuccess(List<string> filenames, List<string> dates);
            void OnFetchClaimHistoryFailure(string error);
        }
    }
}