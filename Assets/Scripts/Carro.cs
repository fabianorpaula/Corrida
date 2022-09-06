using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Carro : MonoBehaviour
{
    private NavMeshAgent Agente;
    public List <GameObject> Destinos;
    public int indice = 0;
    public float velocidade = 10;
    public float tempo = 0;
    public int volta = 0;
    public string nome;
    public float dist;
    public int posA;
    public Gerenciador GJ;
   
    void Start()
    {
        Agente = GetComponent<NavMeshAgent>();
    }

    void FixedUpdate()
    {
        //Estou indo para o meu destino
        Agente.SetDestination(Destinos[indice].transform.position);
        if(Vector3.Distance(transform.position, Destinos[indice].transform.position) < 5)
        {
            indice++;
            if(indice >= Destinos.Count)
            {
                indice = 0;
            }
        }
        tempo += Time.deltaTime;

        if (tempo > 5)
        {
            tempo = 0;
            velocidade = Random.Range(18, 35);
            Agente.speed = velocidade;
        }
        minhaDistancia();
        posA = GJ.PosCarro(dist);
    }


    public string MostraVelocidade()
    {
        string vel = Agente.speed.ToString();
        return vel;
    }
    public string MostraVolta()
    {
        string volt = volta.ToString();
        return volt;
    }
    public string MostraNome()
    {
        return name;
    }

    //Permite Contar Volta
    private void OnTriggerExit(Collider tocou)
    {
        if(tocou.gameObject.tag == "Bandeira")
        {
            volta++;
            if(volta > 1)
            {
                GJ.Vitoria();
            }
        }
    }


    public void minhaDistancia()
    {
        float minhaV = volta * 10000;
        float minhaW = indice * 100;
        int novoI = indice - 1;
        if(novoI < 0)
        {
            novoI = Destinos.Count - 1;
        }
        float minhaP = Vector3.Distance(transform.position, Destinos[novoI].transform.position);

        dist = minhaV + minhaW + minhaP;
    }
}
