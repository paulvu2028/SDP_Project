using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public GameObject dialogbox;
    public Dialogue dialogue;
    public bool playerInRange;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && playerInRange)
        {
            if (dialogbox.activeInHierarchy)
            {
                dialogbox.SetActive(false);
            }
            else
            {
                dialogbox.SetActive(true);
                TriggerDialogue();
            }
        }
    }

    
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
