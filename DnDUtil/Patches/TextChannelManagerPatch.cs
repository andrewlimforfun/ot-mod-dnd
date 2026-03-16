using Commons.Core.Util;
using HarmonyLib;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Text.RegularExpressions;
using System;

namespace DnDUtil.Patches
{
    [HarmonyPatch(typeof(TextChannelManager))]

    public class TextChannelManagerPatch
    {
    }
}
