using UnityEngine;
using System.Collections;

public class BoneHuman : MonoBehaviour {

	public Transform P;


	// Use this for initialization
	void Start () {

		StartCoroutine (GraveYard());
	
	}


	IEnumerator GraveYard (){


		for(int death = 0 ;  death < 40; death++){

			Vector3  position = new Vector3( Random.Range (-100,200),1,Random.Range(-100,400));
			 
			Instantiate(P, position , Quaternion.identity);


			yield return new WaitForSeconds (1f);



			}






	}
		
}
