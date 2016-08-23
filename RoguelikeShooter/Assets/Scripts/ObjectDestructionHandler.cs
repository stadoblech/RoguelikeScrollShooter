using UnityEngine;
using System.Collections;

public class ObjectDestructionHandler : MonoBehaviour {

    SpriteRenderer sr;

	void Start () {
        sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!sr.isVisible)
        {
            Destroy(gameObject);
        }
	}
}
