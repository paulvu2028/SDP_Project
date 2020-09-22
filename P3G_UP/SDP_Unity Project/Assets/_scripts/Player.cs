using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //movement variables
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpPower = 10f;
    [SerializeField] float turningSpeed = 240f;
    float gravity = 9.81f;
    //combo variables
    public string playerTrickString = "";
    public string correctTrickString;

    public int trickInputCount = 0;



    private Vector3 moveDirectionVector = new Vector3();

    private int coinCount;

    //component handles
    [SerializeField] CharacterController _characterController;
    private Animator _animator;

    [SerializeField] UImanager _uimanager;
    bool TrickStart;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        _uimanager.resetTrickUI();
        _animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        if (TrickStart)
        {
            TrickInput();
        }
        _uimanager.greyScale(TrickStart);
    }

    //this function selects the skateboard trick to be performed at random
    public void skateboardtrickSelect()
    {
        int r = Random.Range(0, 2);
        if (r == 0)
        {
            correctTrickString = "kjilk";
        }
        else if(r == 1)
        {
            correctTrickString = "jljlk";
        }

        _uimanager.UpdateTrickUI(correctTrickString);
    }
    //these functions call animator to trigger animations
    public void alphaflip()
    {
        _animator.SetTrigger("alphaflip");
    }

    public void kickflip()
    {
        _animator.SetTrigger("kickflip");
    }

    //this function checks the final string of trick to be peformed and the player input string
    //also performs the trick
    public void trickCheck()
    {
        if(playerTrickString == correctTrickString)
        {
            _uimanager.UpdateScore(100);

            if (correctTrickString == "kjilk")
            {
                alphaflip();
                FindObjectOfType<AudioManager>().Play("TrickFinished");
            }
            if (correctTrickString == "jljlk")
            {
                kickflip();
                FindObjectOfType<AudioManager>().Play("TrickFinished");
            }
        }
        _uimanager.resetTrickUI();
        Time.timeScale = 1;
    }
    //this function gets inputs when trick is to be peformed
    public void TrickInput()
    {
        Time.timeScale = 0;
        if (Input.GetKeyDown("j"))
        {
            playerTrickString += "j";
            trickInputCount += 1;
            FindObjectOfType<AudioManager>().Play("CorrectInput");
        }
        if (Input.GetKeyDown("i"))
        {
            playerTrickString += "i";
            trickInputCount += 1;
            FindObjectOfType<AudioManager>().Play("CorrectInput");
        }
        if (Input.GetKeyDown("l"))
        {
            playerTrickString += "l";
            trickInputCount += 1;
            FindObjectOfType<AudioManager>().Play("CorrectInput");
        }
        if (Input.GetKeyDown("k"))
        {
            playerTrickString += "k";
            trickInputCount += 1;
            FindObjectOfType<AudioManager>().Play("CorrectInput");
        }

        if (playerTrickString.Length > 0)
        {
            //update ui
            _uimanager.updatePlayerTrickInput(correctTrickString, playerTrickString, trickInputCount);
        }
        if (trickInputCount == 5)
        {
            Debug.Log("player combo" + playerTrickString);
            trickInputCount = 0;
            trickCheck();

            TrickStart = false;
            playerTrickString = "";
        }
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
            _animator.SetBool("jump", false);
            bool move = (v > 0) || (h != 0);
            moveDirectionVector = Vector3.forward * (v);
            moveDirectionVector = transform.TransformDirection(moveDirectionVector);
            moveDirectionVector *= speed;
            if (v > 0 && Input.GetKeyDown(KeyCode.W))
            {
                FindObjectOfType<AudioManager>().Play("Skating");
            }
            else if (v > 0 && Input.GetKeyUp(KeyCode.W))
            {
                FindObjectOfType<AudioManager>().Stop("Skating");
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _animator.SetBool("jump", true);
                moveDirectionVector.y = jumpPower;
            }

        }
        if (v > 0 && Input.GetKeyDown(KeyCode.W))
        {
            FindObjectOfType<AudioManager>().Play("Skating");
        }
        else if (v> 0 && Input.GetKeyUp(KeyCode.W))
        {
            FindObjectOfType<AudioManager>().Stop("Skating");
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
            _uimanager.UpdateCoins(1);

            FindObjectOfType<AudioManager>().Play("CollectCoin");
        }
        if (other.gameObject.CompareTag("Trick"))
        {
            StartCoroutine(ResetTrickOrb(other));
            Time.timeScale = 0;
            _uimanager.enableTrickUI();
            TrickStart = true;
            skateboardtrickSelect();
        }
    }

    //
    private IEnumerator ResetTrickOrb(Collider col)
    {
        col.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        col.gameObject.SetActive(true);
    }
}

