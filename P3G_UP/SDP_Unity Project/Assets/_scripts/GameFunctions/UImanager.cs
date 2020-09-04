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

    public void UpdateScore(int points)
    {
        score += points;
    }

    public void UpdateCoins(int total)
    {
        coinCount += total;
    }

    //placed on reload button and reloads scene
    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
