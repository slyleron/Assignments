using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variable_Assignment : MonoBehaviour {
	//variable area
	public int number;//public capital, private lowercase
	public float somedecimal;//floats decimals--they need to have "f" on the end of the value
	public string mynameis;
	// hey if you do CTRL ? it will comment out the line of code
	/*
	this is a multiline comment
	It can go on a really really long time
	cool. 
	 */

	// Use this for initialization
	void Start () {
		number = 10;
		somedecimal = 0.94f;
		mynameis = "hello my name is flo and i work in a button factory";

	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position=new Vector3(somedecimal,0,0);



	}
}
