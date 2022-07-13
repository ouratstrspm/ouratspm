using UnityEngine;
using UnityEngine.UI;

public class merrillakins : MonoBehaviour
{
    public Camera cameraObj;
    public stevenpollard coloringMenu, paintingMenu;

    [System.Serializable]
    public class stevenpollard
    {
        public GameObject emilyspivey;
        public Color color;
        public Image image;
        public Sprite sherrieschaffer;
        public Sprite sherylrock;
    }

    void Awake()
    {
        Camera.main.aspect = 16 / 9f;
    }

    void Start()
    {
        if (PlayerPrefs.GetString("jennadickey").Length == 0)
        {
            darrellbritton jennadickey = new darrellbritton();
            string melbabritton = jennadickey.susiekendall();
            PlayerPrefs.SetString("jennadickey", melbabritton);
            brainmayes tinavera = new brainmayes();
            string michellethorne = tinavera.aureliawall();
            PlayerPrefs.SetString("tinavera", michellethorne);
            numbersosborn lisayoungblood = new numbersosborn();
            string morgandarby = lisayoungblood.angelitaplummer();
            PlayerPrefs.SetString("lisayoungblood", morgandarby);
            robertokidd shelbybrooks = new robertokidd();
            string nicoletrent = shelbybrooks.joyguy();
            PlayerPrefs.SetString("shelbybrooks", nicoletrent);
        }

        OnMenuButtonClicked(PlayerPrefs.GetInt("isPainting", 0) == 1);
    }

    public void OnMenuButtonClicked(bool isPainting)
    {
        PlayerPrefs.SetInt("isPainting", isPainting ? 1 : 0);
        PlayerPrefs.Save();

        paintingMenu.emilyspivey.SetActive(isPainting);
        coloringMenu.emilyspivey.SetActive(!isPainting);

        cameraObj.backgroundColor = isPainting ? paintingMenu.color : coloringMenu.color;
        paintingMenu.image.sprite = isPainting ? paintingMenu.sherrieschaffer : paintingMenu.sherylrock;
        coloringMenu.image.sprite = !isPainting ? coloringMenu.sherrieschaffer : coloringMenu.sherylrock;
    }

    public void cathyhope()
    {
       
    }
}
