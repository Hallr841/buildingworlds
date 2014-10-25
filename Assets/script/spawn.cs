using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	// making the game object public and seting to  null
	public GameObject gameObject = null ;
	// Use this for initialization
	void Start () {
		// loop  how many objects we want 
		for (int i = 1; i <= 20; i++){
			//  code to state position on of  the cubes
			Vector3 h = new Vector3( Random.Range (-24,24),1,Random.Range(-24,24));
	// call the game object = action folder.load folder place positiion ,rotation and  as is to cast
			gameObject = Instantiate(Resources.Load("Prefab/instacube"),h,Quaternion.identity)as GameObject;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
