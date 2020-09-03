using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    [SerializeField] float jumpPower = 10f;
    [SerializeField] float turningSpeed = 240f;

    float gravity = 9.81f;
    
    private Vector3 moveDirectionVector = new Vector3();

    private int coinCount;
    public Text coin;

    //component handles
    [SerializeField] CharacterController _characterController;
    private Animator _animator;

    [SerializeField] UImanager _uimanager;

    // Start is called before the first frame update
    void Start()
    {
        _animator = this.gameObject.GetComponent<Animator>();
        coinCount = 0;
        SetCoinCountText();
    }

    // Update is called once per frame
    void Update()
    {
        movement();

    }

    //trick function
    public void skateboardtrick()
    {
        int r = Random.Range(0, 2);
        if (r == 0)
        {
            _animator.SetTrigger("alphaflip");
        }
        else if(r == 1)
        {
            _animator.SetTrigger("kickflip");
        }
        _uimanager.UpdateScore(100);
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

   // Updated upstream
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            coinCount = coinCount + 1;
            SetCoinCountText();
        }
    }

    void SetCoinCountText()
    {
        coin.text = "Coins: " + coinCount.ToString();
    }

  // Stashed changes
}
