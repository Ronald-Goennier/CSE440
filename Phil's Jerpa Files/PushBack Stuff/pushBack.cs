using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 
 * Spawns the push back sphere upon collision.
 */
public class pushBack : MonoBehaviour {

    [SerializeField]
    private GameObject pushBackObject;

    [SerializeField]
    private Transform pushBackPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Instantiate(pushBackObject, pushBackPoint.position, pushBackPoint.rotation);
        }
    }
}
