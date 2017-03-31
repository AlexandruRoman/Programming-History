using UnityEngine;
using System.Collections;

public class Controller_TEST : MonoBehaviour {


	public int nrIntrebare;

	public int[] corect;
	public bool[] ok;
	public int scor = 0;
	public float timp = 600;
	public int sec, min;
	public int TOTAL;


	public GameObject camp_timp;
	private TextMesh continut;

	void Start()
	{
		continut = camp_timp.GetComponent<TextMesh>();
	}




	public void calculare_scor()
	{
		for(int i=0;i<TOTAL;i++)
		{
			if(ok[i]==true)
				scor++;
		}
	}

	void Update()
	{
		if(timp < 0)
			Application.LoadLevel("Meniu");

		if(nrIntrebare != TOTAL)
		{
			timp -= Time.deltaTime;

			sec = 600-(int)timp;
			min = (int)sec/60;
		}
		continut.text = "" + (9 - min) + " : " + (59 - sec + min*60);
	}




}
