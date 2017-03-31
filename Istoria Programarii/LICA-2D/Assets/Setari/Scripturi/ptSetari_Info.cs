using UnityEngine;
using System.Collections;

public class ptSetari_Info : MonoBehaviour {
	
	
	
	private float t = 0.5f;
	private bool ok = true;
	
	public GameObject back;
	public GameObject img; 
	
	public GameObject info;
	
	void OnMouseOver()
	{
		if(t < 0 && ok)
		{
			ok=false;
			Color c = Color.white;
			c.a = 0;
			back.GetComponent<Renderer>().material.color = c;
			back.SetActive(true);
			iTween.FadeTo(back, 1, 1);
			t=0.5f;
			StartCoroutine(fade ());
			
			
			info.SetActive(false);
		}
		
		else
			t -= Time.deltaTime;
	}
	
	void OnMouseExit()
	{
		t=0.5f;
		ok=true;
	}
	
	IEnumerator fade()
	{
		yield return new WaitForSeconds(1);
		img.SetActive(true);
	}
	
}
