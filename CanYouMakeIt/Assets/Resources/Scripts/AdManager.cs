using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;

public class AdManager : MonoBehaviour {

	public static AdManager Instance{set;get;}

	public string bannerId;
	public string videoId;

	private void Start(){
		Instance = this;
		DontDestroyOnLoad (gameObject);

		Admob.Instance ().initAdmob (bannerId, videoId);
		Admob.Instance ().loadInterstitial ();
	}

	public void ShowBanner() {
		Admob.Instance ().showBannerRelative (AdSize.Banner, AdPosition.BOTTOM_CENTER, 0);
	}

	public void ShowVideo() {
        if (Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();

        }
        else
        {
            Admob.Instance().loadInterstitial();
            Admob.Instance().showInterstitial();
        }
	}
}
