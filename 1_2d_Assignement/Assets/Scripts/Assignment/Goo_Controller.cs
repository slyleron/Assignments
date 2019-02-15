using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goo_Controller : MonoBehaviour {
    public GameObject goo;
   // public GameObject particle;
    public float movespeed=5;
    public int health;
    public bool canjump=true;
    public GameObject bullet, mouse;
    private float power;
    public float poweruprate = 0.01f;
    public Slider slider;
    
    
    // Use this for initialization
    void Start () {
        health = 25;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            goo.GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, goo.GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            goo.GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed * -1, goo.GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space) & canjump == true)
        {
            goo.GetComponent<Rigidbody2D>().velocity = new Vector2(goo.GetComponent<Rigidbody2D>().velocity.x, goo.GetComponent<Rigidbody2D>().velocity.y + 10);
            //particle.GetComponent<ParticleSystem>().emission.enabled;
            canjump = false;
        }
        if (Input.GetMouseButton(0))
        {
            print(power);
            if(power<slider.maxValue)
            power += poweruprate;
        }
        if (Input.GetMouseButtonUp(0))
        {

            print("mouse released " + power);
            GameObject flybulletfly = Instantiate(bullet, new Vector2 (transform.position.x+.5f,transform.position.y+1f), Quaternion.Euler(new Vector3(0,0,0)));
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), flybulletfly.GetComponent<Collider2D>());
            flybulletfly.transform.LookAt(mouse.transform.position);
            //print("y is " + flybulletfly.transform.rotation.y);
            //print("x is " + flybulletfly.transform.rotation.x);
            //flybulletfly.transform.rotation = Quaternion.Euler (new Vector3(0, 0, (flybulletfly.transform.rotation.x/0.180f)*10));
            
            flybulletfly.GetComponent<Rigidbody2D>().velocity = flybulletfly.transform.forward*power*25;
            //flybulletfly.GetComponent<Rigidbody2D>().velocity = flybulletfly.transform.InverseTransformDirection(flybulletfly.transform.right) * 25f * power;
            //flybulletfly.GetComponent<Rigidbody2D>().velocity = new Vector2(power*25f,power*25f)*flybulletfly.transform.rotation.Eu;
            power = 0;
        }
        slider.value = power;

    }
    void OnCollisionEnter2D(Collision2D other)
        {
               canjump = true;
               // print("ground");
           
        }
}
