using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cloning : MonoBehaviour {
	
	//Длинна/Ширина карты
	float arena_length = 100;
	float arena_width = 100;
		

	
	//Боковое расстояние между кубами, какая часть карты между ними
	//Т.е. тут, как и в следующем действует обратная пропорциональность - чем больше число, тем меньше расстояние
	//Что собственно логично, чем больше число закинем  знаминатель, тем меньше результат
	//Ваш К.О.
	float distance_column = 8;
	//Расстояние между рядами, какую часть от всей карты занимает 1 ряд
	float distance_raw = 8;
	
	// Use this for initialization
	void Start()
	{	
		createShips(0f,0f,10,"Blue","Prefab1");
		
		//Делаем то же самое, только для красной стороны
		//Ололо наш Советский Союз покоряет
		//Весь мир от Европы
		//К Неве на восток
		
		createShips(7f,0f,10,"Red","Prefab1");
	}
	void createShips (float raw_index,float column_index,int quantity,string team,string shipType) {
		

		//ВНЕЗАПНО список объектов
		LinkedList<GameObject> tShips = new LinkedList<GameObject>();
		//Создаем сколько угодно объектов
		//column_index - используеться чисто для растояния между кубами
		//Поправки, которые могут показаться странными - это поправки на размер корабля
		for(int i = 0;i<quantity;i++)
		{
			tShips.AddLast(Instantiate(Resources.Load("Prefabs/"+shipType),
				new Vector3(arena_width/2 - (arena_width/distance_column * column_index) ,
				10.0f ,
				arena_length/2 - (arena_length/distance_raw) * raw_index - 5f),
				Quaternion.identity) as GameObject);
			
			
			tShips.Last.Value.name = team +"_"+ shipType + "_" + "0" + i.ToString();
			if(team=="Blue"){
				tShips.Last.Value.tag="Blue";
				tShips.Last.Value.renderer.material.color=Color.blue;
			}
			else{
				tShips.Last.Value.tag="Red";
				tShips.Last.Value.renderer.material.color=Color.red;
			}
			
			column_index++;
			
			if (i%2 == 0)
			{
				if(team == "Blue") raw_index++;
				else raw_index--;
			}
			else
			{
				if(team == "Blue") raw_index--;
				else raw_index++;
			}
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
}
