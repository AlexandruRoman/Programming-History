using UnityEngine;
using System.Collections;

public class Meniu_Hover : MonoBehaviour {


	public Sprite hover;
	private Sprite normal;

	public SpriteRenderer asta;

	void Start()
	{
		normal = asta.sprite;
	}

	void OnMouseEnter()
	{
		asta.sprite = hover;
	}

	void OnMouseExit()
	{
		asta.sprite = normal;
	}



}
