using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private Transform target;
	[SerializeField]
	private float dist;
	private Vector3 angle = Vector3.up;
	private Transform thisTransform = null;
	[SerializeField]
	private float movSpeed = 10.0f;
	[SerializeField]
	private float rotSpeed;
	private float horz;
	private float vert;
	void Start () {
		thisTransform = GetComponent<Transform> ();
		rotSpeed = 20.0f;
	}
	void Update () {
		transform.LookAt (target.position);
		horz = Input.GetAxis ("Horizontal");
		vert = Input.GetAxis ("Vertical");
		thisTransform.position += transform.forward * vert * Time.deltaTime * movSpeed;
		transform.RotateAround (target.position, angle, horz * rotSpeed * Time.deltaTime );
	}
}
