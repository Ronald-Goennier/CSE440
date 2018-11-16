using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour {

    public Transform objectPoint;

    [SerializeField]
    private GameObject misc_object; //object to spawn
    /*[SerializeField]
    private GameObject misc_object2; //object to spawn
    [SerializeField]
    private GameObject misc_object3; //object to spawn
    */
    private float startTimer = .5f; //preset spawn time only for the first spawn
    [SerializeField]
    private float yPos;

    [SerializeField]
    private float newTimer; //set interval time between spawns
	
	// Update is called once per frame
	void Update () {


        startTimer -= Time.deltaTime;
        if (startTimer <= 0)    //spawn object
        {
            //spawns object at the objectpoint positions x axis and random range offset of the objectpoints y axis
            Instantiate(misc_object, new Vector3(objectPoint.position.x, objectPoint.position.y + (yPos)), objectPoint.rotation);
            //Instantiate(misc_object2, new Vector3(objectPoint.position.x, objectPoint.position.y - (5)), objectPoint.rotation);
            startTimer = newTimer;

        }
    }
}
