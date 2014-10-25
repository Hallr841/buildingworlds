using UnityEngine;
using System.Collections;

public class Bridge : MonoBehaviour {

	public Transform BDE ; 

	// Use this for initialization
	void Start () {


		StartCoroutine ( builded());

	
	
	}
	

	IEnumerator builded () {


		
		for (  int bob =0 ; bob <= 6; bob++ ){
	
		


			//  code to state position on of  the cubes
			Vector3 h = new Vector3( Random.Range (-36,100),-25,Random.Range(-400,400));
			// call the game object = action folder.load folder place positiion ,rotation and  as is to cast
			Instantiate(BDE,h,Quaternion.identity) ;

		

			yield return new WaitForSeconds (1f);
			
		}
		
	





	}
}
