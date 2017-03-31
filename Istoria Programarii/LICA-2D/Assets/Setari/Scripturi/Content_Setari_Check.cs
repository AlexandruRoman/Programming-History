using UnityEngine;
using System.Collections;

public class Content_Setari_Check : MonoBehaviour {


	public SpriteRenderer asta;
	public Sprite nofull, full;


	public bool ok = true;
	

	void OnMouseDown()
	{
		ok = !ok;

		if(ok)
		{
			asta.sprite = full;
		}

		else
			asta.sprite = nofull;
	}



}
