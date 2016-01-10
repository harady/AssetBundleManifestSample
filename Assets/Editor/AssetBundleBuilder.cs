using UnityEditor;

public static class AssetBundleBuilder
{
	[MenuItem ("Test/BuildAssetBundles")]
	public static void BuildAssetBundles ()
	{
		BuildPipeline.BuildAssetBundles ("Assets/AssetBundles");
	}
}
