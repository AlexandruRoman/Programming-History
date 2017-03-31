using UnityEngine;
using System.Collections;

public class Imagini_Spate : MonoBehaviour {

	public Sprite select, noselect;

	public bool ok = false;

	void Start()
	{
		if(PlayerPrefs.GetInt(this.name) == 1)
		{
			ok =true;
			GetComponent<SpriteRenderer>().sprite = select;
		}
	}


	void OnMouseDown()
	{
		ok = !ok;

		if(ok == true)
		{
			GetComponent<SpriteRenderer>().sprite = select;
			PlayerPrefs.SetInt(this.name, 1);
		}

		else 
		{
			GetComponent<SpriteRenderer>().sprite = noselect;
			PlayerPrefs.SetInt(this.name, 0);
		}
	}


}
