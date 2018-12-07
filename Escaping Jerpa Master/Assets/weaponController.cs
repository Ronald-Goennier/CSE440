using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponController : MonoBehaviour
{
    public bool powerBool = false;
    public bool aBombBool = false;
    public float timer;
    private aBombShoot bomb;
   
	// Use this for initialization
	void Start ()
    {
        GetComponent<PlayerSpreadShoot>().enabled = false;
        bomb = GetComponent<aBombShoot>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (powerBool)
        {
            GetComponent<PlayerSpreadShoot>().enabled = true;
            GetComponent<DefaultWep>().enabled = false;
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                powerBool = false;
                timer = 0;
            }
        }
        else
        {
            GetComponent<PlayerSpreadShoot>().enabled = false;
            GetComponent<DefaultWep>().enabled = true;
        }
        
        if (aBombBool)
        {
            bomb.enabled = true;
        }
        else
        {
            bomb.enabled = false;
        }

    }

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "powerup")
        {
            Debug.Log("Powered Up");
            powerBool = true;
        }
    }
}
