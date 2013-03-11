using UnityEngine;
using System.Collections;
using UnityEditor;

public class creatorShips : MonoBehaviour {
	
	
 	public GameObject clone;
	
	private string team;
	private int numberOfSheip=0;
	
	
	// Use this for initialization
	void Start () {		
		createShips("Red",1,"testShip");
		createShips("Blue",1,"testShip");
		

	}
	
	
	public void createShips(string team, int quantity, string tag){//team - цвет команды. quantity - количество кораблей. tag-тег клона по которому создаем корабль
		int x;
		int z;
		if(team=="Red"){
			x=-50;
			z=-45;
		}
		else{
			x=50;
			z=45;
		}
		clone=GameObject.FindGameObjectWithTag(tag);	
		GameObject testShipClone;
		while(quantity!=0){		
			testShipClone = GameObject.Instantiate(clone,transform.position,transform.rotation) as GameObject;//создаем клон
			
			testShipClone.name=team+"_"+clone.name+quantity.ToString();//Меняем имя
			
			testShipClone.transform.position=new Vector3(x,0,z);//меняем позицию
				
			
			if(team=="Red"){//меняем цвет + расположение
				testShipClone.tag="Red";
				testShipClone.renderer.material.color=Color.red;
				x+=10;
			}	
			else{
				testShipClone.tag="Blue";
				testShipClone.transform.rotation=new Quaternion(0,-180,0,0);
				x-=10;
				testShipClone.renderer.material.color=Color.blue;}
			
		
			
			quantity--;
		
		}
		
	}
	
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
