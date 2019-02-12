using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : PickupSetupScript
{
    public GameObject pc;
    public float waitertobounce;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    IEnumerator Bouncing (float waitertobounce)
    {

        yield return new WaitForSeconds(waitertobounce);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag== "Player")
        {
            print("pickedit up");
        }
    }
}
