using UnityEngine;
using System.Collections;

public class Exit_Setari_Info : MonoBehaviour {
	
	public GameObject img;
	public GameObject info;
	
	void OnMouseDown()
	{
		iTween.FadeTo(gameObject, 0, 1);
		StartCoroutine(fade ());
	}
	
	IEnumerator fade()
	{
		img.SetActive(false);
		yield return new WaitForSeconds(1);
		info.SetActive(true);
		gameObject.SetActive(false);
	}
	
}
