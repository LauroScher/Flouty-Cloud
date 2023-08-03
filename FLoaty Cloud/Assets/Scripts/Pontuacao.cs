using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    private float tempo;
    private int pontuacao;

    [SerializeField]private TMP_Text pontuacaoText;
    [SerializeField]private TMP_Text pontuacaoGameOverText;

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        pontuacao = (int)(tempo * 5);

        pontuacaoText.text = pontuacao.ToString("000000");
        pontuacaoGameOverText.text = pontuacao.ToString("000000");
    }
}
