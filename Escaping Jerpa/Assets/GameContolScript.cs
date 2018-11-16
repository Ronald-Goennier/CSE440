using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls the amount of time the level lasts, how long until the boss fight begins, and resets the meter for boss health
/// </summary>
public class GameContolScript : MonoBehaviour
{
    public Slider levelSlider;
    private float levelTimer = 180;
    //private float bossSetTimer = 5;
    private ObstacleSpawning obstacleObject;
    private enemySpawn enemyObject;
    private ObjectSpawn objectSpawn;
    private HealthKitSpawn healthObject;


	// Use this for initialization
	void Start ()
    {
        //levelSlider.GetComponent<Slider>();
        GameObject obstacleControl = GameObject.FindGameObjectWithTag("LevelObject");
        if(obstacleControl)
        {
            obstacleObject = obstacleControl.GetComponent<ObstacleSpawning>();
            enemyObject = obstacleControl.GetComponent<enemySpawn>();
            objectSpawn = obstacleControl.GetComponent<ObjectSpawn>();
            healthObject = obstacleControl.GetComponent<HealthKitSpawn>();
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        levelTimer -= Time.deltaTime;
        if(levelTimer <= 0)
        {
            obstacleObject.enabled = false;
            enemyObject.enabled = false;
            objectSpawn.enabled = false;
            healthObject.enabled = false;

            /*bossSetTimer -= Time.deltaTime;
            if(bossSetTimer <= 0)
            {
                Time.timeScale = 0;
            }*/

        }
	}
}
