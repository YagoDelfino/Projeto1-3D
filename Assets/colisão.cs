using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisão : MonoBehaviour
{

    public Movimentação mover;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstáculo")
        {
            mover.enabled = false;
        }
    }
}
