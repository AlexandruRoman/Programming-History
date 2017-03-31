using UnityEngine;
using System.Collections;

public class Tranzitie_Fundaluri : MonoBehaviour {

	private int nrImg = 0;
	private int timp;
	
	public GameObject[] img;
	public GameObject[] toateImg;
	
	public bool ok = true;

	void Start()
	{


		int i,x;
		nrImg = 0;
		string text = "Imagini_Spate",path;
		string text2 = "/Fundal_", path2;
		for(i=1;i<=48;i++)
		{
			path = text + i;
			x = PlayerPrefs.GetInt(path);
			print (x);
			if(x==1)
			{
				nrImg++;
				path2 = text2 + i;
				img[nrImg - 1] = GameObject.Find(path2);
			}
		}
		
		
		print (nrImg);
		
		for( i = 0; i < 48; i++)
		{
			int j = i+1;
			path = text2 + j;
			toateImg[i] = GameObject.Find(path);
		}
		if(nrImg !=0)
			StartCoroutine( schimbare () );
		
	}
	
	
	
	IEnumerator schimbare()
	{
		yield return new WaitForSeconds(0.1f);
		timp = PlayerPrefs.GetInt("timp_anim");
		Color c = Color.white;
		
		c.a = 0;
		for (int i=0; i < 48; i++)
		{ 
			toateImg[i].GetComponent<Renderer>().material.color = c;
		}
		
		c.a = 1;
		img[0].GetComponent<Renderer>().material.color = c;
		
		
		
		while(ok && nrImg!=1)
		{
			for (int i = 0; i < nrImg; i++)
			{
				if(ok && nrImg!=1)
				{
					yield return new WaitForSeconds(timp);
					
					
					if(i == nrImg - 1)
					{
						iTween.FadeTo(img[i], 0, 2);
						iTween.FadeTo(img[0], 1, 2);
					}
					
					else 
					{
						iTween.FadeTo(img[i], 0, 2);
						iTween.FadeTo(img[i+1], 1, 2);
					}
				}
			}
		}
		
		
	}


	public void click()
	{
		int i,x;
		nrImg = 0;
		string text = "Imagini_Spate",path;
		string text2 = "/Fundal_", path2;
		for(i=1;i<=48;i++)
		{
			path = text + i;
			x = PlayerPrefs.GetInt(path);
			print (x);
			if(x==1)
			{
				nrImg++;
				path2 = text2 + i;
				img[nrImg - 1] = GameObject.Find(path2);
			}
		}
		
		
		
		
		if(nrImg !=0)
		{
			StopCoroutine( "schimbare" );
			StartCoroutine( schimbare () );
		}
	}



}
