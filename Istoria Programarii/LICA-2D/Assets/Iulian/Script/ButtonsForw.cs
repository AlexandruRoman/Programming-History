using UnityEngine;
using System.Collections;

public class ButtonsForw : MonoBehaviour {
	public GameObject[] slide;
	public GameObject inapoi;
	private ButtonBack script;
	public GameObject[] box;
	public string k;
	public Sprite butoni;
	public Sprite butona;
	public SpriteRenderer buton;

	void Start ()
	{ int i;
		Color c = Color.white;
		c.a = 0f;
		for (i=2; i<=9; i++) {
						slide [i].GetComponent<Renderer>().material.color = c;
				}
	}

	void OnMouseEnter()
	{

	 
		buton.sprite = butoni;
	
	
	}

	void OnMouseExit()
	{

		buton.sprite = butona;


	}


	void OnMouseDown(){


		script = inapoi.GetComponent<ButtonBack> ();

		if (script.x < 9) {
			       
		 box[script.x].SetActive(false);
		 box[script.x + 1].SetActive (true);
		 iTween.FadeTo (slide [script.x], 0, 1f);
		 iTween.FadeTo (slide [script.x+1], 1, 1f);
			script.x++;
		 k=box[script.x].name;
		 Debug.Log (script.x + k);	
		}
	}}

