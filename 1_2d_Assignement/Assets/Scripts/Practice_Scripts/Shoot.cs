using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    private bool contactToStop;
    private float size;
    private GameObject empty;
    Rigidbody2D m_Rigidbody;

    // Use this for initialization
    void Start () {
        m_Rigidbody = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        if (contactToStop == true)
        {

        }
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            m_Rigidbody.constraints = RigidbodyConstraints2D.None;
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            print("step one");
        }
        else if (collision.gameObject.tag != "Player")
        {
            
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            m_Rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            print("Step two");
        }
        else
        {
            m_Rigidbody.constraints = RigidbodyConstraints2D.None;
            print("step three");
        }
        print("exited");
        

    }
}
