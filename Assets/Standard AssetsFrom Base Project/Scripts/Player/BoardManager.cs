using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
       Vector3 PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        Debug.Log(PlayerPosition.x);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    void PlayerPositioning()
    {
        Vector3 PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        
    }
}
