using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    public Vector3 offset; //= new Vector3(0, 3.37f, -10);

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
        if (RotateAroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Horizontal") * RotationsSpeed, Vector3.up);

            offset = camTurnAngle  * offset;
        }
        Vector3 newPos = playerTransform.position + offset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer || RotateAroundPlayer)
        {
            transform.LookAt(playerTransform);
        }
    }
}
