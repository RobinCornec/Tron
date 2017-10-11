using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class trailRender : MonoBehaviour {
	List<Vector3> vertex;
	LineRenderer line;
	RaycastHit hit;
	bool check = true;
	TrailRenderer trail;
    GameObject gameManager;
    GameManager scriptGM;

	// Use this for initialization
	void Start () {
		trail = GetComponent<TrailRenderer>();
        scriptGM = GetComponent<GameManager>();
        hit = GetComponent<RaycastHit>();
        
        vertex = new List<Vector3>();
	}
	
	// Update is called once per frame
	void Update () {
        if(trail.positionCount > 0)
        {
            vertex.Add(trail.GetPosition(trail.positionCount - 1));
		    checkCollision();
        }

    }
	void checkCollision(){
		for (int i = 1; i < vertex.Count; i++) {
			if (Physics.Linecast(vertex [i - 1], vertex [i], out hit)) {
				if (hit.collider.GetType () != typeof(CharacterController) && check) {
                    scriptGM.updateScore(hit.collider.gameObject);
				}
			}
		}
		
	}
}