using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;

	// Use this for initialization
	void Start ()
    {
        Button btn1 = startButton.gameObject.GetComponent<Button>();
        Button btn2 = quitButton.gameObject.GetComponent<Button>();

        btn1.onClick.AddListener(GameStart);
        btn2.onClick.AddListener(GameEnd);
	}

    void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }
	
    void GameEnd()
    {
        Application.Quit();
    }

	// Update is called once per frame
	void Update ()
    {
		
	}
}
