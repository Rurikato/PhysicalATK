using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gate")
        {
            print("ENTER");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "gate")
        {
            print("STAY");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "gate")
        {
            print("EXIT");
        }
    }
}