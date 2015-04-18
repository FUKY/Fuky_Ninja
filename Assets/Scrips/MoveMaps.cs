using UnityEngine;
using System.Collections;

public class MoveMaps : MonoBehaviour {

    public static float mapMoveSpeed = 60.0f;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left*Time.deltaTime * mapMoveSpeed);  
	}
}
