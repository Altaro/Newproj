using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cloning : MonoBehaviour {

	// Use this for initialization
	void Start () {
		

		//Длинна/Ширина карты
		float arena_length = 100;
		float arena_width = 100;
		
		//Относительные координаты относительно размера относительной карты
		//Выставляем конец карты синих
		float raw_index = 0;
		float column_index = 0;
		
		//Боковое расстояние между кубами, какая часть карты между ними
		//Т.е. тут, как и в следующем действует обратная пропорциональность - чем больше число, тем меньше расстояние
		//Что собственно логично, чем больше число закинем  знаминатель, тем меньше результат
		//Ваш К.О.
		float distance_column = 8;
		//Расстояние между рядами, какую часть от всей карты занимает 1 ряд
		float distance_raw = 8;
		
		//ВНЕЗАПНО список объектов
		LinkedList<GameObject> tShips = new LinkedList<GameObject>();
		
		GameObject go = null;
		
		//Создаем сколько угодно объектов
		//column_index - используеться чисто для растояния между кубами
		//Поправки, которые могут показаться странными - это поправки на размер корабля
		for(int i = 0;i<5;i++)
		{
			tShips.AddLast(Instantiate(Resources.Load("Prefabs/Prefab1"),
				new Vector3(arena_width/2 - (arena_width/distance_column * column_index) ,
				10.0f ,
				arena_length/2 - (arena_length/distance_raw) * raw_index - 5f),
				Quaternion.identity) as GameObject);
			
			tShips.Last.Value.name = "Blue0" + i.ToString();
			
			column_index++;
			
			if (i%2 == 0)
			{
				raw_index++;
			}
			else
			{
				raw_index--;
			}
		}
		
		
		//Делаем то же самое, только для красной стороны
		//Ололо наш Советский Союз покоряет
		//Весь мир от Европы
		//К Неве на восток
		
		raw_index = 7;
		column_index = 4;
		
		for(int i = 0;i<5;i++)
		{
			tShips.AddLast(Instantiate(Resources.Load("Prefabs/Prefab1"),
				new Vector3(arena_width/2 - (arena_width/distance_column * column_index) ,
				10.0f ,
				arena_length/2 - (arena_length/distance_raw) * raw_index - 5f),
				Quaternion.identity) as GameObject);
			
			tShips.Last.Value.name = "Red0" + i.ToString();
			
			column_index++;
			
			if (i%2 == 0)
			{
				raw_index--;
			}
			else
			{
				raw_index++;
			}
		}
		
		/*GameObject go1 = Instantiate(Resources.Load("Prefabs/Prefab1"),new Vector3(arena_width/2 - (arena_width/12 * zonex_index) - 2.5f ,10.0f,arena_length/2 - (arena_length/12) * zoney_index - 5),Quaternion.identity) as GameObject;
		zoney_index++;
		zonex_index++;
		GameObject go2 = Instantiate(Resources.Load("Prefabs/Prefab1"),new Vector3(arena_width/2 - (arena_width/12 * zonex_index) - 2.5f ,10.0f,arena_length/2 - (arena_length/12) * zoney_index - 5),Quaternion.identity) as GameObject;		
		*/
		//GameObject go2 = Instantiate(Resources.Load("Prefabs/Prefab1")) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
		//GameObject go1 = Instantiate(Resources.Load("Prefabs/Prefab1")) as GameObject;
	
	}
}
