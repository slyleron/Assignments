using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Switch : MonoBehaviour {
    public string suspect;
    public string weapon;
    public string room;
    private int suspectint;
    private int weaponint;
    private int roomint;
    public string fact;
    public string weaponguess = " ";
    public string suspectguess = " ";
    public string roomguess = " ";
    public Dropdown suspectdropdown;
    public Dropdown weapondropdown;
    public Dropdown roomdropdown;
    private int suspectgint;
    private int weapongint;
    private int roomgint;
    public Text answer;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    private int activeplayerInt;
    private GameObject activeplayer;
    private Vector3 mouseX;
    public float speed = 10f;
    public GameObject floorboard1;
    private int mapsize=10;
    private int mapsizex = 1;
    private int mapsizey = 1;


    // Use this for initialization
    void Start () {
        mapsizey = 1;
        mapsizex = 1;
        mapsize = 10;
        Mapmaker();
        suspectint = UnityEngine.Random.Range(1, 4);
        weaponint = UnityEngine.Random.Range(1, 4);
        roomint = UnityEngine.Random.Range(1, 4);
        MurderMystery(fact);
        fact = suspect + " with " + weapon + " " + room;
        print(fact);
        
        
    }
	
	// Update is called once per frame
	void Update () {
        suspectgint = suspectdropdown.GetComponent<Dropdown>().value;
        roomgint = roomdropdown.GetComponent<Dropdown>().value;
        weapongint= weapondropdown.GetComponent<Dropdown>().value;
        Guess();
        player1.transform.position = mouseX;
        if (Input.GetMouseButton(0))
        {
            Walktomouse();
        }

        if (suspectguess == suspect&& roomguess == room&& weaponguess == weapon)
        {
            answer.GetComponent<Text>().text = "Correct! It was "+fact;
        }
        
        
    }

    void MurderMystery(string fact)
    {
        switch (suspectint)
        {
            case 1:
                suspect = "Mr. Mustard";
                break;
            case 2:
                suspect = "Ms. Burgandy";
                break;
            case 3:
                suspect = "Mrs. White ";
                break;
            case 4:
                suspect = "Mr. Fry-Saze";
                break;
        }
        switch (weaponint)
        {
            case 1:
                weapon = "a pipe";
                break;
            case 2:
                weapon = "the dagger";
                break;
            case 3:
                weapon = "the shotgun";
                break;
            case 4:
                weapon = "a foam noodle";
                break;
        }
        switch (roomint)
        {
            case 1:
                room = "in the billard room!";
                break;
            case 2:
                room = "in the dining room!";
                break;
            case 3:
                room = "in the kitchen!";
                break;
            case 4:
                room = "in the basement!";
                break;
        }
    }
    void Guess ()
    {
        switch (suspectgint)
        {
            case 1:
                suspectguess = "Mr. Mustard";
                break;
            case 2:
                suspectguess = "Ms. Burgandy";
                break;
            case 3:
                suspectguess = "Mrs. White ";
                break;
            case 4:
                suspectguess = "Mr. Fry-Saze";
                break;
        }
        switch (weapongint)
        {
            case 1:
                weaponguess = "a pipe";
                break;
            case 2:
                weaponguess = "the dagger";
                break;
            case 3:
                weaponguess = "the shotgun";
                break;
            case 4:
                weapon = "a foam noodle";
                break;
        }
        switch (roomgint)
        {
            case 1:
                roomguess = "in the billard room!";
                break;
            case 2:
                roomguess = "in the dining room!";
                break;
            case 3:
                roomguess = "in the kitchen!";
                break;
            case 4:
                roomguess = "in the basement!";
                break;
        }
    }
    private void OnTriggerEnter2D(Collision2D collision)
    {
        switch (gameObject.tag)
        {
            case "Billard room":
                roomgint = 1; 
           break;
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

        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x > Math.Round(mouseX.x))
            mouseX.x = mouseX.x + speed * Time.deltaTime;
        else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < mouseX.x)
            mouseX.x = mouseX.x - speed * Time.deltaTime;
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y > mouseX.y)
            mouseX.y = mouseX.y + speed * Time.deltaTime;
        else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < mouseX.y)
            mouseX.y = mouseX.y - speed * Time.deltaTime;
        transform.position = mouseX;


    }
    void Mapmaker()
    {
        while (mapsize > mapsizex)
        {
            GameObject floorboardholder = Instantiate(floorboard1, new Vector2(transform.position.x + 2f*mapsizex, transform.position.y), Quaternion.Euler(new Vector3(0, 0, 0)));
            mapsizex += 1;
            print (mapsizex);
        }
        while (mapsize > mapsizey)
        {
            GameObject floorboardholder = Instantiate(floorboard1, new Vector2(transform.position.x , transform.position.y + 2f*mapsizey), Quaternion.Euler(new Vector3(0, 0, 0)));
            mapsizey += 1;
            print(mapsizey);
        }
    }


}
