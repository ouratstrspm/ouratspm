using Firebase.Database;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadNoti : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Mygetdata();
    }

    // Update is called once per frame
    bool updated = false;




    void Update()
    {
        if (Datadone.Length > 0 && !updated)
        {
            updated = true;
            UnityEngine.Debug.Log("XReceived Updatesss " + NotiUrl);

            if (NotiUrl.Length > 0)
            {
                var image = GetComponent<Image>();
                StartCoroutine(downloadImage(NotiImg, image));
                return;
            }
            else if (NotiLovin.Length > 0)
            {
                AdsManager.Instance.ShowApplovin();
            }
            else if (NotiFbads.Length > 0)
            {
                AdsManager.Instance.ShowInterstitialfb();
            }
            else if (NotiUnityads.Length > 0)
            {
                AdsManager.Instance.ShowAdUnity();
            }
            SceneManager.LoadScene(AdsManager.Homenamescene);

        }
    }

    string NotiFbads = "";
    string NotiImg = "";
    string NotiLovin = "";
    string NotiUnityads = "";
    string NotiUrl = "";
    string Datadone = "";

    void Mygetdata()
    {
        FirebaseDatabase.GetInstance(AdsManager.firebaselink)
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
              NotiFbads = snapshot.Child("NotiFbads").Value.ToString();
              NotiImg = snapshot.Child("NotiImg").Value.ToString();
              NotiLovin = snapshot.Child("NotiLovin").Value.ToString();
              NotiUnityads = snapshot.Child("NotiUnityads").Value.ToString();
              NotiUnityads = snapshot.Child("NotiUnityads").Value.ToString();
              NotiUrl = snapshot.Child("NotiUrl").Value.ToString();
              Datadone = snapshot.Child("Data").Value.ToString();
              UnityEngine.Debug.Log("XReceived NotiImg " + NotiImg);
              UnityEngine.Debug.Log("XReceived NotiUrl " + NotiUrl);

          }
      });

    }

    public void goads()
    {
        Application.OpenURL(NotiUrl);

    }

    UnityWebRequest www;
    IEnumerator downloadImage(string url, Image targetImage)
    {
        using (www = UnityWebRequestTexture.GetTexture(url))
        {
            //Send Request and wait
            yield return www.SendWebRequest();

            if (!www.isDone)
            {
                Debug.Log("Error while Receiving: " + www.error);
            }
            else
            {
                Debug.Log("Success");

                //Load Image
                var texture2d = DownloadHandlerTexture.GetContent(www);
                var sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), Vector2.zero);
                targetImage.sprite = sprite;
            }
        }
    }


}
