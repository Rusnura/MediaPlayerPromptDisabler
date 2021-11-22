using System.Reflection;

namespace MediaPlayerPromptDisabler
{
    public class AutorunHelper
    {
        private const string APPLICATION_ID = "MediaPlayerPromptDisabler";
        private const string AUTORUN_REGISTRY_PATH = "Software\\Microsoft\\Windows\\CurrentVersion\\Run\\";

        private static string applicationExecFile = "\"" + Assembly.GetEntryAssembly().Location + "\"";

        public static bool SetApplicationAutorunState(bool state)
        {
            try
            {
                if (RegistryUtils.CheckKeyExists(APPLICATION_ID, AUTORUN_REGISTRY_PATH))
                {
                    RegistryUtils.RemoveKeyFromUserRegistry(APPLICATION_ID, AUTORUN_REGISTRY_PATH);
                }

                if (state)
                {
                    RegistryUtils.AddKeyToUserRegistry(APPLICATION_ID, applicationExecFile, AUTORUN_REGISTRY_PATH);
                }
                return true;
            }
            catch
            {
                // TODO: Log...
                return false;
            }
        }
    }
}
