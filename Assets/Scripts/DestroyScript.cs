using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {

	invokescript _inst1;
	// Use this for initialization
	void Start () {
		_inst1=GameObject.FindGameObjectWithTag("_inst1").GetComponent<invokescript>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		_inst1.SendMessage("Score");
		Destroy (gameObject);
	}
}
