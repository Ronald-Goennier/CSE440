using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldMovement : MonoBehaviour {

    [SerializeField]
    private float secondsToDestroy;

    [SerializeField]
    private float movementSpeed;

    void Awake()
    {
        Physics2D.IgnoreLayerCollision(10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreLayerCollision(10, 10);
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        StartCoroutine(time());
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            coll.gameObject.GetComponent<weaponController>().shieldBool = true;
            Destroy(gameObject);
        }
    }

    IEnumerator time()
    {
        yield return new WaitForSeconds(secondsToDestroy);
        Destroy(gameObject);
    }
}
