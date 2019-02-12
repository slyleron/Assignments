using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goo_Controller : MonoBehaviour {
    public GameObject goo;
   // public GameObject particle;
    public float movespeed=5;
    public int health;
    public bool canjump;
    // Use this for initialization
    void Start () {
        health = 25;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            goo.GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, goo.GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            goo.GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed*-1, goo.GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space)&canjump)
        {
            goo.GetComponent<Rigidbody2D>().velocity = new Vector2(goo.GetComponent<Rigidbody2D>().velocity.x, goo.GetComponent<Rigidbody2D>().velocity.y+10);
            //particle.GetComponent<ParticleSystem>().emission.enabled;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ground")
        {
            canjump = true;
            print("ground");
        }
        else
        {
            canjump = false;
        }
    }
}
