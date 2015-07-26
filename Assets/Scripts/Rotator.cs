using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float rotateSpeed;
	public Vector3 vector = new Vector3(3, 3, 1);


	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
