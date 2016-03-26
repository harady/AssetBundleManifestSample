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
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles/webplayer", BuildAssetBundleOptions.None, BuildTarget.WebPlayer);
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles/android", BuildAssetBundleOptions.None, BuildTarget.Android);
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles/ios", BuildAssetBundleOptions.None, BuildTarget.iOS);
	}
	#endregion
}
