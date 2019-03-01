using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueP1 : MonoBehaviour {
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    private int activeplayerInt;
    private GameObject activeplayer;
    private Vector3 mouseX;
    public float speed = 10f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player1.transform.position = mouseX ;
        if (Input.GetMouseButton(0))
        {
            Walktomouse();
        }
	}


    void DarkenScreenSwitchPlayer()
    {
        switch (activeplayerInt)
        {
            case 1:
                activeplayer = player1;
                break;
            case 2:
                activeplayer = player2;
                break;
            case 3:
                activeplayer = player3;
                break;
            case 4:
                activeplayer = player4;
                break;

        }
    }
    void Walktomouse()
    {
        
            if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x > mouseX.x)
            mouseX.x = mouseX.x + speed * Time.deltaTime;
            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < mouseX.x)
            mouseX.x = mouseX.x - speed * Time.deltaTime;
            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y > mouseX.y)
            mouseX.y = mouseX.y + speed * Time.deltaTime;
            else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < mouseX.y)
            mouseX.y = mouseX.y - speed * Time.deltaTime;
            transform.position = mouseX;
        

    }
}
