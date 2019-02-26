using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    private bool contactToStop;
    public float size;
    private GameObject empty;
    Rigidbody2D m_Rigidbody;
    private bool canpickup;
    public GameObject goo;

    // Use this for initialization
    void Start () {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        size = .25f;
    }
	
	// Update is called once per frame
	void Update () {
        if (goo.GetComponent<SpriteRenderer>().transform.localScale.x > .25)
        {
            size = 0.01f;
        }
        


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
                m_Rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
                print("Step two");
                canpickup = true;
            }
       
        print("exited");
        

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"&canpickup==true)
        {
            Destroy(gameObject);
            goo.GetComponent<SpriteRenderer>().transform.localScale = new Vector2(goo.GetComponent<SpriteRenderer>().transform.localScale.x+size, goo.GetComponent<SpriteRenderer>().transform.localScale.y+size);
        }
        if (other.tag == "Player" & canpickup == false)
        {
            
            goo.GetComponent<SpriteRenderer>().transform.localScale = new Vector2(goo.GetComponent<SpriteRenderer>().transform.localScale.x - size, goo.GetComponent<SpriteRenderer>().transform.localScale.y - size);
        }
    }
    
}
