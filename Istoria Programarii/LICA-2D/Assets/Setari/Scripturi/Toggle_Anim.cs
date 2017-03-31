using UnityEngine;
using System.Collections;

public class Toggle_Anim : MonoBehaviour {

	public SpriteRenderer asta;
	public Sprite click;
	public Sprite noclick;

	void Start()
	{
		if(PlayerPrefs.GetInt("Anim") == 1)
		{
			asta.sprite = click;
		}
		else 
		{
			asta.sprite = noclick;
		}
	}

	void OnMouseDown()
	{
		if(PlayerPrefs.GetInt("Anim") == 0)
		{
			asta.sprite = click;
			PlayerPrefs.SetInt("Anim", 1);
		}
		else 
		{
			asta.sprite = noclick;
			PlayerPrefs.SetInt("Anim", 0);
		}

	}



}
