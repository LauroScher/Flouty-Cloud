using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemColisao : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite spritePersonagemGameOver;
    [SerializeField] private GameObject transicaoGameover;
    [SerializeField] private GameObject painelGameOver;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Inimigo" || collision.gameObject.tag =="Limite")
        {
            GameOver();
        }
    }
    
    private void GameOver()
    {
        Time.timeScale = 0;

        spriteRenderer.sprite = spritePersonagemGameOver;
        transicaoGameover.transform.position = transform.position;
        transicaoGameover.SetActive(true);

        StartCoroutine(ExibirPainelGameOver());
    }

    private IEnumerator ExibirPainelGameOver()
    {
        yield return new WaitForSecondsRealtime(1f);
        painelGameOver.SetActive(true);
    }
}
