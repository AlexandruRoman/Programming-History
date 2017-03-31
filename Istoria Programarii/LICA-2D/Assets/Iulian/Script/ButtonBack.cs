using UnityEngine;
using System.Collections;

public class ButtonBack : MonoBehaviour {
	public GameObject[] slide;
	public GameObject[] box;
	public int x=1;
	public string k;
	public Sprite butoni;
	public Sprite butona;
	public SpriteRenderer buton;
void Start ()
	{ int i;
		Color c = Color.white;
		c.a = 0f;
		 for (i=2; i<=9; i++)
						slide [i].GetComponent<Renderer>().material.color = c;
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
   if (x > 1 ){
	box[x].SetActive(false);
	box[x - 1].SetActive (true);
     iTween.FadeTo (slide[x], 0, 1f); 
	 iTween.FadeTo (slide[x-1], 1, 1f);
		x--;  k=box[x].name;
			Debug.Log (x + k);	 
	
		
		}
	}
}
