using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{

    bool jogoacabou = false;
    public float tempo = 1f;

    public void Ganhou()
    {

    }

    public void GameOver()
    {
        if(jogoacabou == false )
        {
            jogoacabou = true;
            Invoke("Restart", tempo);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
