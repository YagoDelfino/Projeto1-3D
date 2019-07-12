using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fim : MonoBehaviour
{
    public GameManeger gameManeger;
    void Toque()
    {
        gameManeger.Ganhou();
    }
}
