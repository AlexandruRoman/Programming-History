using UnityEngine;
using System.Collections;

public class Fundaluri : MonoBehaviour {

	public int nrImg;
	public int timp;

	public SpriteRenderer[] img;
	public SpriteRenderer[] toateImg;

	public bool ok = true;
	

	void Start () 
	
	{
		if(nrImg != 1)
		{
			StartCoroutine( schimbare () );
		}

	}

	IEnumerator schimbare()
	{
		Color c = Color.white;

		c.a = 0;
		for (int i=0; i < toateImg.Length; i++)
		{ 
			toateImg[i].material.color = c;
		}

		c.a = 1;
		img[0].material.color = c;



		while(ok)
		{
			for (int i = 0; i < img.Length; i++)
			{
				yield return new WaitForSeconds(timp);


				if(i == img.Length - 1)
				{
					iTween.FadeTo(img[i].gameObject, 0, 2);
					iTween.FadeTo(img[0].gameObject, 1, 2);
				}

				else 
				{
					iTween.FadeTo(img[i].gameObject, 0, 2);
					iTween.FadeTo(img[i+1].gameObject, 1, 2);
				}
			}
		}


	}

}
