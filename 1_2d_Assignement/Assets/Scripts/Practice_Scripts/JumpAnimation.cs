using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour {
    public Sprite reachingup2;
    public Sprite reachingup3;
    public Sprite running;
    public float waittime=.25f;
    public string updown = "up";
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
