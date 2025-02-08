using HarmonyLib;
using UnityEngine;

namespace FloodedOnly.Patches;
    

public class Flood
        {
            [HarmonyPatch(typeof(StartOfRound), "SetPlanetsWeather")]
            [HarmonyPrefix]
            public static bool SetPlanetsWeather(StartOfRound __instance)
            {
                
                foreach (SelectableLevel val in __instance.levels)
                {
                    val.currentWeather = (LevelWeatherType)4;
                    Debug.Log($"SetPlanetsWeather: {val.PlanetName + val.currentWeather}");
                    
                }
                return false;
            }

        }


public class NewFlooded
{
    
            [HarmonyPatch(typeof(FloodWeather), "OnEnable")]
            [HarmonyPrefix]
            public static void SetToCurrentLevelWeather()
            {
                
                if (TimeOfDay.Instance.currentLevel.levelID == 9)
                {
                    TimeOfDay.Instance.currentWeatherVariable = 0;
                    Debug.Log("Lets Try");
                    
                }
                if (TimeOfDay.Instance.currentLevel.levelID == 12)
                {
                    TimeOfDay.Instance.currentWeatherVariable = 0;
                    Debug.Log("Lets Try");
                    
                }
                if (TimeOfDay.Instance.currentLevel.levelID == 6)
                {
                    TimeOfDay.Instance.currentWeatherVariable = -18;
                    Debug.Log("Lets Try");
                    
                }
                        
                
            }
            
            [HarmonyPatch(typeof(FloodWeather), "OnGlobalTimeSync")]
            [HarmonyPrefix]
            
            public static void SetSync()
            {
                if (TimeOfDay.Instance.currentLevel.levelID == 9)
                {
                    TimeOfDay.Instance.currentWeatherVariable2 = 3;
                    Debug.Log("Lets Try");
                    
                }
                if (TimeOfDay.Instance.currentLevel.levelID == 12)
                {
                    TimeOfDay.Instance.currentWeatherVariable2 = 1;
                    Debug.Log("Lets Try");
                    
                }
                if (TimeOfDay.Instance.currentLevel.levelID == 6)
                {
                    TimeOfDay.Instance.currentWeatherVariable2 = 3;
                    Debug.Log("Lets Try");
                    
                }
            }
            
            [HarmonyPatch(typeof(FloodWeather), "Update")]
            [HarmonyPrefix]
            public static void Update()
            {
                if (TimeOfDay.Instance.currentLevel.levelID == 9)
                {
                    TimeOfDay.Instance.currentWeatherVariable = 0;
                    TimeOfDay.Instance.currentWeatherVariable2 = 3;
                    
                    
                }
                if (TimeOfDay.Instance.currentLevel.levelID == 12)
                {
                    TimeOfDay.Instance.currentWeatherVariable = 0;
                    TimeOfDay.Instance.currentWeatherVariable2 = 1;
                    
                    
                }
                if (TimeOfDay.Instance.currentLevel.levelID == 6)
                {
                    TimeOfDay.Instance.currentWeatherVariable = -18;
                    TimeOfDay.Instance.currentWeatherVariable2 = 3;
                    
                    
                }
                
            }
}