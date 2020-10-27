using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    public Vector3 offset; //= new Vector3(0, 3.37f, -10);

    public float minZoom = 25f;
    public float maxZoom = 65f;
    public float zoomSpeed = 10f;

    public float currentZoom = 45f;


    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;
    public bool RotateAroundPlayer = true;

    public float RotationsSpeed = 5.0f;

   

    void Start()
    {
        offset = transform.position - playerTransform.position;
    }


    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(-1, Vector3.up);
            offset = camTurnAngle * offset;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(1, Vector3.up);
            offset = camTurnAngle * offset;
        }


        if (RotateAroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Horizontal") * RotationsSpeed, Vector3.up);
            offset = camTurnAngle * offset;
        }

        Vector3 newPos = playerTransform.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer || RotateAroundPlayer)
        {
            transform.LookAt(playerTransform);
        }

        currentZoom = Camera.main.fieldOfView;
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
        Camera.main.fieldOfView = currentZoom;
        
    }
}
