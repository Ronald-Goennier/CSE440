using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Spawn an enemy from Obstacle Point, random position and random time

public class enemySpawn : MonoBehaviour
{

    public Transform obstaclePoint;
    public GameObject enemyPrefab;   //enemy object

    public float spawning_timer;    //timer for when enemy spawns
    public Vector3 random_position;     // random position for where enemy spawns

    //spawn an obstacle continuously 
    void Update()
    {
        spawning_timer -= Time.deltaTime;   //decrease timer

        if (spawning_timer <= 0)
        {
            random_position = new Vector3(12, (Random.Range(-7.0f, 5.0f)), 0);  //create vector at random x,y position
            Instantiate(enemyPrefab, random_position, obstaclePoint.rotation);   //create enemy at specified vector
            spawning_timer = Random.Range(3f, 6f);  //wait a random amount of time for next obstacle creation
        }
    }


}
