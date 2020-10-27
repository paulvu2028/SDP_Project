using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelChanger : MonoBehaviour
{
    public SkinnedMeshRenderer _modelref;

    public List<Mesh> options = new List<Mesh>();

    public int currentOption = 0;

    private void Start()
    {
        _modelref.sharedMesh = options[GameManager.control.characterModel];
    }

    private void Update()
    {
        
    }

    public void NextOption()
    {
        currentOption++;
        GameManager.control.characterModel = currentOption;
        if(currentOption == 4)
        {
            currentOption = 0;
        }

        _modelref.sharedMesh = options[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        GameManager.control.characterModel = currentOption;
        if (currentOption == -1)
        {
            currentOption = 3;
        }


        _modelref.sharedMesh = options[currentOption];
    }
}
