using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public GameObject shot;

    public KeyCode makeShot = KeyCode.Space;

	void Start () {
	
	}
	
	void Update () {
	    if(Input.GetKeyDown(makeShot))
        {
            Instantiate(shot,transform.position,Quaternion.identity);
        }
	}
}
