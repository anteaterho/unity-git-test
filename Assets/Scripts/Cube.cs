using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		Debug.Log("Hello World");
	}
	
	// Update is called once per frame
	int i = 0;
	void Update () {

		Debug.Log(i.ToString());
		i++;
	
	}
}
