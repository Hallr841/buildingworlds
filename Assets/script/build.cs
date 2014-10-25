using UnityEngine;
using System.Collections;

public class build : MonoBehaviour {


	public Transform tower;


	// Use this for initialization
	void Start () {


		StartCoroutine( construction() );

//		for (int i = 1; i < 9 ; i++){
//			//  code to state position on of  the cubes
//
//		
//			Vector3 position = new Vector3( Random.Range (-250,200),-40,Random.Range(1,6));
//			tower.transform.localScale = new Vector3 (Random.Range(10,100),Random.Range(0,100),Random.Range(10,100));
//			// call the game object = action folder.load folder place positiion ,rotation and  as is to cast
//			Instantiate(tower,position,Quaternion.identity);
//			}

		}

	IEnumerator construction (){


		for (int i = 0 ; i < 100 ;i++){

			if(Random.Range (0f,10f)< 5f){
				Vector3 position = new Vector3( Random.Range (0, 20),-40,Random.Range(0,20));
				tower.transform.localScale = new Vector3 (100,100,100);
				Instantiate(tower,position,Quaternion.identity);

			} else {

			Vector3 position = new Vector3( Random.Range (0,50),-40,Random.Range(0,50));
			tower.transform.localScale = new Vector3 (Random.Range(10,100),Random.Range(0,100),Random.Range(0,300));
			// call the game object = action folder.load folder place positiion ,rotation and  as is to cast
			Instantiate(tower,position,Quaternion.identity);
			
			}

			yield return new WaitForSeconds (1f);
		}


}


//
//	// Update is called once per frame
//	void Update () {
////
////		for (int i = 1; i <= 2; i++){
////			//  code to state position on of  the cubes
////			Vector3 position = new Vector3( Random.Range (-36,100),1,Random.Range(-400,400));
////			//tower.transform.localScale = new Vector3 (Random.Range(10,100),Random.Range(10,100),Random.Range(10,100));
////			// call the game object = action folder.load folder place positiion ,rotation and  as is to cast
////			Instantiate(tower,position,Quaternion.identity);
//
//		
////		}
//
//	
//	}
}	