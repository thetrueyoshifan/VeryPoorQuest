using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRCModLoader;

namespace VeryPoorQuest
{
    [VRCModInfo("VeryPoorQuest", "1.0.0", "Emilia")]
    public class VeryPoorQuest : VRCMod
    {
        static void OnApplicationStart()
        {
            if (UnityEngine.Application.platform == UnityEngine.RuntimePlatform.WindowsPlayer)
                VRCModLogger.Log("[VeryPoorQuest] This module is intended for use on the Quest! PC users can already set their performance rating minimum...");
        }
        void OnLevelWasLoaded(int level)
        {
            if (level == 1 && (int)Storage.Read("VRC_AVATAR_PERFORMANCE_RATING_MINIMUM_TO_DISPLAY", typeof(int), 5) != 5)
            {
                Storage.Write("VRC_AVATAR_PERFORMANCE_RATING_MINIMUM_TO_DISPLAY", 5);
                Storage.SaveNow();
                VRCModLogger.Log("[VeryPoorQuest] The deed is done. Have a nice day!");
            }
        }
    }
}
