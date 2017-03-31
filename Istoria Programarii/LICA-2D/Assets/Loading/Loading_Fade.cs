using UnityEngine;
using System.Collections;

public class Loading_Fade : MonoBehaviour {


	public Material load;
	public TextMesh text;
	public Material exit;
	
	public string level;
	
	void OnMouseDown()
	{	
		StartCoroutine(fade_load());
		StartCoroutine(fade_text());
		StartCoroutine(fade_exit());
		
		StartCoroutine(load_level());
		
	}
	
	IEnumerator load_level()
	{
		yield return new WaitForSeconds(5);
		Application.LoadLevelAsync(level);
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
		for (float f = 0f; f <= 0f; f += 0.02f) 
		{
			Color c = text.color;
			c.a = f;
			load.color = c;
			yield return new WaitForSeconds(0.01f);
		}
	}
	
	IEnumerator fade_exit()
	{
		for (float f = 1f; f >= 0f; f -= 0.02f) 
		{
			Color c = exit.color;
			c.a = f;
			load.color = c;
			yield return new WaitForSeconds(0.01f);
		}
	}






}
