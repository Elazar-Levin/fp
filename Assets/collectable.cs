using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour {

	public int value;
	public int rotatespeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate(Vector3.up*Time.deltaTime*rotatespeed);
	}
	
	void OnTriggerEnter()
	{
		Destroy(gameObject);
	}
}
