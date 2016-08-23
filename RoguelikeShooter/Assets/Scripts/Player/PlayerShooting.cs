using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerShooting : MonoBehaviour {

    public GameObject shot;
    public KeyCode makeShot = KeyCode.Space;

    public bool fullAuto;
    public float fullAutoCooldow;
    bool shooted;

    List<Transform> guns = new List<Transform>();
    void Start () {
        shooted = false;
        foreach(Transform t in transform)
        {
            guns.Add(t);
        }
	}
	
	void Update () {
	    if(Input.GetKeyDown(makeShot)&&!fullAuto)
        {
            foreach(Transform t in guns)
            {
                Instantiate(shot, t.position, Quaternion.identity);
            }
        }else if(Input.GetKey(makeShot) && fullAuto && !shooted)
        {
            foreach (Transform t in guns)
            {
                Instantiate(shot, t.position, Quaternion.identity);
                StartCoroutine(shotWithDelay(fullAutoCooldow));
            }
        }
    }

    IEnumerator shotWithDelay(float t)
    {
        shooted = true;
        yield return new WaitForSeconds(t);
        shooted = false;
    }
}
