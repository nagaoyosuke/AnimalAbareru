using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeText : MonoBehaviour {

	public Text timetext;

	private float second ;

	public game game;
	public game2 game2;

	void Start (){
		
	}

	void Update () 
	{

		second = game.time;
		timetext.text = second.ToString ("00");

		if (game.owa == true)
		{
			second = game2.time;
			timetext.text = second.ToString ("00");
		}
	}	
}
