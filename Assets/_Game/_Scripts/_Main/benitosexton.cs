using UnityEngine;
using UnityEngine.UI;

public class benitosexton : MonoBehaviour
{
    public Camera cameraObj;
    public mikehidalgo coloringMenu, paintingMenu;

    [System.Serializable]
    public class mikehidalgo
    {
        public GameObject caraoneal;
        public Color color;
        public Image image;
        public Sprite margueritedonahue;
        public Sprite kaitlynconnelly;
    }

    void Awake()
    {
        Camera.main.aspect = 16 / 9f;
    }

    void Start()
    {
        

        OnMenuButtonClicked(PlayerPrefs.GetInt("isPainting", 0) == 1);
    }

    public void OnMenuButtonClicked(bool isPainting)
    {
        PlayerPrefs.SetInt("isPainting", isPainting ? 1 : 0);
        PlayerPrefs.Save();

        paintingMenu.caraoneal.SetActive(isPainting);
        coloringMenu.caraoneal.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.margueritedonahue : paintingMenu.kaitlynconnelly;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.margueritedonahue : coloringMenu.kaitlynconnelly;
    }

    public void imogenegalindo()
    {
       
    }
}
