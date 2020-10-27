using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JacketDest : MonoBehaviour
{
    public int destPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            if (destPoint == 4)
            {
                destPoint = 0;
            }
            if(destPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(-15, 1, 70);
                destPoint = 4;
            }
            if (destPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-15, 1, 86);
                destPoint = 3;
            }
            if (destPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(-15, 1, 70);
                destPoint = 2;
            }
           
            if (destPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-38, 1, 70);
                destPoint = 1;
            }
        }
    }
}
