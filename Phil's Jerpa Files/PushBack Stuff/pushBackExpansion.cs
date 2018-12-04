using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Expands the push back circle.
 */

public class pushBackExpansion : MonoBehaviour {

    [SerializeField]
    private float expansionTime;
    private float expansionSpeed = 0;

    //Update is called once per frame
	void Update () {
	    if (expansionSpeed < expansionTime/10.0f)
        {
            expansionSpeed += Time.deltaTime;
            transform.localScale += new Vector3(expansionSpeed, expansionSpeed, expansionSpeed);
        }
        else
        {
            Destroy(gameObject, 1.0f);
        }
    }
}
