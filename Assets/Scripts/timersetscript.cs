using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timersetscript : MonoBehaviour {
	public Text Timertext;
	public int time = 20;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("timerset", 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void timerset()
	{
		if (time >= 0) {
			Timertext.text = "Time : " + time.ToString ();
			time--;
		}
		else {
			Application.LoadLevel ("menu_sceen");
		}
	}

}
