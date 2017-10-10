using UnityEngine;
using System.Collections;

public class Player2Control : MonoBehaviour {

	public float speed = 1f;
	public float turnSpeed = 2f;
	Vector3 move;
	float turn;
	Transform rotationPivot;
	CharacterController character;
	// Use this for initialization
	void Start () {
		move = Vector3.zero;
		//	turnSpeed = 2;
		rotationPivot = transform.Find ("Cube/Pivot").transform;
		character = GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update () {
		turn = Mathf.Lerp (turn, turnSpeed * Input.GetAxis ("HorizontalP2"), Time.deltaTime * 1f);
		transform.RotateAround (rotationPivot.position, Vector3.up, turn);
		move = Vector3.Lerp(move,Vector3.forward * speed * Input.GetAxis("VerticalP2"),Time.deltaTime *1f);
		move.y -= 5;
		move.z = Mathf.Clamp01 (move.z);
		character.Move (transform.TransformVector (move));
	}
}
