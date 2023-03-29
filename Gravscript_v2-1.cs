using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GravityTag : MonoBehaviour{
	public Rigidbody objrb;
	public Rigidbody rb;
	public float gravityconst = 2;
	public GameObject[] objects;
	void Start(){
		int objectCount = objects.Length;
		rb = GetComponent<Rigidbody>(); 
	}
	void FixedUpdate(){
		objects = GameObject.FindGameObjectsWithTag("Planet");
		foreach (GameObject objects in objects) {
		objrb = objects.GetComponent<Rigidbody>();
			if(!(objrb == rb)) {
				float gravity = (gravityconst * rb.mass * objrb.mass)/ Mathf.Pow(Vector3.Distance(objects.transform.position,transform.position),2);
				rb.velocity = rb.velocity + new Vector3(((-transform.position.x + objects.transform.position.x)*gravity),((-transform.position.y + objects.transform.position.y)*gravity),((-transform.position.z + objects.transform.position.z)*gravity));
				transform.LookAt(objects.transform.position);
			}
		}
	}
}
