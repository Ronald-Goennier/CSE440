using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    private GameObject[] gameOverObjects;
    public Button Quit, Restart;

    // Use this for initialization
    void Start ()
    {
        Time.timeScale = 1;
        gameOverObjects = GameObject.FindGameObjectsWithTag("GameOver");
        hideMenu();

        Button qButton, rButton;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void hideMenu()
    {
        foreach(GameObject g in gameOverObjects)
        {
            g.SetActive(false);
        }
    }
}
