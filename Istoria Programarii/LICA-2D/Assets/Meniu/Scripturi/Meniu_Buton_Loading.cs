using UnityEngine;
using System.Collections;

public class Meniu_Buton_Loading : MonoBehaviour {

	public Material mat;


	void Start()
	{
		Color c = Color.white;
		c.a = 0;
		mat.color = c;
	}

	void OnMouseDown()
	{
		StartCoroutine(fade ());

	}

	IEnumerator fade()
	{
			float f;
			for(f = 0f; f <= 1f; f += 0.02f)
			{
				Color c = Color.white;
				c.a = f;
				mat.color = c;
				
				yield return new WaitForSeconds(0.02f);
			}
	}
}
