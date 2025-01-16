using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using FloodedOnly.Patches;

namespace FloodedOnly;

[BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    
    private const string PLUGIN_GUID = "FloodedOnly";
    private const string PLUGIN_NAME = "Floodedonly";
    private const string PLUGIN_VERSION = "1.0.1";



    private readonly Harmony harmony = new Harmony(PLUGIN_GUID);
   
    private void Awake()
    {
        // Plugin startup logic
        Debug.Log("I am a Cowboy");
        harmony.PatchAll(typeof(Flood));
        
    }
}
