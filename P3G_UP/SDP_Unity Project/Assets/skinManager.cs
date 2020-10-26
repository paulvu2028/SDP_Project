using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinManager : MonoBehaviour
{
    public GameObject playbutton;

    public ModelChanger mc;
    public UImanager ui;

    // Start is called before the first frame update
    void Start()
    {
        ui = FindObjectOfType<UImanager>().GetComponent<UImanager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mc.currentOption == 0)
        {
            playbutton.SetActive(true);
        }

       if(mc.currentOption == 1)
        {
            if (GameManager.control.skin1 == true)
            {
                playbutton.SetActive(true);
            }
            else
            {
                playbutton.SetActive(false);
            }
        }
        if (mc.currentOption == 2)
        {
            if (GameManager.control.skin2 == true)
            {
                playbutton.SetActive(true);
            }
            else
            {
                playbutton.SetActive(false);
            }
        }
        if (mc.currentOption == 3)
        {
            if (GameManager.control.skin3 == true)
            {
                playbutton.SetActive(true);
            }
            else
            {
                playbutton.SetActive(false);
            }
        }

    }



}
