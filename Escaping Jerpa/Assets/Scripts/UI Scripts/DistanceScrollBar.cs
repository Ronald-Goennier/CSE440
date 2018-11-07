using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScrollBar : MonoBehaviour
{
    public Slider slider;
    private float slideTime;

	// Use this for initialization
	void Start ()
    {
        slider = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        slideTime += Time.deltaTime;
        slider.value = slideTime;
	}
}
