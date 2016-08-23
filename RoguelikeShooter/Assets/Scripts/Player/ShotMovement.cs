using UnityEngine;
using System.Collections;

public class ShotMovement : MonoBehaviour {

    public float speed;


	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0,speed*Time.deltaTime); 
	}
}
