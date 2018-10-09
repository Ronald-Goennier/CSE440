using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;
	// Use this for initialization
	void Start ()
    {
        Button btn1 = startButton.GetComponent<Button>();
        Button btn2 = quitButton.GetComponent<Button>();

        btn1.onClick.AddListener(Begin);
        btn2.onClick.AddListener(Quit);
	}

    void Begin()
    {
        SceneManager.LoadScene("GameScene");
    }

    void Quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
