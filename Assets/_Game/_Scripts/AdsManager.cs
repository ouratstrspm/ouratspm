using AudienceNetwork;
using Firebase.Database;
//using GoogleMobileAds.Api;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class AdsManager : MonoBehaviour 
{

    public string privacyPolicyLink;
    public GameObject instanceunityadobj;

    #region AdMob
    [Header("Admob")]
    public string adMobAppID = "";
    public string interstitalAdMobId = "";
    public string videoAdMobId = "";
    public bool isrev = false;

    #endregion
    [Space(15)]
    #region
    [Header("UnityAds")]
    public string unityAdsGameId;
    public string unityAdsVideoPlacementId = "rewardedVideo";
    #endregion

    static AdsManager instance;

    public static int unlockID;

    public static AdsManager Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType(typeof(AdsManager)) as AdsManager;

            return instance;
        }
    }


    public static bool isfbads = false;
    public static bool isApplovin = false;
    public static bool isUnityads = false;
    public static bool isadmob = false;
    string applovinads = "fd6bfc309e94f6d4";
    string applovinads5 = "";
    string applovinads20 = "";
    string applovinads50 = "";
    string isdone = "";


    string fbnetwordinter = "739265130815410_754973412577915";
    public static string firebaselink = "https://bely-y-beto-e64c9-default-rtdb.firebaseio.com/";
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
                  ////isadmob = (bool)snapshot.Child("isadmob").Value;
                  applovinads5 = (string)snapshot.Child("applovinads5").Value;
                  applovinads20 = (string)snapshot.Child("applovinads20").Value;
                  applovinads50 = (string)snapshot.Child("applovinads50").Value;
                  isdone = (string)snapshot.Child("Data").Value;

                  //isadmob = true;
                  UnityEngine.Debug.Log("XReceived data sucsess isfbads " + isfbads.ToString());
                  UnityEngine.Debug.Log("XReceived data sucsess isApplovin " + isApplovin.ToString());
                  UnityEngine.Debug.Log("XReceived data sucsess isUnityads " + isUnityads.ToString());
                  onetime = true;
                  isrev = (bool)snapshot.Child("isrev").Value;

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
      
       
        // RequestInterstitial(); 
        //  LoadInterstitialfb();
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
        //if(Advertisement.IsReady(unityAdsVideoPlacementId))
        //{
        //    return true;
        //}
        //else if(rewardBasedAdMobVideo.IsLoaded())
        //{
        //    return true;
        //}
        return false;
    }

    public void ShowVideoReward(int ID)
    {
        //if(Advertisement.IsReady(unityAdsVideoPlacementId))
        //{
        //	UnityAdsShowVideo();
        //}
        //else if(rewardBasedAdMobVideo.IsLoaded())
        //{
        //	AdMobShowVideo();
        //}
    }

    public void ShowApplovin()
    {
        if (applovinads50.Length  > 0)
        {
            if (MaxSdk.IsInterstitialReady(applovinads50))
            {
                MaxSdk.ShowInterstitial(applovinads50);
                Debug.Log("applovinads50");

            }
            else if(MaxSdk.IsInterstitialReady(applovinads20))
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


    //facebook ads
    private AudienceNetwork.InterstitialAd interstitialAd;
    private bool isLoaded;
    public void LoadInterstitialfb()
    {
        this.interstitialAd = new AudienceNetwork.InterstitialAd(fbnetwordinter);
        this.interstitialAd.Register(this.gameObject);

        // Set delegates to get notified on changes or when the user interacts with the ad.
        this.interstitialAd.InterstitialAdDidLoad = (delegate ()
        {
            Debug.Log("Interstitial ad loaded.");
            this.isLoaded = true;
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

        // Initiate the request to load the ad.
        this.interstitialAd.LoadAd();
    }

    public void ShowInterstitialfb()
    {
        if (this.isLoaded)
        {
            this.interstitialAd.Show();
            this.isLoaded = false;

        }
        else
        {
            Debug.Log("Interstitial Ad not loaded!");
        }
    }


    //unity ads
    string gameId = "4742728";
    string _adUnitId = "Interstitial_Android";
 

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }

  
  

    // Show the loaded content in the Ad Unit:
    public void ShowAdUnity()
    {
        // Note that if the ad content wasn't previously loaded, this method will fail
        Debug.Log("Showing Ad: " + _adUnitId);
     }

    // Implement Load Listener and Show Listener interface methods: 
    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        // Optionally execute code if the Ad Unit successfully loads content.
    }

   

    public void OnUnityAdsShowStart(string adUnitId) { }
    public void OnUnityAdsShowClick(string adUnitId) { }
 

    //admob

    void initadmob()
    {
        // Initialize the Google Mobile Ads SDK.
        //MobileAds.Initialize(initStatus => { });
    }
    //    public static GoogleMobileAds.Api.InterstitialAd interstitial;

    //    private void RequestInterstitial()
    //    {
    //#if UNITY_ANDROID
    //        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
    //#elif UNITY_IPHONE
    //        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
    //#else
    //        string adUnitId = "unexpected_platform";
    //#endif

    //        // Initialize an InterstitialAd.
    //        interstitial = new GoogleMobileAds.Api.InterstitialAd(adUnitId);
    //        // Create an empty ad request.
    //        AdRequest request = new AdRequest.Builder().Build();
    //        // Load the interstitial with the request.
    //        interstitial.LoadAd(request);
    //    }

    //    private void showinterstitial()
    //    {
    //        if (interstitial.IsLoaded())
    //        {
    //            interstitial.Show();
    //        }
    //    }
    //    public void HandleOnAdClosed(object sender, EventArgs args)
    //    {
    //        //RequestInterstitial();
    //        MonoBehaviour.print("HandleAdClosed event received");
    //    }

}
