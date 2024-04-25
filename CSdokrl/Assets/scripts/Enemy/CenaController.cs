using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenaController : MonoBehaviour
{
    //public Text txtTempo;
    float tempo = 0;

    

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
        //txtTempo.text = "Tempo: " + tempo;
        killConter.text = "Kills: " + pontos;
    }

    public void AumentarPontos()
    {
        pontos++;
    }
}
