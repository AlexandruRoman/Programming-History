using UnityEngine;
using System.Collections;

public class LOGIN : MonoBehaviour {

	public SpriteRenderer asta;
		
	private Text script;
	private Loading_Conect loading;

	public GameObject warning_FaraCont;
	public GameObject warning_Necompletate;
	public GameObject gexit;

	public SpriteRenderer reg;
	private Fade_Click2 igu;


	
	void Start()
	{
		script = GetComponent<Text>();
		loading = GetComponent<Loading_Conect>();
	}


	void OnMouseEnter()
	{
		StartCoroutine(enter());
	}

	IEnumerator enter()
	{
		for (float f = 0.8f; f <= 1f; f += 0.02f) 
		{
			Color c = asta.color;
			c.a = f;
			asta.color = c;
			yield return new WaitForSeconds(0.01f);
		}
	}

	void OnMouseExit()
	{
		StartCoroutine(exit());
	}
	
	IEnumerator exit()
	{
		for (float f = 1f; f >= 0.8f; f -= 0.02f) 
		{
			Color c = asta.color;
			c.a = f;
			asta.color = c;
			yield return new WaitForSeconds(0.01f);
		}
	}


	void OnMouseDown()
	{
		WWWForm form = new WWWForm();
		form.AddField("cont", script.login_cont);
		form.AddField("parola", script.login_parola);
		WWW w = new WWW("http://proiectlica.atwebpages.com/login.php", form);

		StartCoroutine(check(w));
	}

	IEnumerator check(WWW w)
	{
		yield return w;
		if(script.login_cont != "" && script.login_parola != "")
		{
			if(w.text == "0")
			{
				yield return new WaitForSeconds(1);
				//gexit.SetActive(false);
				warning_FaraCont.SetActive(true);

				Color c = loading.load.color;
				c.a = 0;
				loading.load.color = c;
				loading.text.color = c;

			}

			if(w.text == "1")
			{
				loading.Load();
			}

		}

		else 
		{
			yield return new WaitForSeconds(1);
			//gexit.SetActive(false);
			warning_Necompletate.SetActive(true);
			
			Color c = loading.load.color;
			c.a = 0;
			loading.load.color = c;
			loading.text.color = c;
		}

	}










}
