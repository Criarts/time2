//최종 수정자:김영민
//수정날짜: 2017/09/24
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMaker : MonoBehaviour {

	public void OnCollisionExit(Collision coll)
	{	
		 ObjectMaker.instance.SpawnGround (transform);	
	}
}
