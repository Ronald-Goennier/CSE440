using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleScroll : MonoBehaviour {

    [SerializeField]
    private float speed;



    // Update is called once per frame
    void Update () {
		if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.left * (speed*1.2f) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * (speed * 0.75f) * Time.deltaTime);
        }
        else
            transform.Translate(Vector2.left * (speed) * Time.deltaTime);
    }
}
