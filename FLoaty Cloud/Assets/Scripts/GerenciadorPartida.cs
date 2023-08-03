using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorPartida : MonoBehaviour
{
    private bool partidainiciada;
    private void Awake()
    {
        Time.timeScale = 0;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (partidainiciada) return;
        if(Input.GetMouseButtonDown(0))
        {
            partidainiciada = true;
            Time.timeScale = 1;
        }
    }

    public void ReiniciarPartida()
    {
        SceneManager.LoadScene(0); 
    }
}
