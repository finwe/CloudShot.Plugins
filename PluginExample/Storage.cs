using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using CloudShot.Core.Interfaces;
using CloudShot.Core.Types;
using CloudShot.Core.Utils;

namespace PluginExample
{
  public class Storage : ImageStorage<PluginSettings>
  {
    public override Image Logo { get; }

    public Storage()
      : base("PluginExample", "This is a CloudShot plugin example")
    {
      DpiResourcesManager manager = new DpiResourcesManager(LocalResources.ResourceManager);
      Logo = manager.GetImage(nameof(LocalResources.folder));
    }

    public override async Task<StorageSaveResult> SaveImage(byte[] data, string shotName)
    {
      PluginSettings settings = GetSettings();
      Directory.CreateDirectory(settings.FolderToSave); //create directory if not exist

      string pathToSave = Path.Combine(settings.FolderToSave, shotName);

      using (var fs = new FileStream(pathToSave, FileMode.Create))
      {
        await fs.WriteAsync(data, 0, data.Length);
      }

      return new StorageSaveResult(shotName, pathToSave);
    }

    public override ISettingsControl CreateSettingsControl() => new SettingsControl(this);
  }
}
