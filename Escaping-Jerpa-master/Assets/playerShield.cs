using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShield : MonoBehaviour
{
    public Transform shieldLocation;
    public GameObject shieldPrefab;


    [SerializeField]
    private float timer = 5;

	// Use this for initialization
	void Start ()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        Instantiate(shieldPrefab, shieldLocation.position, shieldLocation.rotation);
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, shieldLocation.position, Time.deltaTime);
        if (timer <= 0)
        {
            gameObject.GetComponent<Collider2D>().enabled = true;
            gameObject.GetComponent<playerShield>().enabled = false;
        }
        
	}
}
