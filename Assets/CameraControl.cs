using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	private Transform myTransform;
	public float cameraSpeed=40;
	
	void Awake(){
		myTransform=transform;
	}
	
	
	void Start () {
	
	}
	
	
	void Update () {
	if(Input.GetKey(KeyCode.W)){
		myTransform.position+= Vector3.forward*cameraSpeed*Time.deltaTime;
		}	
	if(Input.GetKey(KeyCode.S)){
		myTransform.position-= Vector3.forward*cameraSpeed*Time.deltaTime;
		}
	if(Input.GetKey(KeyCode.A)){
		myTransform.position-= Vector3.right*cameraSpeed*Time.deltaTime;
		}
	if(Input.GetKey(KeyCode.D)){
		myTransform.position+= Vector3.right*cameraSpeed*Time.deltaTime;
		}
	
	}
}
