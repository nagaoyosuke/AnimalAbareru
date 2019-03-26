using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mane : MonoBehaviour {


	public GameObject gori;
	public GameObject uma;
	public GameObject win;
	public GameObject lose;
	public GameObject change;
	public GameObject enter;



	public Text gscore;
	public Text uscore;
	public Text sousa;

	public game game;
	public game2 game2;

	public AudioClip audioClip1;
	public AudioClip audioClip2;
	public AudioClip audioClip3;
	private AudioSource sound01;

	public int goriap;
	public int umaap;
	public int king;
	public bool player;

	int clear;
	int en;





	// Use this for initialization
	void Start () {
		gori = GameObject.Find("gorira-1");
		uma = GameObject.Find ("uma-1");
		win = GameObject.Find ("win");
		lose = GameObject.Find ("lose");
		change = GameObject.Find ("change");

		clear = 0;
		en = 0;

		sound01 = gameObject.GetComponent<AudioSource>();
		sound01.clip = audioClip1;

		gori.SetActive(false);
		uma.SetActive(false);

		enter.transform.position = new Vector3(0,-2.75f,-1);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyUp ("return") && game.owa == false)
		{
			enter.transform.position = new Vector3(-90,-2.75f,-1);
			en = 1;
			sound01.clip = audioClip1;
			sound01.Play ();
			farst ();

		}
		if (game.owa && game2.owa == false && player == false) {
			sound01.Stop ();
			gori.SetActive (false);
			en = 0;
			change.transform.position = new Vector2 (0.0f, 2.5f);
		}
		if (Input.GetKeyUp ("return") && game.owa == true) 
		{
			player = true;
			en = 1;
			enter.transform.position = new Vector3(-90,-2.75f,-1);
			sound01.clip = audioClip2;
			sound01.Play ();
			change.transform.position = new Vector2 (99.0f, 112.5f);
			second ();



		}

		if (game.owa && game2.owa && king == 0) 
		{
			sound01.Stop ();
			sound01.clip = audioClip3;
			sound01.Play ();
			ap ();
			gameclear ();

			clear = 1;

		}

		if(Input.GetKeyUp("return") && clear == 1){
			SceneManager.LoadScene("Start");
		}

		if (en == 0)
			enter.transform.position = new Vector3(0,-2.75f,-1);

	}

	void farst (){
		gori.SetActive(true);

	}

	void second (){
		uma.SetActive (true);
	}

	void ap(){

			goriap *= game.animation_ [0];
			umaap *= game2.animation_ [0];
			goriap *= game.animation_ [1];
			umaap *= game2.animation_ [1];
			goriap *= game.animation_ [2];
			umaap *= game2.animation_ [2];
			goriap *= game.animation_ [3];
			umaap *= game2.animation_ [3];
			goriap *= game.animation_ [4];
			umaap *= game2.animation_ [4];

		if (goriap > umaap)
			king = 1;

		if (goriap < umaap)
			king = 2;

		if (goriap == umaap)
			king = 3;
		
		gori.SetActive (true);




		gscore.text = goriap.ToString ();
	

	

		uscore.text = umaap.ToString ();





	}

	void gameclear(){

		if (king == 1) {
			win.transform.position = new Vector2 (5.0f, 3.5f);
			lose.transform.position = new Vector2 (-5.0f, 3.5f);
			game.win ();

		}

		if (king == 2) {
			win.transform.position = new Vector2 (-5.0f, 3.5f);
			lose.transform.position = new Vector2 (5.0f, 3.5f);
			game2.win ();
		}
	}
}
