using Microsoft.Win32;

namespace MediaPlayerPromptDisabler
{
    public class RegistryUtils
    {
        public static void AddKeyToCurrentUserRegistry(string key, string value, string location)
        {
            using (RegistryKey rKey = Registry.CurrentUser.CreateSubKey(location))
            {
                rKey.SetValue(key, value);
            }
        }

        public static void RemoveKeyFromCurrentUserRegistry(string key, string location)
        {
            using (RegistryKey rKey = Registry.CurrentUser.OpenSubKey(location, true))
            {
                rKey.DeleteValue(key, true);
            }
        }

        public static bool CheckKeyExists(string key, string location)
        {
            return Registry.CurrentUser.OpenSubKey(location).GetValue(key, null) != null;
        }
    }
}
