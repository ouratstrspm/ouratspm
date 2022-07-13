using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SplashScene : MonoBehaviour
{

    int appStartedNumber;
    AsyncOperation progress = null;
    Image progressBar;
    float myProgress = 0;
    string sceneToLoad;



    // Use this for initialization
    void Start()
    {
        //		if(PlayerPrefs.HasKey("TutorialCompleted"))
        //		{
        UnityEngine.Debug.Log("XReceived Start splashscene" + PushNoti.isnot.ToString());
        if (PushNoti.isnot)
        {
            sceneToLoad = "NotiSc";
        }
        else
        {
            sceneToLoad = AdsManager.Homenamescene  ;
        }
        //		}
        //		else
        //			sceneToLoad = "TutorialLevel";

        //		progressBar = GameObject.Find("ProgressBar").GetComponent<Image>();
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            appStartedNumber = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            appStartedNumber = 0;
        }
        appStartedNumber++;
        PlayerPrefs.SetInt("appStartedNumber", appStartedNumber);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (myProgress < 5)
        {
            myProgress += 0.05f;
            //			progressBar.fillAmount=myProgress;
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + PushNoti.isnot.ToString());
        if (PushNoti.isnot)
        {
            sceneToLoad = "NotiSc";
        }
        else
        {
            sceneToLoad = AdsManager.Homenamescene;
        }
        SceneManager.LoadScene(sceneToLoad);
    }

}
