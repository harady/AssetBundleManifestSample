using System.IO;
using UnityEditor;

public static class AssetBundleBuilder
{
	#region MenuItem
	[MenuItem ("Test/BuildAssetBundles")]
	public static void BuildAssetBundlesMenu ()
	{
		BuildAssetBundles ();
	}
	#endregion
	#region
	public static void BuildAssetBundles ()
	{
		Directory.CreateDirectory ("Assets/AssetBundles/webplayer");
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles/webplayer", BuildAssetBundleOptions.None, BuildTarget.WebPlayer);
		Directory.CreateDirectory ("Assets/AssetBundles/android");
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles/android", BuildAssetBundleOptions.None, BuildTarget.Android);
		Directory.CreateDirectory ("Assets/AssetBundles/ios");
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles/ios", BuildAssetBundleOptions.None, BuildTarget.iOS);
	}
	#endregion
}
