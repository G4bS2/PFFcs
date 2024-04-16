using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenaController : MonoBehaviour
{
    public Text txtTempo;
    public Text txtQuantidade;
    private float tempo = 0;
    public int quantidadeItems = 0;
    

    public int pontos = 0;
    public Text killConter;
    public static CenaController instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        txtTempo.text = "Tempo: " + tempo;
        txtQuantidade.text = "Items: " + quantidadeItems;
        killConter.text = "Baixas: " + pontos;
    }

    public void AumentarPontos()
    {
        pontos++;
    }
}
