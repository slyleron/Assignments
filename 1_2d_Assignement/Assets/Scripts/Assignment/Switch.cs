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
    private Vector3 mouseX;
    public float speed = 18f;
    public GameObject floorboard1;
    private int mapsize = 36;
    private int mapsizex = 1;
    private int mapsizey = 1;
    public int charactersMove;
    public Text movesText;
    public KeyCode input;
    public static int player;
    private GameObject foreground;
    private GameObject activeplayer2;
    private int lastCharMove;
    private Text switchMessage;
    private Camera mainCamera;



    // Use this for initialization
    void Start () {
        mainCamera = Camera.main;
        switchMessage = GameObject.FindGameObjectWithTag("Text").GetComponent<Text>();
        foreground = GameObject.FindGameObjectWithTag("Foreground");
        foreground.SetActive(true);
        foreground.SetActive(false);
        mapsizey = 0;
        mapsizex = 1;
        mapsize = 12;
        Mapmaker();
        suspectint = UnityEngine.Random.Range(1, 4);
        weaponint = UnityEngine.Random.Range(1, 4);
        roomint = UnityEngine.Random.Range(1, 10);
        MurderMystery(fact);
        fact = suspect + " with " + weapon + " " + room;
        print(fact);
        charactersMove = UnityEngine.Random.Range(1, 6);
        GameObject[] activeplayer = { player1, player2, player3, player4 };
        activeplayer2 = player1;
        switchMessage.text = "";

    }
	
	// Update is called once per frame
	void Update () {
        suspectgint = suspectdropdown.GetComponent<Dropdown>().value;
        roomgint = roomdropdown.GetComponent<Dropdown>().value;
        weapongint= weapondropdown.GetComponent<Dropdown>().value;
        Guess();
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, new Vector3(activeplayer2.transform.position.x, activeplayer2.transform.position.y,mainCamera.transform.position.z),  .2f);
        if (suspectguess == suspect&& roomguess == room&& weaponguess == weapon)
        {
            answer.GetComponent<Text>().text = "Correct! It was "+fact;
        }
        switch (Input.inputString)
        {
            case "w":
                if (lastCharMove == 1)
                {
                    charactersMove += 2;
                    lastCharMove = 0;
                }
                else lastCharMove = 3;
                if (charactersMove > 0)
                {
                    activeplayer2.transform.position = new Vector2(activeplayer2.transform.position.x, activeplayer2.transform.position.y + 2f);
                    charactersMove -= 1;
                    movesText.text = charactersMove.ToString();
                }
                break;
            case "a":
                if (lastCharMove == 2)
                {
                    charactersMove += 2;
                    lastCharMove = 0;
                }
                else lastCharMove = 4;
                if (charactersMove > 0)
                {
                    activeplayer2.transform.position = new Vector2(activeplayer2.transform.position.x - 2f, activeplayer2.transform.position.y);
                    charactersMove -= 1;
                    movesText.text = charactersMove.ToString();
                }
                break;
            case "s":
                if (lastCharMove == 3)
                {
                    charactersMove += 2;
                    lastCharMove = 0;
                }
                else lastCharMove = 1;
                if (charactersMove > 0)
                {
                    activeplayer2.transform.position = new Vector2(activeplayer2.transform.position.x, activeplayer2.transform.position.y - 2f);
                    charactersMove -= 1;
                    movesText.text = charactersMove.ToString();
                }
                break;
            case "d":
                if (lastCharMove == 4)
                {
                    charactersMove += 2;
                    lastCharMove = 0;
                }
                else lastCharMove = 2;
                if (charactersMove > 0) {
                activeplayer2.transform.position = new Vector2(activeplayer2.transform.position.x + 2f, activeplayer2.transform.position.y);
                charactersMove -= 1;
                movesText.text = charactersMove.ToString();
                }
                    break;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DarkenScreenSwitchPlayer();
            switch (activeplayer2.name)
            {
                case "Player 1":
                    switchMessage.text = "Turn Over. Player 2, ready, fight!";
                    switchMessage.color = Color.yellow;
                    activeplayer2 = player2;
                    StartCoroutine(ShowScreen());
                     break;
                case "Player 2":
                    switchMessage.text = "Turn Over. Player 3, ready, fight!";
                    switchMessage.color = Color.green;
                    activeplayer2 = player3;
                    StartCoroutine(ShowScreen());
                    break;
                case "Player 3":
                    switchMessage.text = "Turn Over. Player 4, ready, fight!";
                    switchMessage.color = Color.blue;
                    activeplayer2 = player4;
                    StartCoroutine(ShowScreen());
                    break;
                case "Player 4":
                    switchMessage.text = "Turn Over. Player 1, ready, fight!";
                    switchMessage.color = Color.red;
                    activeplayer2 = player1;
                    StartCoroutine(ShowScreen());
                    break;
            }
            lastCharMove = 0;
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
                roomguess = "in the Billiard room!";
                break;
            case 2:
                roomguess = "in the Dining room!";
                break;
            case 3:
                roomguess = "in the Ballroom!";
                break;
            case 4:
                roomguess = "in the Kitchen!";
                break;
            case 5:
                roomguess = "in the Lounge!";
                break;
            case 6:
                roomguess = "in the Hall!";
                break;
            case 7:
                roomguess = "in the Conservtory!";
                break;
            case 8:
                roomguess = "in the Library!";
                break;
            case 9:
                roomguess = "in the Study!";
                break;
            case 10:
                roomguess = "in the Staircase!";
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
                roomguess = "in the Billiard room!";
                break;
            case 2:
                roomguess = "in the Dining room!";
                break;
            case 3:
                roomguess = "in the Ballroom!";
                break;
            case 4:
                roomguess = "in the Kitchen!";
                break;
            case 5:
                roomguess = "in the Lounge!";
                break;
            case 6:
                roomguess = "in the Hall!";
                break;
            case 7:
                roomguess = "in the Conservtory!";
                break;
            case 8:
                roomguess = "in the Library!";
                break;
            case 9:
                roomguess = "in the Study!";
                break;
            case 10:
                roomguess = "in the Staircase!";
                break;
        }
    }
    private void OnTriggerEnter2D(Collision2D collision)
    {
        switch (gameObject.name)
        {
            case "Billiard":
                roomgint = 1;
                Guess();
           break;
            case "Dining":
                roomgint = 1;
                Guess();
                break;
            case "Ballroom":
                roomgint = 1;
                Guess();
                break;
            case "Kitchen":
                roomgint = 1;
                Guess();
                break;
            case "Lounge":
                roomgint = 1;
                Guess();
                break;
            case "Hall":
                roomgint = 1;
                Guess();
                break;
            case "Conservtory":
                roomgint = 1;
                Guess();
                break;
            case "Library":
                roomgint = 1;
                Guess();
                break;
            case "Study":
                roomgint = 1;
                Guess();
                break;
            case "Staircase":
                roomgint = 1;
                Guess();
                break;
        }
    }
    public void DarkenScreenSwitchPlayer()
    {

        charactersMove = UnityEngine.Random.Range(1, 6);
        movesText.text = charactersMove.ToString();
        foreground.SetActive(true);
    }
    IEnumerator ShowScreen()
    {
        yield return new WaitForSeconds(2);
        foreground.SetActive(false);
        switchMessage.text = "";
    }
    
    void Mapmaker()
    {
        while (mapsize > mapsizex)
        {
            //GameObject floorboardholder = Instantiate(floorboard1, new Vector2(transform.position.x + 2f*mapsizex-12f, transform.position.y - 10f), Quaternion.Euler(new Vector3(0, 0, 0)));
            
            print (mapsizex);
            while (mapsize > mapsizey+1)
            {
                GameObject floorboardholder1 = Instantiate(floorboard1, new Vector2(transform.position.x + 2f*mapsizex - 12f, transform.position.y + 2f * mapsizey - 10f), Quaternion.Euler(new Vector3(0, 0, 0)));
                mapsizey += 1;
                print(mapsizey);
            }
            mapsizex += 1;
            mapsizey = 0;

        }
       
    }
}
