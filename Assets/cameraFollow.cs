using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

	public Transform target = null;
	public Transform position = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target) {
			transform.position = Vector3.Lerp (transform.position, position.position, Time.deltaTime * 20f);
			transform.LookAt (target);

		}
	}
}
