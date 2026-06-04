using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    bool TestMode = true;
    string GameID = "4595289";
    string VideoAdID = "Interstitial_Android";

    void Start()
    {
        Advertisement.Initialize(GameID,TestMode);
    }

    public void DisplayVideoAds()
    {
        Advertisement.Show(VideoAdID);
    }
}
