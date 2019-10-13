using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class invokescript : MonoBehaviour {
	public GameObject[] myArry;
	public Text Counttext;
	public Text Scoretext;

	static int count = 0;
	static int score = 0;

	// Use this for initialization
	void Start () {
		Invoke ("createobject",2);
		transform.position = new Vector2(Random.Range(-3,3), Random.Range(-4,-2));
		Setcount ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void createobject()
	{
		Instantiate (myArry [Random.Range (0, 5)], transform.position, transform.rotation);
		Start ();
	}

	void Score()
	{
		score=score+1;
		Scoretext.text = "Score :- "+score.ToString ();
	}

	public void Setcount()
	{
		count++;
		Counttext.text = "Count :- " + count.ToString ();
	}

	void Score2()
	{
		score=score-1;
		Scoretext.text = "Score :- "+score.ToString ();
	}
		
}
