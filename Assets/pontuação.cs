using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontuação : MonoBehaviour
{
    public Transform player;
    public Text pontuaçãoT;

    void Update()
    {
        pontuaçãoT.text = player.position.z.ToString("0");
    }
}
