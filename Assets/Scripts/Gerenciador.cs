using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerenciador : MonoBehaviour
{
    public List<Carro> Carros;
    public GameObject TELAVITORIA;
    public Text C1;
    public Text C2;
    public Text C3;
    public Text C4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int PosCarro(float minhaDist)
    {
        int minhaPos = Carros.Count;
        if(minhaDist > Carros[0].dist)
        {
            minhaPos--;
        }
        if (minhaDist > Carros[1].dist)
        {
            minhaPos--;
        }
        if (minhaDist > Carros[2].dist)
        {
            minhaPos--;
        }
        if (minhaDist > Carros[3].dist)
        {
            minhaPos--;
        }
        return minhaPos;
    }

    public void Vitoria()
    {
        TELAVITORIA.SetActive(true);
        QualAPos(0);
        QualAPos(1);
        QualAPos(2);
        QualAPos(3);
        Time.timeScale = 0;
    }

    void QualAPos(int Ncarro)
    {
        switch (Carros[Ncarro].posA)
        {
            case 1:
                C1.text = "Primero : " + Carros[Ncarro].name;
                break;
            case 2:
                C2.text = "Segundo : " + Carros[Ncarro].name;
                break;
            case 3:
                C3.text = "Terceiro : " + Carros[Ncarro].name;
                break;
            case 4:
                C4.text = "Quarto : " + Carros[Ncarro].name;
                break;
        }
    }

}
