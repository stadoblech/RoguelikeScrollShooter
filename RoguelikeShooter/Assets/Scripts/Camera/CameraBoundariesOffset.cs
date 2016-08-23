using UnityEngine;
using System.Collections;

public class CameraBoundariesOffset : MonoBehaviour
{

    public Transform leftDownBoundaries;
    public Transform rightTopBoundariesPoint;
    public float boundariesOffsetX;
    public float boundariesOffsetY;

    float cameraWidth;
    float cameraHeight;
    Vector3 cameraPosition;
    Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition = mainCam.transform.position;
        cameraHeight = mainCam.orthographicSize * 2;
        cameraWidth = cameraHeight * mainCam.aspect;

        leftDownBoundaries.position = cameraPosition + new Vector3(-(cameraWidth / 2) + boundariesOffsetX,
            -(cameraHeight/2) + boundariesOffsetY);

        rightTopBoundariesPoint.position = cameraPosition + new Vector3((cameraWidth / 2) - boundariesOffsetX,
            (cameraHeight/2) - boundariesOffsetY);
    }
}