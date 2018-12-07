using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aBombShoot : MonoBehaviour {

    public Transform firePoint;
    public GameObject bombPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetButtonDown("Fire3"))
        {
            AudioManager.instance.Play("Player", "Bomb", gameObject);
            Instantiate(bombPrefab, firePoint.position, firePoint.rotation);
            GetComponent<weaponController>().aBombBool = false;
        }
	}
}
