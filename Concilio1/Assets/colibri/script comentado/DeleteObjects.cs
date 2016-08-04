using UnityEngine;
using System.Collections;

public class DeleteObjects : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//		collision = new Collision ();
//	
//	}
	
	// Update is called once per frame
//	void Update () {
//		OnCollisionEnter (collision);

//	}

	public void OnTriggerEnter(Collider collision) 
	{
		Destroy (collision.gameObject);
	}
}
