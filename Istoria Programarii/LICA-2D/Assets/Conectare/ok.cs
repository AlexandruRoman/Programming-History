using UnityEngine;
using System.Collections;

public class ok : MonoBehaviour {



	public SpriteRenderer asta;
	public GameObject warning;

	public SpriteRenderer login;
	private Loading_Conect loading;
	
	public SpriteRenderer reg;
	private Fade_Click2 igu;
	
	void Start()
	{
		igu = reg.GetComponent<Fade_Click2>();
		loading = login.GetComponent<Loading_Conect>();

		Color c = asta.color;
		c.a = 0.7f;
		asta.color = c;


		if(PlayerPrefs.GetInt("full") == 1)
			Screen.SetResolution(1280, 1024, true);
		else
			Screen.SetResolution(900, 720, false);

	}


	void OnMouseEnter()
	{
		Color c = asta.color;
		c.a = 1;
		asta.color = c;
	}

	void OnMouseExit()
	{
		Color c = asta.color;
		c.a = 0.7f;
		asta.color = c;
	}

	void OnMouseDown()
	{
		Color c = loading.exit.color;
		c.a = 1f;
		loading.exit.color = c;

		igu.ok_warning = false;

		warning.SetActive(false);
	}


}
