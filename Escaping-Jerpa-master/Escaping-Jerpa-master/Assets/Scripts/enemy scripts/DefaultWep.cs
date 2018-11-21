using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//spawn the default bullet from player default wep fire point


public class DefaultWep : MonoBehaviour {

    public Transform firePoint; //point where bullet spawns
    public GameObject bulletPrefab; //bullet object

    // Update is called once per frame
    void Update () {
		
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

