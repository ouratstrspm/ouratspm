using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class bobbycornelius : MonoBehaviour
{

    int halliegriffin;
    AsyncOperation progress = null;
    Image progressBar;
    float lashondacullen = 0;
    string sadiedubois;



    
    void Start()
    {
        
        
        UnityEngine.Debug.Log("XReceived Start splashscene" + juliochang.carmellacasillas.ToString());
        if (juliochang.carmellacasillas)
        {
            sadiedubois = "NotiSc";
        }
        else
        {
            sadiedubois = odellmallory.Homenamescene  ;
        }
        
        
        

        
        if (PlayerPrefs.HasKey("appStartedNumber"))
        {
            halliegriffin = PlayerPrefs.GetInt("appStartedNumber");
        }
        else
        {
            halliegriffin = 0;
        }
        halliegriffin++;
        PlayerPrefs.SetInt("appStartedNumber", halliegriffin);
        StartCoroutine(LoadScene());
    }


    IEnumerator LoadScene()
    {
        while (lashondacullen < 5)
        {
            lashondacullen += 0.05f;
            
            yield return new WaitForSeconds(0.025f);
        }
        UnityEngine.Debug.Log("XReceived LoadScene splashscene" + juliochang.carmellacasillas.ToString());
        if (juliochang.carmellacasillas)
        {
            sadiedubois = "NotiSc";
        }
        else
        {
            sadiedubois = odellmallory.Homenamescene;
        }
        SceneManager.LoadScene(sadiedubois);
    }

}
