using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour {
    public Sprite Reachingup2;
    public Sprite Reachingup1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown  (KeyCode.Space))
        {
            SpriteChangerJump();

        }
	}
    void SpriteChangerJump()
    {
        if (SpriteRenderer.Sprite == Reachingup2) 
        {
            SpriteRenderer.Sprite = Reachingup1;
        }
        else
        {
            SpriteRenderer.Sprite = Reachingup2; 
        }
    }
}
