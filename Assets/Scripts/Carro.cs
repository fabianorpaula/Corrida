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
            velocidade = Random.Range(9, 16);
            Agente.speed = velocidade;
        }

        
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
}
