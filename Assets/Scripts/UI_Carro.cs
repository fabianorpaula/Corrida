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
    public Text mostrarPos;
    void Start()
    {
        
    }

    
    void Update()
    {
        mostraNome.text = MeuCarro.MostraNome();
        mostraVelocidade.text = MeuCarro.MostraVelocidade() +  " Km/h";
        mostraVolta.text = "Volta: " + MeuCarro.MostraVolta();
        mostrarPos.text = "Pos: " + MeuCarro.posA;
    }
}
