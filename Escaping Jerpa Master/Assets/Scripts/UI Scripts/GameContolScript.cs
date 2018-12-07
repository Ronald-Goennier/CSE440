using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Controls the amount of time the level lasts, how long until the boss fight begins, and resets the meter for boss health
/// </summary>
public class GameContolScript : MonoBehaviour
{
    public Slider levelSlider;
    private float levelTimer = 120;
    private GameObject obstacleObject;
    private GameObject backgroundObject;
    public GameObject boss1, boss2;
    private float bossSetTimer = 5;
    public GameObject bikers;
    public GameObject factory;
    private float endTime = 5;


	// Use this for initialization
	void Start ()
    {
        levelSlider.GetComponent<Slider>();
        GameObject obstacleControl = GameObject.FindGameObjectWithTag("LevelObject");
        if(obstacleControl)
        { 
            obstacleObject = obstacleControl;
        }

        GameObject background = GameObject.FindGameObjectWithTag("BackGround");
        if(background)
        {
            backgroundObject = background;
        }

        boss1.SetActive(false);
        boss2.SetActive(false);
        factory.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        levelTimer -= Time.deltaTime;
        if(levelTimer <= 0)
        {
            obstacleObject.gameObject.SetActive(false);
            backgroundObject.gameObject.SetActive(false);
            bikers.SetActive(false);
            factory.SetActive(true);

            bossSetTimer -= Time.deltaTime;
            if(bossSetTimer <= 0)
            {
                boss1.SetActive(true);
                boss2.SetActive(true);
            }
            if(boss2.GetComponent<BossHealth>().health <= 0)
            {
                endTime -= Time.deltaTime;
                if(endTime == 0)
                    SceneManager.LoadScene("OutroText");
            }
        }
	}
}
