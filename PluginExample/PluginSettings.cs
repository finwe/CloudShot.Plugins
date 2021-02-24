using System;
using System.IO;

namespace PluginExample
{
  public class PluginSettings
  {
    private string _folderToSave;
    public static string DefaultSaveLocation => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "CloudShot");

    public string FolderToSave
    {
      get
      {
        if (string.IsNullOrEmpty(_folderToSave))
          _folderToSave = DefaultSaveLocation;

        return _folderToSave;
      }
      set => _folderToSave = value;
    }
  }
}
