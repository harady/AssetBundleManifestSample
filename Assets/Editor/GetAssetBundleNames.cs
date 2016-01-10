using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public static class GetAssetBundleNames
{
	[MenuItem ("Test/GetAssetBundleNames")]
	static void GetNames ()
	{
		var nameList = AssetDatabase.GetAllAssetBundleNames ().ToList ();
		nameList.ForEach (aName => Debug.Log ("AssetBundle: " + aName));
	}
}
