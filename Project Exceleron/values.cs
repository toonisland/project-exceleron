using System;
using System.IO;
using System.Windows.Forms.VisualStyles;
using Project_Exceleron.Properties;
namespace Project_Exceleron
{
    public static class Values
    {
        public static string Astrond()
        {
            if(Settings.Default.inheritSrc)
            {
                if(!string.IsNullOrEmpty(Settings.Default.srcPath))
                    return Path.Combine(Settings.Default.srcPath, "astron", "astrond.exe");
                
            }
            else
            {
                if(!string.IsNullOrEmpty(Settings.Default.AstronPath))
                    return Settings.Default.AstronPath;
            }
            return null;
        }

        public static string AstronCluster()
        {
            if (Settings.Default.inheritSrc)
            {
                if (!string.IsNullOrEmpty(Settings.Default.srcPath))
                    return Path.Combine(Settings.Default.srcPath, "astron", "config", "cluster.yml");
            }
            else
            {
                if (!string.IsNullOrEmpty(Settings.Default.AstronPath))
                    return Settings.Default.AstronPath;
            }
            return null;
        }

        public static string Mongod()
        {
            if (Settings.Default.inheritSrc)
            {
                if(!string.IsNullOrEmpty(Settings.Default.srcPath))
                {
                    string[] path = new[]
                    {
                        Settings.Default.srcPath,
                        "astron",
                        "MongoDB",
                        "Server",
                        "3.0",
                        "bin",
                        "mongod.exe"
                    };
                    return Path.Combine(path);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(Settings.Default.AstronPath))
                    return Settings.Default.AstronPath;
            }
            return null;
        }

        public static string MongoDbPath()
        {
            if (Settings.Default.inheritSrc)
            {
                if (!string.IsNullOrEmpty(Settings.Default.srcPath))
                    return Path.Combine(Settings.Default.srcPath, "astron", "MongoDB", "astrondb");
            }
            else
            {
                if (!string.IsNullOrEmpty(Settings.Default.AstronPath))
                    return Settings.Default.AstronPath;
            }
            return null;
        }

        public static string MongoLockFile()
        {
            if (Settings.Default.inheritSrc)
            {
                if (!string.IsNullOrEmpty(Settings.Default.srcPath))
                {
                    string[] path = new[]
                    {
                        Settings.Default.srcPath,
                        "astron",
                        "MongoDB",
                        "astrondb",
                        "mongod.lock"
                    };
                    return Path.Combine(path);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(Settings.Default.MongoDbPath))
                    return Path.Combine(Settings.Default.MongoDbPath, "mongod.lock");
            }
            return null;
        }

        public static string PpythonPath()
        {
            if (Settings.Default.inheritSrc)
            {
                if (!string.IsNullOrEmpty(Settings.Default.srcPath))
                    return File.ReadAllText(Path.Combine(Settings.Default.srcPath, "PPYTHON_PATH"));
            }
            else
            {
                if (!string.IsNullOrEmpty(Settings.Default.ppythonPath))
                    return Settings.Default.ppythonPath;
            }
            return null;
        }

        public static string Username() => Settings.Default.username;

        public static string Password() => Settings.Default.password;
    }
}