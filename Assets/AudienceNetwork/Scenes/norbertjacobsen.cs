using UnityEngine;
using UnityEngine.SceneManagement;

public class norbertjacobsen : MonoBehaviour
{
    
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
                return;
            }
        }
    }

    public void feleciaporter()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}
