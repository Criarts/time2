using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMaker : MonoBehaviour {
	public void OnCollisionEnter(Collision coll)
	{	
		if (coll.gameObject.tag == "Player") {
			ObjectMaker.instance.BossStart ();
		}
	}
}
