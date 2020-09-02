using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    [SerializeField] float jumpPower = 10f;
    [SerializeField] float turningSpeed = 240f;
    float gravity = 9.81f;
    
    private Vector3 moveDirectionVector = new Vector3();

    //component handles
    [SerializeField] CharacterController _characterController;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    //trick function
    public void skateboardtrick()
    {
        _animator.SetTrigger("alphaflip");
    }

    //movement function is updated to check for keyboard inputs
    public void movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (v < 0)
            v = 0;
        transform.Rotate(0, h * turningSpeed * Time.deltaTime, 0);
        if (_characterController.isGrounded)
        {
            bool move = (v > 0) || (h != 0);
            moveDirectionVector = Vector3.forward * (v);
            moveDirectionVector = transform.TransformDirection(moveDirectionVector);
            moveDirectionVector *= speed;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirectionVector.y = jumpPower;
            }
        }

        moveDirectionVector.y -= gravity * Time.deltaTime;
        _characterController.Move(moveDirectionVector * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
