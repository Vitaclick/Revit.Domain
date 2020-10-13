using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Revit.Domain.Documents
{
  public static class RevitDocs
  {
    public static void SyncWithCentral(Document doc, string comment)
    {
      // set options for accessing central model
      var transOpts = new TransactWithCentralOptions();
      //      var transCallBack = new SyncLockCallback();
      // override default behavioor of waiting to try sync if central model is locked
      //      transOpts.SetLockCallback(transCallBack);
      // set options for sync with central
      var syncOpts = new SynchronizeWithCentralOptions();
      var relinquishOpts = new RelinquishOptions(true);
      syncOpts.SetRelinquishOptions(relinquishOpts);
      // do not autosave local model
      syncOpts.SaveLocalAfter = false;
      syncOpts.Comment = comment;
      try
      {
        doc.SynchronizeWithCentral(transOpts, syncOpts);
      }
      catch (Exception ex)
      {
        TaskDialog.Show($"Sync with model {doc.Title}", ex.Message);
      }
    }
  }
}
