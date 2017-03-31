using UnityEngine;
using System.Collections;

public class REGISTER : MonoBehaviour {

	public SpriteRenderer asta;
	
	private Text_register script;

	private Loading_Conect loading;
	
	public GameObject warning_Ocupate;
	public GameObject warning_Necompletate;
	public GameObject warning_UnSingurCont;
	public GameObject warning_Felicitari;
	public GameObject gexit;
	
	public SpriteRenderer reg;
	private Fade_Click2 igu;

	private bool solo = true;


	void Start()
	{
		script = GetComponent<Text_register>();
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
		form.AddField("nume", script.register_nume);
		form.AddField("prenume", script.register_prenume);
		form.AddField("cont", script.register_cont);
		form.AddField("parola", script.register_parola);
		WWW w = new WWW("http://proiectlica.atwebpages.com/register.php", form);
		StartCoroutine(insert(w));
	}
	
	IEnumerator insert(WWW w)
	{
		yield return w;

		if(script.register_cont != "" && script.register_nume != "" && script.register_parola != "" && script.register_prenume != "")
		{
			if(solo)
			{
				if(w.text == "0")
				{
					yield return new WaitForSeconds(1);
					//gexit.SetActive(false);
					warning_Ocupate.SetActive(true);
					
					Color c = loading.load.color;
					c.a = 0;
					loading.load.color = c;
					loading.text.color = c;
				}

				if(w.text == "1")
				{
					yield return new WaitForSeconds(1);
					//gexit.SetActive(false);
					warning_Felicitari.SetActive(true);
					
					Color c = loading.load.color;
					c.a = 0;
					loading.load.color = c;
					loading.text.color = c;
					solo = false;
				}

			}

			else
			{
				yield return new WaitForSeconds(1);
				//gexit.SetActive(false);
				warning_UnSingurCont.SetActive(true);
				
				Color c = loading.load.color;
				c.a = 0;
				loading.load.color = c;
				loading.text.color = c;
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
