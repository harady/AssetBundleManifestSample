using UnityEditor;
using UnityEngine;

/// <summary>
/// アセットバンドル関連処理のエディターウィンドウ.
/// </summary>
public class AssetBundleEditorWindow : EditorWindow
{
	#region PublicMethods
	[MenuItem ("Test/AssetBundleWindow")]
	public static void  ShowWindow ()
	{
		EditorWindow.GetWindow (typeof(AssetBundleEditorWindow));
	}

	public void OnGUI ()
	{
		// アセットバンドルビルド関連ボタン.
		OnGUIButtons ();
	}
	#endregion
	#region PrivateMethods
	private void OnGUIButtons ()
	{
		EditorGUILayout.Separator ();
		EditorGUILayout.PrefixLabel ("アセットバンドルビルド");
		if (GUILayout.Button ("アセットバンドルビルド")) {
			Debug.Log ("アセットバンドルビルド");
			AssetBundleBuilder.BuildAssetBundles ();
		}
	}
	#endregion
}
