using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transperency : MonoBehaviour {

    private float decreaseAlpha = 1;

    // Update is called once per frame
    void Update () {
        decreaseAlpha -= Random.Range(.75f,2.2f) * Time.deltaTime;
        GetComponent<SpriteRenderer>().color = new Color(1, .29f, .41f, decreaseAlpha);
    }
}
