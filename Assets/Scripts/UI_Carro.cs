using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Carro : MonoBehaviour
{
    //Declarando Variaveis
    public Text mostraNome;
    public Text mostraVolta;
    public Text mostraVelocidade;
    public Carro MeuCarro;

    void Start()
    {
        
    }

    
    void Update()
    {
        mostraNome.text = MeuCarro.MostraNome();
        mostraVolta.text = MeuCarro.MostraVelocidade() +  " Km/h";
        mostraVolta.text = "Volta: " + MeuCarro.MostraVolta();
    }
}
