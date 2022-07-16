using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class frankiecrosby : MonoBehaviour
{
    
    void Start()
    {

        stefaniejordan();
    }

    
    bool carolinawoody = false;




    void Update()
    {
        if (sybilsnyder.Length > 0 && !carolinawoody)
        {
            carolinawoody = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + nonameza);

            if (nonameza.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(brendabaxter(renehuynh, image));
                return;
            }
            else if (leonordickerson.Length > 0)
            {
                odellmallory.Instance.ShowApplovin();
            }
            else if (kristinbassett.Length > 0)
            {
                odellmallory.Instance.ShowInterstitialfb();
            }
            else if (oliviaybarra.Length > 0)
            {
                odellmallory.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(odellmallory.Homenamescene);

        }
    }

    string kristinbassett = "";
    string renehuynh = "";
    string leonordickerson = "";
    string oliviaybarra = "";
    string nonameza = "";
    string sybilsnyder = "";

    void stefaniejordan()
    {
        FirebaseDatabase.GetInstance(odellmallory.firebaselink)
      .GetReference("MyMob")
      .GetValueAsync().ContinueWith(task =>
      {
          if (task.IsFaulted)
          {
              UnityEngine.Debug.Log("XReceived data error ");

          }
          else if (task.IsCompleted)
          {
              DataSnapshot snapshot = task.Result;
              kristinbassett = snapshot.Child("NotiFbads").Value.ToString();
              renehuynh = snapshot.Child("NotiImg").Value.ToString();
              leonordickerson = snapshot.Child("NotiLovin").Value.ToString();
              oliviaybarra = snapshot.Child("NotiUnityads").Value.ToString();
              oliviaybarra = snapshot.Child("NotiUnityads").Value.ToString();
              nonameza = snapshot.Child("NotiUrl").Value.ToString();
              sybilsnyder = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived renehuynh " + renehuynh);
              UnityEngine.Debug.Log("XReceived nonameza " + nonameza);

          }
      });

    }

    public void janburton()
    {
        Application.OpenURL(nonameza);

    }

    UnityWebRequest www;
    IEnumerator brendabaxter(string url, Image targetImage)
    {
        using (www = UnityWebRequestTexture.GetTexture(url))
        {
            
            yield return www.SendWebRequest();

            if (!www.isDone)
            {
                Debug.Log("Error while Receiving: " + www.error);
            }
            else
            {
                Debug.Log("Success");

                
                var texture2d = DownloadHandlerTexture.GetContent(www);
                var sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), Vector2.zero);
                targetImage.sprite = sprite;
            }
        }
    }


}
