using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop_Mario : MonoBehaviour {
    private int loopMaxNumber = 100;
    public GameObject gamePlayer;
    private float playerXspeed=.5f;
    private float playerJumpSpeed=3;
    public bool whileLoopExampleBool = true;

    // Use this for initialization
    void Start () {
        //forloops :)
        for (int forLoopCounter = 0; forLoopCounter < loopMaxNumber; forLoopCounter++)
        {
            print(forLoopCounter);
        }
        //while loops
        /*while (whileLoopExampleBool)
        {
            print("true");
        }*/
        
	}
	
	// Update is called once per frame
	void Update () {

        switch (Input.inputString)
        {
            case "w"://jump
                gamePlayer.GetComponent<Rigidbody2D>().velocity = new Vector2(gamePlayer.GetComponent<Rigidbody2D>().velocity.x, gamePlayer.GetComponent<Rigidbody2D>().velocity.y + playerJumpSpeed);
                break;
            case "d"://right
                gamePlayer.transform.position = new Vector2(gamePlayer.transform.position.x+playerXspeed, gamePlayer.transform.position.y);
                break;
            case "a"://left
                gamePlayer.transform.position = new Vector2(gamePlayer.transform.position.x - playerXspeed, gamePlayer.transform.position.y);
                break;


        }

        }
}
