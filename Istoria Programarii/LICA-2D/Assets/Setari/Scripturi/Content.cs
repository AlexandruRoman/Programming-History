using UnityEngine;
using System.Collections;

public class Content : MonoBehaviour {


	public SpriteRenderer asta;
	public GameObject content;

	public Sprite click, noclick;

	public SpriteRenderer b1,b2,b3;

	public Sprite s1,s2,s3;

	public GameObject c1,c2,c3;

	public int nr;

	bool ok = false;

	void OnMouseEnter()
	{
		asta.sprite = click;
	}

	void OnMouseExit()
	{
		if(ok == false)
		{
			asta.sprite = noclick;
		}
	}

	void OnMouseDown()
	{
		content.SetActive(true);

		if(nr>=1)
			c1.SetActive(false);
		if(nr>=2)
			c2.SetActive(false);
		if(nr>=3)
			c3.SetActive(false);


		ok = true;

		asta.sprite = click;

		if(nr>=1)
			b1.sprite = s1;
		if(nr>=2)
			b2.sprite = s2;
		if(nr>=3)
			b3.sprite = s3;


	}





}
