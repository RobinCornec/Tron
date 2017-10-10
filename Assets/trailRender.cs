using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class trailRender : MonoBehaviour {
	List<Vector3> vertex;
	LineRenderer line;
	RaycastHit hit;
	bool check = true;
	TrailRenderer trail;
	// Use this for initialization
	void Start () {
		trail = GetComponent<TrailRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		vertex.Add(trail.GetPosition(trail.positionCount));
		checkCollision();
	}
	void checkCollision(){
		for (int i = 1; i < vertex.Count; i++) {
			if (Physics.Linecast(vertex [i - 1], vertex [i], out hit)) {
				//if (WheelHit.collider.GetType () != typeof(CharacterController) && check) {
					Debug.Log("touche");
				//}
			}
		}
		
	}
}