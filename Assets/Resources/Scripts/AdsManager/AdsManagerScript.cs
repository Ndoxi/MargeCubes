using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;


public class AdsManagerScript : MonoBehaviour
{
    //Banner settings
    private const string TestBannerId = "ca-app-pub-3940256099942544/6300978111";
    private float _bannerDuration = 5;
    private BannerView _bannerView;

    //Show banner each n shots
    private int _shotsAmount = 20;
    private int _shotsTotal;


    private void Start()
    {
        //Initialize Ads
        MobileAds.Initialize(initStatus => { });

        StartCoroutine(ShowBanner());
    }


    private void OnEnable()
    {
        AimState.ShotCubeEvent += AddShot;
    }


    private void OnDisable()
    {
        AimState.ShotCubeEvent -= AddShot;
    }


    private void AddShot()
    {
        _shotsTotal++;

        if (_shotsTotal % _shotsAmount == 0)
        {
            StartCoroutine(ShowBanner());
        }
    }

    
    IEnumerator ShowBanner()
    {
        Debug.Log("Show add");

        if (_bannerView != null) { _bannerView.Destroy(); }

        string adUnitId = TestBannerId;
        _bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        _bannerView.LoadAd(request);

        yield return new WaitForSecondsRealtime(_bannerDuration);
        _bannerView.Destroy();
        _bannerView = null;
    }
}