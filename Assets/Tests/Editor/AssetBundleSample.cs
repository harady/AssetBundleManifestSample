using UnityEngine;
using System.Collections;

public class AssetBundleSample : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		AssetBundleManifest manifest;
		manifest.GetAssetBundleHash ("assetBundleName");
		WWW.LoadFromCacheOrDownload ("url", new Hash128 ());
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
