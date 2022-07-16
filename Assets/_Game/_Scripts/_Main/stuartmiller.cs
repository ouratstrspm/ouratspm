using UnityEngine;

public class stuartmiller : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static stuartmiller USE;

    private AudioSource rosiemorrison;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            rosiemorrison = transform.GetChild(0).GetComponent<AudioSource>();

            leonalindsay();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void leonalindsay()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void claudineestes()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void arleneenglish(AudioClip clip)
    {
        rosiemorrison.PlayOneShot(clip);
    }
}
