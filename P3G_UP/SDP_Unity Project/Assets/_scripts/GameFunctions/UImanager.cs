using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    private int score = 0;

    [SerializeField] Text coin;
    private int coinCount;

    [SerializeField] Sprite downArrow_img, upArrow_img, leftArrow_img, rightArrow_img;
    [SerializeField] Image[] trickImgs;

    // Start is called before the first frame update
    void Start()
    {
        coinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        coin.text = "Coins: " + coinCount;
    }

    //function for updateing points and 
    public void UpdateScore(int points)
    {
        score += points;
    }

    public void UpdateCoins(int total)
    {
        coinCount += total;
    }

    // updates for player input
    public void UpdateTrickUI(string correctTrickString)
    {
        for (int i = 0; i < 5; i++)
        {
            if(correctTrickString[i] == 'j')
            {
                trickImgs[i].sprite = leftArrow_img;
            }
            else if (correctTrickString[i] == 'i')
            {
                trickImgs[i].sprite = upArrow_img;
            }
            else if (correctTrickString[i] == 'l')
            {
                trickImgs[i].sprite = rightArrow_img;
            }
            else if (correctTrickString[i] == 'k')
            {
                trickImgs[i].sprite = downArrow_img;
            }
        }
    }

    public void updatePlayerTrickInput(string correctTrickString, string playerString, int count)
    {
        Time.timeScale = 1;
        //count is starts at 1 but array starts at 0
        if (playerString[count -1] == correctTrickString[count -1])
            {
            //change colour
            FindObjectOfType<AudioManager>().Play("CorrectInput");
            trickImgs[count - 1].color = Color.green;
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("IncorrectInput");
            trickImgs[count - 1].color = Color.red;
        }
        Time.timeScale = 0;
    }

    //resets player trick ui and hides it
    public void resetTrickUI()
    {
        for (int i = 0; i <5; i++)
        {
            trickImgs[i].color = Color.white;
            trickImgs[i].enabled = false;
        }
    }

    //enables trick ui to be seen
    public void enableTrickUI()
    {
        for (int i = 0; i < 5; i++)
        {
            trickImgs[i].enabled = true;
        }
    }

    //placed on reload button and reloads scene
    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
