using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainUI : MonoBehaviour
{
    public Button Red;
    public Button Green;
    public Button Blue;

    public string RedScene;
    public string GreenScene;
    public string BlueScene;

    private void Start()
    {
       Red.onClick.AddListener(OnRedClicked);
       Green.onClick.AddListener(OnGreenClicked);
       Blue.onClick.AddListener(OnBlueClicked);
    }

    public void OnRedClicked()
    {
        SceneManager.LoadScene(RedScene);
    }

    public void OnGreenClicked()
    {
        SceneManager.LoadScene(GreenScene);
    }

    public void OnBlueClicked()
    {
        SceneManager.LoadScene(BlueScene);
    }
}
