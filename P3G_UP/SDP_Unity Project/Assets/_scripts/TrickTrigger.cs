using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrickTrigger : MonoBehaviour
{
    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<Player>().GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //start trick
        _player.skateboardtrick();
    }
}
