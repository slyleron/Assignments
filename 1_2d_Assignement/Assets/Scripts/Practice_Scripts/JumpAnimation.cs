using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpAnimation : MonoBehaviour {
    public Sprite reachingup2;
    public Sprite reachingup3;
    public Sprite running;
    public float waittime=.25f;
    public string updown = "up";
    public GameObject healthbarstuff;
    public SpriteRenderer healthbarSize;
     
    // Use this for initialization
    void Start () {
        waittime = .25f;
        updown = "up";
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown  (KeyCode.Space))
        {
            if (updown == "up")
            {
                StartCoroutine(SpriteChangerJump(waittime));
            }
            else
            {
                StartCoroutine(SpriteChangerFall(waittime));
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(.1f+transform.position.x, transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(-.1f + transform.position.x, transform.position.y, 0);
        }
        healthbarstuff.GetComponent<Text>().text = "Hello world";
        
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            healthbarSize.size = new Vector2(10 + healthbarSize.size.x, healthbarSize.size.y);
            print(healthbarSize.size.x);
        }

    }
    IEnumerator SpriteChangerJump(float waittime)
    {
        
        this.GetComponent<SpriteRenderer>().sprite = reachingup2;
        yield return new WaitForSeconds(waittime);
        print("Success");
        this.GetComponent<SpriteRenderer>().sprite = reachingup3;
        updown = "down";

    }
    IEnumerator SpriteChangerFall(float waittime)
    {

        this.GetComponent<SpriteRenderer>().sprite = reachingup2;
        yield return new WaitForSeconds(waittime);
        print("Success");
        this.GetComponent<SpriteRenderer>().sprite = running;
        updown = "up";

    }

}
