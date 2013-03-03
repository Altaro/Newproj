using UnityEngine;
using System.Collections;
using UnityEditor;

public class creatorShips : MonoBehaviour {
	
	
 	public GameObject testShip;

	
	// Use this for initialization
	void Start () {		
		testShip =(GameObject)Resources.Load("Assets/Battle_Space/Ship scripts/testShip", typeof(GameObject));
		//Instantiate(testShip.transform);
		
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
