using UnityEngine;
using System.Collections;

public class Exit_Setari : MonoBehaviour {

	public GameObject img;

	void OnMouseDown()
	{
		iTween.FadeTo(gameObject, 0, 1);
		StartCoroutine(fade ());
	}

	IEnumerator fade()
	{
		img.SetActive(false);
		yield return new WaitForSeconds(1);
		gameObject.SetActive(false);
	}

}
