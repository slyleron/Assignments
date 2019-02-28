using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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


    // Use this for initialization
    void Start () {
        suspectint = Random.Range(1, 4);
        weaponint = Random.Range(1, 4);
        roomint = Random.Range(1, 4);
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



}
