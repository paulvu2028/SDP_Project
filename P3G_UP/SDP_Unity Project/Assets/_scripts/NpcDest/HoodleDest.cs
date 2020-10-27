using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoodleDest : MonoBehaviour
{
    public int destPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            if (destPoint == 2)
            {
                destPoint = 0;
            }
            if (destPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(-73, 1, 40);
                destPoint = 2;
            }
            if (destPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-17, 1, 39);
                destPoint = 1;
            }
        }
    }
}
