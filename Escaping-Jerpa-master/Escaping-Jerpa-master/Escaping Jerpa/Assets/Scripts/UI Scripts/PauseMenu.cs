using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// Controlls the Pause Menu to freeze the game when p is pressed or pressed again
/// </summary>
public class PauseMenu : MonoBehaviour
{
    private GameObject[] pauseObjects;
    public Button Continue, Main, Quit, Restart;


	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("PauseMenu");
        hideMenu();

        Button cButton, mButton, qButton, rButton;
        cButton = Continue.GetComponent<Button>();
        mButton = Main.GetComponent<Button>();
        qButton = Quit.GetComponent<Button>();
        rButton = Restart.GetComponent<Button>();

        cButton.onClick.AddListener(continueGame);
        mButton.onClick.AddListener(mainMenu);
        qButton.onClick.AddListener(quitGame);
        rButton.onClick.AddListener(restartLevel);


    }

    // Update is called once per frame
    void Update ()
    {
		if(Input.GetKeyDown(KeyCode.P))
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showMenu();
            }
            else if(Time.timeScale == 0)
            {
                Time.timeScale = 1;
                hideMenu();
            }
        }
	}

    public void hideMenu()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }

    public void showMenu()
    {
        foreach(GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }

    void continueGame()
    {
        hideMenu();
        Time.timeScale = 1;
    }

    void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void restartLevel()
    {
        SceneManager.LoadScene("GameScene");
    }

    void quitGame()
    {
        Application.Quit();
    }
}
