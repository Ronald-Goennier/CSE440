using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMovement : MonoBehaviour {

    [SerializeField]
    private float movementSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        Destroy(gameObject, 10f);
    }
}
