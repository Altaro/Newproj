using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class targeting : MonoBehaviour {
	
	private string myTeam;
	private string enemieTeam;
	static private List<GameObject> enemies;
	static private List<GameObject> allies;
	
	// Use this for initialization
	void Start () {
		allies=new List<GameObject>();
		enemies=new List<GameObject>();
		myTeam=tag;
		
		if(myTeam=="Red")
			enemieTeam="Blue";
		else
			enemieTeam="Red";
			
		addAlliesToList(myTeam);
		addEnemiesToList(enemieTeam);
			
		
		
	}
	
	
	
	
	
	public void addAlliesToList(string Tag){//Заполнение списка Союзников
		GameObject[] go = GameObject.FindGameObjectsWithTag(Tag);
		foreach(GameObject unit in go)
			allies.Add(unit);
	}
	public void addEnemiesToList(string Tag){//Заполнение списка Врагов
		GameObject[] go = GameObject.FindGameObjectsWithTag(Tag);
		foreach(GameObject unit in go)
			enemies.Add(unit);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
