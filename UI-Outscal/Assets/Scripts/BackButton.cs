using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public Button Back;
    public string MainScene;

    // Start is called before the first frame update
    public void Start()
    {
        Back.onClick.AddListener(OnBackClicked);
    }

    public void OnBackClicked()
    {
        SceneManager.LoadScene(MainScene);
    }

}
