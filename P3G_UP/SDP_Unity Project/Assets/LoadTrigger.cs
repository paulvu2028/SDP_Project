using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class LoadTrigger : MonoBehaviour
{
    public bool charCustom, lvl1, openWorld;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (charCustom == true)
        {
            SceneManager.LoadScene("CharacterCustom");
        }
        if (lvl1 == true)
        {
            SceneManager.LoadScene("Level1");
        }
        if(openWorld == true)
        {
            SceneManager.LoadScene("OpenWorld");
        }
    }
}
