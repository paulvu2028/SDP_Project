using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeanDest : MonoBehaviour
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
            if (destPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(-14, 1, 71);
                destPoint = 4;
            }
            if (destPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-14, 1, 95);
                destPoint = 3;
            }
            if (destPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(-14, 1, 71);
                destPoint = 2;
            }
            if (destPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-67, 1, 71);
                destPoint = 1;
            }
        }
    }
}
