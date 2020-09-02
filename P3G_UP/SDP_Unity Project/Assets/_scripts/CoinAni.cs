using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAni : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(4, 7, 45) * Time.deltaTime);
    }
}
