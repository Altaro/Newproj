using UnityEngine;
using System.Collections;

public class aaa : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
/*	
	using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Targetting : MonoBehaviour {
	public List<Transform> targets;
	public Transform selectedTarget;
	private Transform myTransform;
	
	
	// Use this for initialization
	void Start () {
			
			
		targets = new List<Transform>();
		myTransform = transform;
		AddAllEnemies();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab))
			TargetEnemy();

		
	
	}
	
	
	
	public void AddAllEnemies(){
		GameObject[] go = GameObject.FindGameObjectsWithTag("Enemy");
		foreach(GameObject enemy in go)
			AddTarget(enemy.transform);
	}
	
	public void AddTarget(Transform enemy){
		targets.Add(enemy);
	}
	
	private void TargetEnemy(){
		if(selectedTarget==null){
			SortTargetByDistance();
			selectedTarget=targets[0];
		}
		else{
			int index = targets.IndexOf(selectedTarget);
			if(index<targets.Count-1){
				index++;
			}
			else{
				index=0;
			}
			DeSelectTarget();
			selectedTarget=targets[index];
		}
		SelectTarget();
	}
	
	private void SortTargetByDistance(){
		targets.Sort(delegate(Transform t1, Transform t2){
			return Vector3.Distance(t1.position,myTransform.position).CompareTo(Vector3.Distance(t2.position,myTransform.position));
		});
	}
	
	private void SelectTarget(){
		selectedTarget.renderer.material.color = Color.red;
		PAtack pa = (PAtack)GetComponent("PAtack");
		pa.target = selectedTarget.gameObject;
		EH eh = (EH)selectedTarget.gameObject.GetComponent("EH");
		eh.ShowH();
		
	}
	
	private void DeSelectTarget(){
		selectedTarget.renderer.material.color = Color.white;
		EH eh = (EH)selectedTarget.gameObject.GetComponent("EH");
		eh.HideH();
	}
	
	
}
*/
	
	
	
	
	
	
	
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
