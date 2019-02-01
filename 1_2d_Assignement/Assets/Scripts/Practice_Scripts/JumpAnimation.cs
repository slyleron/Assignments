using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpAnimation : MonoBehaviour {
    public Sprite reachingup2;//costume
    public Sprite reachingup3;//costume
    public Sprite running;//costume
    public float waittime=.25f;//how long to wait between switching costumes
    private string updown = "up";//which way to switch, up or down
    public GameObject healthbarstuff;//the text object
    public SpriteRenderer healthbarSize;//how much to tile the goo on the UI
    public GameObject ballofgoo;//import the Flying goo!!
    private int movable;//if he can move or not
    //This is how I'd do the camera
    public GameObject theCamera;//import the camera
    private float offset = 8;//how much to ofset the camera

    // Use this for initialization
    void Start () {
        waittime = .25f;
        updown = "up";
        this.GetComponent<SpriteRenderer>().sprite = running;
        movable = 1;
    }
	
	// Update is called once per frame
	void Update () {
        //Function Calling
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
        //Movement and camera movement
        if (Input.GetKey(KeyCode.D) && movable == 1)//This right here is so he can't move while jumping or throwing. 
        {
            //This is how I'd do the camera
            theCamera.transform.position =  Vector3.Lerp(theCamera.transform.position,transform.position + new Vector3(offset, theCamera.transform.position.y-transform.position.y, theCamera.transform.position.z - transform.position.z),.025f);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;//Had to do camera transform because it didn't want to play nicely with the other camera movement

            transform.position = new Vector3(.1f+transform.position.x, transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.A) && movable == 1)
        {
            //This is how I'd do the camera
            theCamera.transform.position = Vector3.Lerp(theCamera.transform.position,transform.position + new Vector3(-offset, theCamera.transform.position.y - transform.position.y, theCamera.transform.position.z - transform.position.z),.025f);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

            transform.position = new Vector3(-.1f + transform.position.x, transform.position.y, 0);
        }
        healthbarstuff.GetComponent<Text>().text = "Hello world";//practicing with the UI, trying to make it work...maybe later :)
        
        if (Input.GetKeyDown(KeyCode.KeypadEnter))//something to change the healthbar so I can see it duplicate/tile
        {
            healthbarSize.size = new Vector2(2.3f + healthbarSize.size.x, healthbarSize.size.y);
            print(healthbarSize.size.x);
        }

    }
    IEnumerator SpriteChangerJump(float waittime)//cosume changer for the up
    {
        movable = 0;
        this.GetComponent<SpriteRenderer>().sprite = reachingup2;
        yield return new WaitForSeconds(waittime);
        print("Success");
        this.GetComponent<SpriteRenderer>().sprite = reachingup3;
        updown = "down";
        movable = 1;
    }
    IEnumerator SpriteChangerFall(float waittime)//and the fall
    {
        movable = 0;
        this.GetComponent<SpriteRenderer>().sprite = reachingup2;
        yield return new WaitForSeconds(waittime);
        print("Success");
        this.GetComponent<SpriteRenderer>().sprite = running;
        updown = "up";
        movable = 1;
    }

}
