using UnityEngine;
using System.Collections;

public class dno : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D coll)
	{
		Destroy(coll.transform.parent.gameObject);

	}
}
