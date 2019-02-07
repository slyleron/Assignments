using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goo_Controller : MonoBehaviour {
    public GameObject goo;
    public float movespeed=1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            goo.GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, goo.GetComponent<Rigidbody2D>().velocity.y);
        }
	}
}
