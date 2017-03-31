using UnityEngine;
using System.Collections;

public class Limbaje : MonoBehaviour {


	public SpriteRenderer asta;
	public Sprite click;
	private Sprite noclick;

	public SpriteRenderer slide;
	public Sprite slide_asta;

	public GameObject chestii;
	public GameObject slid;

	void Start()
	{
		noclick = asta.sprite;
	}


	void OnMouseEnter()
	{
		asta.sprite = click;
	}

	void OnMouseExit()
	{
		asta.sprite = noclick;
	}

	void OnMouseDown()
	{
		chestii.SetActive(false);
		slid.SetActive(true);
		slide.sprite = slide_asta;
	}




}
