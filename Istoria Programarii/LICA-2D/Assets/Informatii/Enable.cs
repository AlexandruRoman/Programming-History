using UnityEngine;
using System.Collections;

public class Enable : MonoBehaviour {

	public SpriteRenderer asta;
	public Sprite click;
	private Sprite noclick;

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
		chestii.SetActive(true);
		slid.SetActive(false);

	}
}
