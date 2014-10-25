using UnityEngine;
using System.Collections;

public class dog : MonoBehaviour {

	public Transform  pup ;
	public Quaternion rotation = Quaternion.Euler(new Vector3(0,Random.Range(0,360),0));

	// Use this for initialization
	void Start () {

		for( int i = 0; i < 10; i++){
			
			Vector3 position = new Vector3( Random.Range (-100,200),1,Random.Range(-100,400));
			
			Instantiate(pup,position,rotation);
			
		}



	
	}
	
	// Update is called once per frame
	void Update () {


	}
}
