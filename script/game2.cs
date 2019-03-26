using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game2 : MonoBehaviour {

	SpriteRenderer renderer;

	public float Max_time = 0.0f;
	public float time = 10.0f;
	public bool owa;

	public animal animal;
	public int[] animation_;

	public Sprite[] image;

	GameObject rd;

	// Use this for initialization
	void Start () {
		renderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

		if (time > 0.0)
		time -= Time.deltaTime;

		if(time<Max_time)
		{
			owa = true;
			animation_[0] = animal.animation [0];
			animation_[1] = animal.animation [1];
			animation_[2] = animal.animation [2];
			animation_[3] = animal.animation [3];
			animation_[4] = animal.animation [4];

		}
	}

	public void win(){
		renderer.sprite = image [1];
	}

}
