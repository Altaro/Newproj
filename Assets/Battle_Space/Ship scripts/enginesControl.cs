using UnityEngine;
using System.Collections;

public class enginesControl : MonoBehaviour {
	
	private float enginePower=10; //Временная переменная, потом этот параметр будет братся из БД уже когда статы кораблей будут разные.
	private Transform myTransform; // Ну это понятно, трансформ как везде
	protected bool moveStarted=false; //очень кривое и надеюсь временное решение для реализации плавности движения. 
	protected bool turnStartedLeft=false; 
	protected bool turnStartedRight=false; 
	
	// Use this for initialization
	void Start () {
		myTransform=transform;
	}
	
	public void moveFront(bool start){// Метод движения вперед
		moveStarted=start;	
	}
	
	public void turnLeft(bool start){//метод поворота
		turnStartedLeft=start;		
	}
	
	public void turnRight(bool start){//метод поворота
		turnStartedRight=start;		
	}
	
		
	// Update is called once per frame
	void Update () {
	if(moveStarted){	
		myTransform.position+= myTransform.forward*enginePower*Time.deltaTime;
		}
		
		if(turnStartedLeft){
		myTransform.Rotate(Vector3.up*Time.deltaTime*enginePower,Space.World);
		}
		
		if(turnStartedRight){
		myTransform.Rotate(Vector3.down*Time.deltaTime*enginePower,Space.World);
		}
		
	}
}
