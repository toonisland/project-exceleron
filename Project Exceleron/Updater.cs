using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;
using Squirrel;

namespace Project_Exceleron
{
    class Updater
    {
        public static async void CheckForUpdates()
        {
            try
            {
                using (UpdateManager mgr = GetUpdateManager())
                    await SquirrelUpdate(mgr);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }

        private static UpdateManager GetUpdateManager()
        {
            return new UpdateManager("https://s3.amazonaws.com/altisrjbszd4cotzcwg4xafyvzfd2");
        }

        public static async Task StartupUpdateCheck()
        {
            try
            {
                Log.Info("Checking for updates");
                bool updated;
                using (UpdateManager mgr = GetUpdateManager())
                {
                    SquirrelAwareApp.HandleEvents(
                        v =>
                        {
                            mgr.CreateShortcutForThisExe();
                        },
                        onAppUninstall: v =>
                        {
                            mgr.RemoveShortcutForThisExe();
                        }
                    );
                    updated = await SquirrelUpdate(mgr);
                }

                if (updated)
                {
                    Log.Info("Update complete, restarting");
                    UpdateManager.RestartApp();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }
        private static async Task<bool> SquirrelUpdate(UpdateManager mgr, bool ignoreDelta = false)
        {
            try
            {
                Log.Info($"Checking for updates (ignoreDelta={ignoreDelta})");
                UpdateInfo updateInfo = await mgr.CheckForUpdate(ignoreDelta);
                if (!updateInfo.ReleasesToApply.Any())
                {
                    Log.Info("No new updated available");
                    return false;
                }
                SemanticVersion latest = updateInfo.ReleasesToApply.LastOrDefault()?.Version;
                SemanticVersion current = mgr.CurrentlyInstalledVersion();
                if (latest <= current)
                {
                    Log.Info($"Installed version ({current}) is greater than latest release found ({latest}). Not downloading updates.");
                    return false;
                }
                if (IsRevisionIncrement(current?.Version, latest?.Version))
                {
                    Log.Info($"Latest update ({latest}) is revision increment. Updating in background.");

                }
                Log.Info($"Downloading {updateInfo.ReleasesToApply.Count} {(ignoreDelta ? "" : "delta ")}releases, latest={latest?.Version}");
                await mgr.DownloadReleases(updateInfo.ReleasesToApply);
                Log.Info("Applying releases");
                await mgr.ApplyReleases(updateInfo);
                await mgr.CreateUninstallerRegistryEntry();
                Log.Info("Done");
                return true;
            }
            catch (Exception ex)
            {
                if (ignoreDelta)
                    return false;
                if (ex is Win32Exception)
                    Log.Info("Not able to apply deltas, downloading full release");
                return await SquirrelUpdate(mgr, true);
            }
        }
        internal static void StartUpdate()
        {
            Log.Info("Restarting...");
            UpdateManager.RestartApp();
        }

        private static bool IsRevisionIncrement(Version current, Version latest)
        {
            if (current == null || latest == null)
                return false;
            return current.Major == latest.Major && current.Minor == latest.Minor && current.Build == latest.Build
                   && current.Revision < latest.Revision;
        }
    }
}
