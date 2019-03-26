using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;


public class animal : MonoBehaviour {

	SpriteRenderer renderer;
	public Sprite[] image;
	public string[] keyrist = new string[] {
		"q","w","e","r","t","y","u","i","o","p","@","[","a","s","d","f","g","h","j","k","l",";",":","]","z","x","c","v","b","n","m",",",".","/","_"
	};
	//"q",'w','e','r','t','y','u','i','o','p','@','[','a','s','d','f','g','h','j','k','l',';',':',']','z','x','c','v','b','n','m',',','.','/','_'
	public AudioClip audioClip1;
	public AudioClip audioClip2;
	public AudioClip audioClip3;
	public AudioClip audioClip4;
	public AudioClip audioClip5;
	private AudioSource sound01;

	private IEnumerator coroutine;

	public game game;
	public game2 game2;


	public int[] animation;


	// Use this for initialization
	void Start () {
		renderer = GetComponent<SpriteRenderer>();
		sound01 = gameObject.GetComponent<AudioSource>();
		sound01.clip = audioClip1;

		System.Random rng = new System.Random();
		int n = keyrist.Length;
		while (n > 1)
		{
			n--;
			int k = rng.Next(n + 1);
			string tmp = keyrist[k];
			keyrist[k] = keyrist[n];
			keyrist[n] = tmp;
		}

		//key[1] = 'w';



	}

	// Update is called once per frame
	void Update () {

		if (game.owa == false || game2.owa == false) {
		

			if (Input.GetKeyDown (keyrist [0]) || Input.GetKeyDown (keyrist [5]) || Input.GetKeyDown (keyrist [10]) || Input.GetKeyDown (keyrist [15])
			   || Input.GetKeyDown (keyrist [20]) || Input.GetKeyDown (keyrist [25]) || Input.GetKeyDown (keyrist [30])) {
				//if (Random.Range (-10.0f, 10.0f) > -2.0)
				//renderer.flipY = true;
			
				renderer.sprite = image [0];
				animation [0]++;

				sound01.clip = audioClip3;
				sound01.Play ();


			}

			if (Input.GetKeyDown (keyrist [1]) || Input.GetKeyDown (keyrist [6]) || Input.GetKeyDown (keyrist [11]) || Input.GetKeyDown (keyrist [16])
			   || Input.GetKeyDown (keyrist [21]) || Input.GetKeyDown (keyrist [26]) || Input.GetKeyDown (keyrist [31])) {
				renderer.sprite = image [1];
				animation [1]++;
				//if (Random.Range (-10.0f, 10.0f) > -2.0)
				//	renderer.flipY = false;
				sound01.clip = audioClip4;
				sound01.Play ();

			}

			if (Input.GetKeyDown (keyrist [2]) || Input.GetKeyDown (keyrist [7]) || Input.GetKeyDown (keyrist [12]) || Input.GetKeyDown (keyrist [17])
			   || Input.GetKeyDown (keyrist [22]) || Input.GetKeyDown (keyrist [27]) || Input.GetKeyDown (keyrist [32])) {
				renderer.sprite = image [2];
				animation [2]++;
				//sound01.PlayOneShot(sound01.clip);
				sound01.clip = audioClip1;
				sound01.Play ();
				

				//if (Random.Range (-10.0f, 10.0f) > -2.0)
				//	renderer.flipY = true;
			}

			if (Input.GetKeyDown (keyrist [3]) || Input.GetKeyDown (keyrist [8]) || Input.GetKeyDown (keyrist [13]) || Input.GetKeyDown (keyrist [18])
			   || Input.GetKeyDown (keyrist [23]) || Input.GetKeyDown (keyrist [28]) || Input.GetKeyDown (keyrist [33])) {
				renderer.sprite = image [3];
				animation [3]++;
				//if (Random.Range (-10.0f, 10.0f) > -2.0)
				//	renderer.flipY = false;
				sound01.clip = audioClip5;
				sound01.Play ();

			}

			if (Input.GetKeyDown (keyrist [4]) || Input.GetKeyDown (keyrist [9]) || Input.GetKeyDown (keyrist [14]) || Input.GetKeyDown (keyrist [19])
			   || Input.GetKeyDown (keyrist [24]) || Input.GetKeyDown (keyrist [29]) || Input.GetKeyDown (keyrist [34])) {
				renderer.sprite = image [4];
				animation [4]++;
				sound01.clip = audioClip2;
				sound01.Play ();
				//if (Random.Range (-10.0f, 10.0f) > -2.0)
				//	renderer.flipY = false;
			}
		}
		//StartCoroutine ("button");  


		
	}

/*	private IEnumerator button() {
		for (int i = 0; i > 35; i += 1) 
		{
			if (Input.GetKeyDown (keyrist [i])) 
			{
				renderer.sprite = image [i % 5];
				//if (Random.Range (-10.0f, 10.0f) > -2.0)
				//	renderer.flipY = false;
			}

		}
			


		yield break;
	}
*/
}