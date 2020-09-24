using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelChanger : MonoBehaviour
{
    public SkinnedMeshRenderer customisation;

    public List<Mesh> options = new List<Mesh>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0;
        }

        customisation.sharedMesh = options[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if(currentOption <= 0)
        {
            currentOption = options.Count - 1;
        }

        customisation.sharedMesh = options[currentOption];
    }
}
