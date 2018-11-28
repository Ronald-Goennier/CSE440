using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour 
{
    public Transform Firepoint; //point where bullet spawns
    public GameObject bulletPrefab; //bullet object

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, Firepoint.position, Firepoint.rotation);
    }
}