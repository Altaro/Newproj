using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	 private Transform myTransform;
	
	void Awake(){
		myTransform=transform;
	}
	
	
	void Start () {
	
	}
	
	
	void Update () {
	if(Input.GetKey(KeyCode.W)){
		myTransform.position+= Vector3.forward*10*Time.deltaTime;
		}	
	if(Input.GetKey(KeyCode.S)){
		myTransform.position-= Vector3.forward*10*Time.deltaTime;
		}
	if(Input.GetKey(KeyCode.A)){
		myTransform.position-= Vector3.right*10*Time.deltaTime;
		}
	if(Input.GetKey(KeyCode.D)){
		myTransform.position+= Vector3.right*10*Time.deltaTime;
		}
	
	}
}
