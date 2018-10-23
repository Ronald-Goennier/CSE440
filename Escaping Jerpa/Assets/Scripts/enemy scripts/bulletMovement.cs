using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {

    [SerializeField]
    private float speed;

    [SerializeField]
    private float destroyBulletTime;

    [SerializeField]
    private GameObject enemyBullet;
   

    public Rigidbody2D rb;

 

	// Use this for initialization
	void Start () {

        //transform.Rotate(new Vector3(0, 0, 90));
        rb.velocity = transform.right * speed;

        Destroy(gameObject, destroyBulletTime);
    }

    void Update()
    {        
        Physics2D.IgnoreLayerCollision(10, 9);        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //destroy bullet if it hits anything that isn't the player
        if (coll.gameObject.tag != "player")
        {            
            Destroy(gameObject);
        }
    }



}
