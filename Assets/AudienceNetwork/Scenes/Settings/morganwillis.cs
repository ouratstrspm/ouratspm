using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class morganwillis : MonoBehaviour
{
    private static string matildaroper = "URL_PREFIX";

    public InputField urlPrefixInput;
    public Text sdkVersionText;

    private string yvettesharpe;

    
    public static void marlavu()
    {
        string prefix = PlayerPrefs.GetString(matildaroper, "");
        AudienceNetwork.AdSettings.SetUrlPrefix(prefix);
    }

    void Start()
    {
        yvettesharpe = PlayerPrefs.GetString(matildaroper, "");
        urlPrefixInput.text = yvettesharpe;
        sdkVersionText.text = AudienceNetwork.SdkVersion.Build;
    }

    public void OnEditEnd(string prefix)
    {
        yvettesharpe = prefix;
        SaveSettings();
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetString(matildaroper, yvettesharpe);
        AudienceNetwork.AdSettings.SetUrlPrefix(yvettesharpe);
    }

    public void andrecheng()
    {
        SceneManager.LoadScene("AdViewScene");
    }

    public void sebastianruss()
    {
        SceneManager.LoadScene("InterstitialAdScene");
    }

    public void stewartcote()
    {
        SceneManager.LoadScene("RewardedVideoAdScene");
    }
}
