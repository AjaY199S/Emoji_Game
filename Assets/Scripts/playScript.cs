using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ChangeSceen(string SceenName)
	{
		Application.LoadLevel (SceenName);
	}
}
