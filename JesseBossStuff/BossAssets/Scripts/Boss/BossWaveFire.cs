﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWaveFire : MonoBehaviour
{

    //enemy shooting 


    private float firingAnimTimer = .7f;

    [SerializeField]
    private Transform FirePoint;   //point where enemy bullets spawn

    [SerializeField]
    private GameObject BossWavePrefab, BossWavePrefab2;   //enemy bullet object

    //random range interval for firing rate
    [SerializeField]
    private float shootRate1;
    [SerializeField]
    private float shootRate2;

    private float firingrate = 3;

    // Update is called once per frame
    void Update()
    {
        firingrate -= Time.deltaTime;

        if (firingrate <= 0)
        {
            firingAnimTimer -= Time.deltaTime;
            if (firingAnimTimer <= 0)
            //StartCoroutine(time());
            {
                Instantiate(BossWavePrefab, FirePoint.position, FirePoint.rotation);   //spawn enemy bullet
                Instantiate(BossWavePrefab2, new Vector2(FirePoint.position.x, FirePoint.position.y + 3), FirePoint.rotation);   //spawn enemy bullet
                firingrate = Random.Range(shootRate1, shootRate2);   //random time cooldown for when enemy can shoot again
               
                firingAnimTimer = .7f;
            }
            /*Instantiate(enemyBulletPrefab, enemyFirepoint.position, enemyFirepoint.rotation);   //spawn enemy bullet
            firingrate = Random.Range(enemyShootingRate1, enemyShootingRate2);   //random time cooldown for when enemy can shoot again
            shooting.SetBool("ifShooting", false);*/
        }

    }
    /*
    IEnumerator time()
    {
        shooting.SetBool("ifShooting", true);
        yield return new WaitForSeconds(3);
    }
    */
}