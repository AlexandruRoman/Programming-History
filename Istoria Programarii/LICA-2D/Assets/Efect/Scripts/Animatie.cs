using UnityEngine;
using System.Collections;

public class Animatie : MonoBehaviour {

	public GameObject[] spot;
	public GameObject final;

	public int timp;
	public int bonus;

	bool ok = true;








	void Start () 
	{

		StartCoroutine(anim ());

		if(PlayerPrefs.GetInt("Anim") == 0)
		{
			iTween.Stop();
			stop();
			transform.position = new Vector3(0,0,-9);
		}
		else 
		{
			iTween.Stop();
			transform.position = new Vector3(0,0,-9);
			reload();
			
		}

	}

	public void stop()
	{
		StopCoroutine("anim");
		ok=false;
	}

	public void reload()
	{
		StopCoroutine("anim");
		ok=true;
		StartCoroutine(anim ());

	}

	IEnumerator anim()
	{
		while(ok)
		{

			for(int i=1; i<=5;i++)
			{
				if(ok)
				{
				iTween.MoveTo(gameObject, iTween.Hash(iT.MoveTo.time, timp, iT.MoveTo.position, spot[i-1].transform.position, iT.MoveTo.easetype, "linear", "name", "animc"));
				yield return new WaitForSeconds(timp + bonus);
				}
			}

			if(ok)
			{
			// final
			iTween.MoveTo(gameObject, iTween.Hash(iT.MoveTo.time, timp, iT.MoveTo.position, final.transform.position, iT.MoveTo.easetype, "linear", "name", "animc"));
			yield return new WaitForSeconds(timp + bonus);
			}
		}
	}



}
