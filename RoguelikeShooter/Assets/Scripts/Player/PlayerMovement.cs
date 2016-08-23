using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;

    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode moveRight = KeyCode.RightArrow;
    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;


    Camera mainCamera;
    Vector3 RightUpBoundaries;
    Vector3 LeftDownBoundaries;

    void Start () {
        mainCamera = Camera.main;
        
    }

  	void Update () {


        LeftDownBoundaries = mainCamera.transform.GetChild(0).position;
        RightUpBoundaries = mainCamera.transform.GetChild(1).position;

        if (Input.GetKey(moveLeft))
        {
            transform.position -= new Vector3(movementSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(moveRight))
        {
            transform.position += new Vector3(movementSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(moveDown))
        {
            transform.position -= new Vector3(0, movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(moveUp))
        {
            transform.position += new Vector3(0, movementSpeed * Time.deltaTime);
        }

        if(transform.position.x <= LeftDownBoundaries.x)
        {
            transform.position = new Vector3(LeftDownBoundaries.x, transform.position.y);
        }
        if (transform.position.y <= LeftDownBoundaries.y)
        {
            transform.position = new Vector3(transform.position.x, LeftDownBoundaries.y);
        }


        if (transform.position.x >= RightUpBoundaries.x)
        {
            transform.position = new Vector3(RightUpBoundaries.x, transform.position.y);
        }
        if (transform.position.y >= RightUpBoundaries.y)
        {
            transform.position = new Vector3(transform.position.x, RightUpBoundaries.y);
        }

        
    }
}
