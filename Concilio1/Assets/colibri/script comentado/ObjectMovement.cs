using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour {
	public Rigidbody fallingSphere;
	// Use this for initialization
	void Start () {
		fallingSphere = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		fallingSphere.velocity = new Vector3 (0, -7, 0);
	}

}
