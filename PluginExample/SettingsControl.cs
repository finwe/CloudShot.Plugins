using System;
using System.IO;
using System.Windows.Forms;
using CloudShot.Core.Interfaces;
using CloudShot.Core.Utils;

namespace PluginExample
{
  public partial class SettingsControl : UserControl, ISettingsControl
  {
    private readonly Storage _storage;

    public IImageStorage Storage => _storage;

    public Control Control => this;

    public SettingsControl(Storage storage)
    {
      _storage = storage;

      InitializeComponent();

      selectFolderControl.DefaultPath = PluginSettings.DefaultSaveLocation;
      selectFolderControl.Description = "Select location for your screenshots";
    }

    public void Loading()
    {
      PluginSettings settings = _storage.GetSettings();
      selectFolderControl.SelectedPath = settings.FolderToSave;
    }

    public bool ValidateData()
    {
      if (Sys.IsValidPath(selectFolderControl.SelectedPath))
        return true;
      ;
      MessageBox.Show("Invalid folder path", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      selectFolderControl.Focus();
      return false;
    }

    public void Save()
    {
      PluginSettings settings = _storage.GetSettings();
      settings.FolderToSave = selectFolderControl.SelectedPath;
      _storage.SaveSettings(settings);
    }

    public void CancelClicked() { }

    private void OnViewScreenshotsClick(object sender, EventArgs e)
    {
      try
      {
        PluginSettings settings = _storage.GetSettings();
        string dir = settings.FolderToSave;

        if (!Directory.Exists(dir))
        {
          Directory.CreateDirectory(dir);
        }

        Sys.OpenFolder(dir);
      }
      catch { }
    }
  }
}
