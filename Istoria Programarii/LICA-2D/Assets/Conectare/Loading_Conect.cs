using UnityEngine;
using System.Collections;

public class Loading_Conect : MonoBehaviour {

	public Material load;
	public TextMesh text;
	public Material exit;

	public string level;

	public SpriteRenderer reg;
	private Fade_Click2 igu;
	

	void Start()
	{
		igu = reg.GetComponent<Fade_Click2>();

		Color c = load.color;
		c.a = 0;
		load.color = c;
		text.color = c;

		c.a = 1;
		exit.color = c;
	}
	
	void OnMouseDown()
	{	
		StartCoroutine(fade_load());
		StartCoroutine(fade_text());
		StartCoroutine(fade_exit());

		igu.ok_warning = true;
	}

	public void Load()
	{
		StartCoroutine(load_level());
	}

	IEnumerator load_level()
	{
		yield return new WaitForSeconds(3);



		Application.LoadLevel(level);
	}

	
	IEnumerator fade_load()
	{
		for (float f = 0f; f <= 1f; f += 0.02f) 
		{
			Color c = load.color;
			c.a = f;
			load.color = c;
			yield return new WaitForSeconds(0.01f);
		}
	}
	
	IEnumerator fade_text()
	{
		for (float f = 0f; f <= 1f; f += 0.02f) 
		{
			Color c = text.color;
			c.a = f;
			text.color = c;
			yield return new WaitForSeconds(0.01f);
		}
	}
	
	IEnumerator fade_exit()
	{
		for (float f = 1f; f >= 0f; f -= 0.02f) 
		{
			Color c = exit.color;
			c.a = f;
			exit.color = c;
			yield return new WaitForSeconds(0.01f);
		}
	}



}
