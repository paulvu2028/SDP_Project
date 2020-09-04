using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateScore(int points)
    {
        score += points;
    }

    //placed on reload button and reloads scene
    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
