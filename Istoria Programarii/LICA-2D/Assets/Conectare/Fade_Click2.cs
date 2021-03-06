﻿using UnityEngine;
using System.Collections;

public class Fade_Click2 : MonoBehaviour {

	public SpriteRenderer i;
	public SpriteRenderer i_buton;
	public SpriteRenderer i_path;
	public SpriteRenderer o;
	public SpriteRenderer o_buton;
	public SpriteRenderer o_path;

	public bool ok = true;

	public bool ok_warning = false;
	void Start()
	{

	}

	void OnMouseDown()
	{
		StartCoroutine(Legatura());
	}
	
	IEnumerator Legatura()
	{
		StartCoroutine(FadeOut(1f,o));
		StartCoroutine(FadeOut(0.8f,o_buton));
		StartCoroutine(FadeOut(1f,o_path));

		o_buton.gameObject.GetComponent<Collider2D>().enabled = false;
		o_path.gameObject.GetComponent<Collider2D>().enabled = false;
		
		i_buton.gameObject.GetComponent<Collider2D>().enabled = true;
		i_path.gameObject.GetComponent<Collider2D>().enabled = true;

		yield return new WaitForSeconds(0.5f);

		ok = true;

		StartCoroutine(FadeIn(1f,i));
		StartCoroutine(FadeIn(0.8f,i_buton));
		StartCoroutine(FadeIn(1f,i_path));
	}
	
	IEnumerator FadeOut(float inc, SpriteRenderer sp) 
	{
		for (float f = inc; f >= 0f; f -= 0.02f) 
		{
			Color c = sp.color;
			c.a = f;
			sp.color = c;
			yield return new WaitForSeconds(0.01f);
		}
	}
	
	IEnumerator FadeIn(float sf, SpriteRenderer sp) 
	{
		for (float f = 0f; f <= sf; f += 0.02f) 
		{
			Color c = sp.color;
			c.a = f;
			sp.color = c;
			yield return new WaitForSeconds(0.01f);
		}
	}

}
