using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script to govern Health Kit movement

public class HealthKitMovement : MonoBehaviour {

    [SerializeField]
    private float movementSpeed;

	// Use this for initialization
	void Awake ()
    {
        Physics2D.IgnoreLayerCollision(10, 10);
	}
	
	// Update is called once per frame
	void Update ()
    {
        Physics2D.IgnoreLayerCollision(10, 10);
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;   	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}
