using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunJumpLand : MonoBehaviour {
    private GameObject bodyMain;
    private float jumphight;
    // Use this for initialization
    void Start () {
		bodyMain= GameObject.FindGameObjectWithTag("Player");
        jumphight = 7f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bodyMain.GetComponent<Rigidbody2D>().velocity = new Vector2(bodyMain.GetComponent<Rigidbody2D>().velocity.x, bodyMain.GetComponent<Rigidbody2D>().velocity.y+jumphight);
        }
	}
}
