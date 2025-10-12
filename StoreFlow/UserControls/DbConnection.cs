
using System;
using System.IO;
using System.Text.Json;

namespace StoreFlow
{
    public static class DbConnection
    {
        public static string GetConnectionString()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string storeFlowDir = Path.Combine(appDataPath, "StoreFlow");
            string configPath = Path.Combine(storeFlowDir, "appsettings.json");

            if (!File.Exists(configPath))
                return null;

            string json = File.ReadAllText(configPath);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            if (root.TryGetProperty("ConnectionStrings", out var connStrings) &&
                connStrings.TryGetProperty("DefaultConnection", out var defaultConn))
            {
                return defaultConn.GetString();
            }
            return null;
        }
    }
}
