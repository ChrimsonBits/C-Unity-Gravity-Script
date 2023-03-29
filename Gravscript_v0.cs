using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gravity : MonoBehaviour{
	public GameObject planet;
	public Rigidbody rb;
	public Rigidbody objrb;
	public float gravityconst = 2;
	void Start(){
		rb = GetComponent<Rigidbody>(); 
	}
	void FixedUpdate(){
		float gravity = (gravityconst * rb.mass * objrb.mass)/ Mathf.Pow(Vector3.Distance(planet.transform.position,transform.position),2);
		rb.velocity = rb.velocity + new Vector3(((-transform.position.x + planet.transform.position.x)*gravity),((-transform.position.y + planet.transform.position.y)*gravity),((-transform.position.z + planet.transform.position.z)*gravity));
		transform.LookAt(planet.transform.position);
	}
}
