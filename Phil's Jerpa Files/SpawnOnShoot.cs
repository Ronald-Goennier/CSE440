using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnShoot : MonoBehaviour {

    public Transform healthKitPoint;
    public GameObject healthKit;        //Medkit prefab
    public Vector2 position;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "bulletcollide")
        {
            Instantiate(healthKit, healthKitPoint.position, healthKitPoint.rotation);
            Debug.Log("Medkit Created!");
            Destroy(gameObject);
        }
    }
}
