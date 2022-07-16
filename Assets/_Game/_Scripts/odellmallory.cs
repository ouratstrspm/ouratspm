using AudienceNetwork;
using Firebase.Database;

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class odellmallory : MonoBehaviour
{

    public string melvapoole;
    public GameObject mamiemckenzie;

    #region AdMob
    [Header("Admob")]
    public string judithpatrick = "";
    public string jamierodriquez = "";
    public string fannymadden = "";
    public bool maryellenrice = false;

    #endregion
    [Space(15)]
    #region
    [Header("UnityAds")]
    public string alysonmelton;
    public string unityAdsVideoPlacementId = "rewardedVideo";
    #endregion

    static odellmallory instance;

    public static int unlockID;

    public static odellmallory Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType(typeof(odellmallory)) as odellmallory;

            return instance;
        }
    }


    public static bool isfbads = false;
    public static bool isApplovin = false;
    public static bool isUnityads = false;
    public static bool isadmob = false;
    string applovinads = "557f3fb0343826c3";
    string applovinads5 = "";
    string applovinads20 = "";
    string applovinads50 = "";
    string isdone = "";


    string fbnetwordinter = "739265130815410_754973412577915";
    public static string firebaselink = "https://peppa-47863-default-rtdb.firebaseio.com/";
    public static string Homenamescene = "MainScene";


    void CheckAds()
    {
        UnityEngine.Debug.Log("XReceived CheckAdss ");

        FirebaseDatabase.GetInstance(firebaselink)
      .GetReference("MyMob")
      .GetValueAsync().ContinueWith(task =>
      {
          try
          {


              if (task.IsFaulted)
              {
                  UnityEngine.Debug.Log("XReceived data error ");

              }
              else if (task.IsCompleted)
              {
                  DataSnapshot snapshot = task.Result;
                  isfbads = (bool)snapshot.Child("isfbads").Value;
                  isApplovin = (bool)snapshot.Child("isApplovin").Value;
                  isUnityads = (bool)snapshot.Child("isUnityads").Value;

                  applovinads5 = (string)snapshot.Child("applovinads5").Value;
                  applovinads20 = (string)snapshot.Child("applovinads20").Value;
                  applovinads50 = (string)snapshot.Child("applovinads50").Value;
                  isdone = (string)snapshot.Child("Data").Value;
                  UnityEngine.Debug.Log("XReceived data sucsess isfbads " + isfbads.ToString());
                  UnityEngine.Debug.Log("XReceived data sucsess isApplovin " + isApplovin.ToString());
                  UnityEngine.Debug.Log("XReceived data sucsess isUnityads " + isUnityads.ToString());
                  onetime = true;
                  maryellenrice = (bool)snapshot.Child("isrev").Value;
              }
          }
          catch (Exception ex)
          {
              UnityEngine.Debug.Log(ex.Message);

          }
      });

    }





    void Awake()
    {

        CheckAds();

        MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
        {

        };
        string part1 = "LVMxil1GcF_Ravh5gH_xKbVh4WJxxH0EB7m1";
        string part2 = "PTt2309K1aVcRIHkkacr6dzm6oNP";
        string part3 = "-NJwHGGARatLan-EvNF-LM";
        MaxSdk.SetSdkKey(part1 + part2 + part3);
        MaxSdk.InitializeSdk();
        gameObject.name = this.GetType().Name;
        DontDestroyOnLoad(gameObject);
    }

    int claudinealonso;
    public void LoadApplovin()
    {

        MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += OnInterstitialLoadedEvent;
        MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += OnInterstitialLoadFailedEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += OnInterstitialDisplayedEvent;
        MaxSdkCallbacks.Interstitial.OnAdClickedEvent += OnInterstitialClickedEvent;
        MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += OnInterstitialHiddenEvent;
        MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += OnInterstitialAdFailedToDisplayEvent;


        LoadInterstitial();
    }

    bool onetime = false;
    void Update()
    {
        if (onetime)
        {
            UnityEngine.Debug.Log("onetime");

            onetime = false;
            LoadApplovin();

        }
    }
    private void LoadInterstitial()
    {
        UnityEngine.Debug.Log("LoadInterstitial");

        MaxSdk.LoadInterstitial(applovinads);
        try
        {


            if (applovinads50.Length > 0)
            {
                MaxSdk.LoadInterstitial(applovinads50);
                MaxSdk.LoadInterstitial(applovinads5);
                MaxSdk.LoadInterstitial(applovinads20);

            }
        }
        catch
        {
            applovinads50 = "";
            applovinads5 = "";
            applovinads20 = "";
        }
    }

    private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {


    }

    private void OnInterstitialLoadFailedEvent(string dorapadgett, MaxSdkBase.ErrorInfo errorInfo)
    {



        claudinealonso++;
        double retryDelay = System.Math.Pow(2, System.Math.Min(6, claudinealonso));

        Invoke("LoadInterstitial", (float)retryDelay);
    }

    private void OnInterstitialDisplayedEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialAdFailedToDisplayEvent(string dorapadgett, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {

        LoadInterstitial();
    }

    private void OnInterstitialClickedEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo) { }

    private void OnInterstitialHiddenEvent(string dorapadgett, MaxSdkBase.AdInfo adInfo)
    {

        LoadInterstitial();
    }


    public void ShowInterstitial()
    {
        Debug.Log("ZOVEM INTERSTITIAL");
        ShowAdMob();
    }
    private IEnumerator chasityhatch()
    {
        yield return new WaitForSeconds(0.4f);
    }
    public void IsVideoRewardAvailable()
    {
        if (isVideoAvaiable())
        {

        }
        else
        {

        }
    }

    bool isVideoAvaiable()
    {








        return false;
    }

    public void ShowVideoReward(int ID)
    {








    }

    public void ShowApplovin()
    {
        if (applovinads50.Length > 0)
        {
            if (MaxSdk.IsInterstitialReady(applovinads50))
            {
                MaxSdk.ShowInterstitial(applovinads50);
                Debug.Log("applovinads50");

            }
            else if (MaxSdk.IsInterstitialReady(applovinads20))
            {
                MaxSdk.ShowInterstitial(applovinads20);
                Debug.Log("applovinads20");
            }
            else if (MaxSdk.IsInterstitialReady(applovinads5))
            {
                MaxSdk.ShowInterstitial(applovinads5);
                Debug.Log("applovinads5");
            }
            else
            {
                MaxSdk.ShowInterstitial(applovinads);
                Debug.Log("applovinadsDeff");
            }
        }
        else
        {


            if (MaxSdk.IsInterstitialReady(applovinads))
            {
                MaxSdk.ShowInterstitial(applovinads);
                Debug.Log("applovinadsDeff");

            }

        }
        LoadInterstitial();

    }


    public void ShowAdMob()
    {
        if (isApplovin)
        {
            ShowApplovin();
        }
        else if (isUnityads)
        {
            ShowAdUnity();
        }
        else if (isfbads)
        {
            ShowInterstitialfb();
        }

    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }



    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }


    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeftApplication event received");
    }

    private void RequestRewardedVideo()
    {

    }

    public void HandleRewardBasedVideoLoadedAdMob(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");

    }



    public void HandleRewardBasedVideoOpenedAdMob(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
    }

    public void HandleRewardBasedVideoStartedAdMob(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
    }

    public void HandleRewardBasedVideoClosedAdMob(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoClosed event received");
    }



    public void HandleRewardBasedVideoLeftApplicationAdMob(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLeftApplication event received");
    }



    void AdMobShowVideo()
    {
    }




    public void VideoRewarded()
    {

    }



    private AudienceNetwork.InterstitialAd interstitialAd;
    private bool karenhinson;
    public void LoadInterstitialfb()
    {
        this.interstitialAd = new AudienceNetwork.InterstitialAd(fbnetwordinter);
        this.interstitialAd.Register(this.gameObject);


        this.interstitialAd.InterstitialAdDidLoad = (delegate ()
        {
            Debug.Log("Interstitial ad loaded.");
            this.karenhinson = true;
        });
        interstitialAd.InterstitialAdDidFailWithError = (delegate (string error)
        {
            Debug.Log("Interstitial ad failed to load with error: " + error);
        });
        interstitialAd.InterstitialAdWillLogImpression = (delegate ()
        {
            Debug.Log("Interstitial ad logged impression.");
        });
        interstitialAd.InterstitialAdDidClick = (delegate ()
        {
            Debug.Log("Interstitial ad clicked.");
        });

        this.interstitialAd.interstitialAdDidClose = (delegate ()
        {
            Debug.Log("Interstitial ad did close.");
            if (this.interstitialAd != null)
            {
                this.interstitialAd.Dispose();
            }
        });


        this.interstitialAd.LoadAd();
    }

    public void ShowInterstitialfb()
    {
        if (this.karenhinson)
        {
            this.interstitialAd.Show();
            this.karenhinson = false;

        }
        else
        {
            Debug.Log("Interstitial Ad not loaded!");
        }
    }



    string gameId = "4742728";
    string _adUnitId = "Interstitial_Android";


    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }





    public void ShowAdUnity()
    {

        Debug.Log("Showing Ad: " + _adUnitId);
    }


    public void OnUnityAdsAdLoaded(string adUnitId)
    {

    }



    public void OnUnityAdsShowStart(string adUnitId) { }
    public void OnUnityAdsShowClick(string adUnitId) { }




    void initadmob()
    {


    }

































}
