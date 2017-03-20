using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Character : MonoBehaviour {
	public Vector3 targetPosition;
	public GameObject target;

	public string Race;
	public string Skill;
	public string CharacterName;

	public void SelectRace(string race){
		if (!string.IsNullOrEmpty(this.Race)) {
		var previousRace = GameObject.Find(this.Race + "Panel").GetComponent<Image> ();//gameObject.GetComponent(this.Race + "Panel") as Image;

			previousRace.fillCenter = false;
			previousRace.color = Color.white;
		}
		this.Race = race;
		var currentRace = GameObject.Find (race + "Panel").GetComponent<Image> ();//gameObject.GetComponent(race + "Panel") as Image;
		currentRace.fillCenter = true;
		currentRace.color = Color.red;
	}

	public void NameChange(string name){
		this.CharacterName = name;
	}

	void Start(){
		//target = transform.position;
	//	transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);

	}

	public void Update2(){
//		transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);

	}

	public void Update(){

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			targetPosition.z = transform.position.z;
			transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);			
			//var c = GameObject.Find ("charImg").GetComponent<Image> ();
			//var map = GameObject.Find ("level1").GetComponent();
			//var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			//targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//targetPosition.z = transform.position.z;
			//Grid grid = new Grid(60, 60, tilesmap);

//			var width = 60;
//			var height = 60;
//			float[,] tilesmap = new float[width, height];
//
//			//transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
//			Point _from = new Point(1, 1);
//			Point _to = new Point(10, 10);
//			Grid grid = new Grid(width, height, tilesmap);
//
//			List<Point> path = Pathfinding.FindPath(grid, _from, _to);
//			print ('a');
//
//			foreach (var p in path) {
//				print (p);
//				transform.position = Vector3.MoveTowards(transform.position,new Vector3(p.x,p.y,0), Time.deltaTime * 5);
//			}
		}



	}

}
