using UnityEngine;
using System.Collections;

public class enginesControl : MonoBehaviour {
	
	private float enginePower=10; //Временная переменная, потом этот параметр будет братся из БД уже когда статы кораблей будут разные.
	private Transform myTransform; // Ну это понятно, трансформ как везде
	protected bool moveStarted=false; //очень кривое и надеюсь временное решение для реализации плавности движения. 
	protected Vector3 startPosition;
	protected int distanceForMoved;
	
	// Use this for initialization
	void Start () {
		myTransform=transform;
		startPosition=myTransform.position;
	}
	
	public void moveFront(int distance){
		distanceForMoved=distance;
		moveStarted=true;
	}
	
		
	// Update is called once per frame
	void Update () {
	if(moveStarted){
		if(Vector3.Distance(startPosition,myTransform.position)<distanceForMoved)	
		myTransform.position+= myTransform.forward*enginePower*Time.deltaTime;
			else{
				startPosition=myTransform.position;
				moveStarted=false;
			}
		}
		
	}
}
