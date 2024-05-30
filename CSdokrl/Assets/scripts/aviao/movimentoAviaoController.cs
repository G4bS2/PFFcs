using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoAviaoController : MonoBehaviour
{
    [Header("Movimento da Elice")]
    [Tooltip("Velocidade da elice")]
    [SerializeField] private float fatorDeGiro;
    [SerializeField] private GameObject elice;
    [Header("Movimento do aviao")]
    [SerializeField] private KeyCode paraCima;
    [SerializeField] private KeyCode paraBaixo;
    [SerializeField] private KeyCode paraDireita;
    [SerializeField] private KeyCode paraEsquerda;
    [SerializeField] private KeyCode acelerador;
    [SerializeField] private KeyCode freio;
    private float velocidade = 0;
    public bool ligado = false;
    public bool temCombustivel = true;

    void Start()
    {
        
    }
    void Update()
    {
        if (ligado)
        {
            giroDaElice();
            movimento();
        }

    }
    
    public void movimento()
    {
        if (Input.GetKey(acelerador))
        {
            velocidade += Time.deltaTime;
        }
        if (Input.GetKey(freio))
        {
            if (velocidade > 0.02f)
            {
                velocidade -= Time.deltaTime;
            }
        }
        #region virar o aviao
        float moveX = 0;
        float moveY = 0;
        float moveZ = 0;
        if (Input.GetKey(paraCima))
        {
            moveX = -1;
        }
        if (Input.GetKey(paraBaixo))
        {
            moveX = +1;
        }
        if (Input.GetKey(paraDireita))
        {
            moveY = 1;
            moveZ = -1;
        }
        if (Input.GetKey(paraEsquerda))
        {
            moveY = -1;
            moveZ = 1;
        }
        #endregion

        transform.Translate(Vector3.forward * velocidade);
        transform.Rotate(moveX, moveY, moveZ);
    }


    public void giroDaElice()
    {
        elice.transform.Rotate(new Vector3(0, fatorDeGiro * Time.deltaTime, 0));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Jogador") 
        {
            ligado = true;
            collision.gameObject.SetActive(false);
            //Destroy(collision.gameObject);
        }
    }
}
