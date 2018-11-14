using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour {

    //enemy shooting 

    [SerializeField]
    private Transform enemyFirepoint;   //point where enemy bullets spawn
    [SerializeField]
    private GameObject enemyBulletPrefab;   //enemy bullet object
    [SerializeField]
    private float enemyShootingRate;    //rate at which enemy fires bullets

	// Update is called once per frame
	void Update () {
        
        enemyShootingRate -= Time.deltaTime;
		
        if(enemyShootingRate <= 0)
        {
            Instantiate(enemyBulletPrefab, enemyFirepoint.position, enemyFirepoint.rotation);   //spawn enemy bullet
            enemyShootingRate = Random.Range(2f, 4f);   //random time cooldown for when enemy can shoot again
        }
        
	}

}
