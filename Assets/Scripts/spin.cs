using UnityEngine;
using System.Collections;

public class spin : MonoBehaviour {

	// Use this for initialization
	public float degreesPerSecond;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime*degreesPerSecond);
	}
}
