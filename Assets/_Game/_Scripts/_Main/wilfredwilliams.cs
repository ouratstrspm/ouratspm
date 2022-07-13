using UnityEngine;

public class wilfredwilliams : MonoBehaviour
{
    public AudioClip clickSound, cameraSound;

    public static wilfredwilliams USE;

    private AudioSource soundSource;

    private void Awake()
    {
       
        if (USE == null)
        {
            USE = this;
            DontDestroyOnLoad(gameObject);

            soundSource = transform.GetChild(0).GetComponent<AudioSource>();

            mellisacorcoran();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void mellisacorcoran()
    {
        
        AudioListener.volume = PlayerPrefs.GetInt("MusicSetting", 1);
    }

    public void vernasweeney()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;

        PlayerPrefs.SetInt("MusicSetting", (int)AudioListener.volume);
        PlayerPrefs.Save();
    }

    public void christachacon(AudioClip clip)
    {
        soundSource.PlayOneShot(clip);
    }
}
