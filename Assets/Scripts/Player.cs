using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody Corpo;
    private Transform Tcorpo;
    private AudioSource MeusPassos;//para ouvir passos
    public float sensibilidade = 1000f;
    public float speed = 4;
    public float movX;
    public float movZ;
    public GameObject ArmaDeFogo;

    


    void Start()
    {
        Corpo = GetComponent<Rigidbody>();
        Tcorpo = GetComponent<Transform>();
      
    }

    void Update()
    {
        movZ = Input.GetAxis("Vertical") * speed;
        movX = Input.GetAxis("Horizontal") * sensibilidade * Time.deltaTime; ;
        

        


    }


    private void FixedUpdate()
    {
        Tcorpo.Rotate(Vector3.up * movX);
        if (movZ > 0)
        {
            Corpo.AddRelativeForce(0, 0, 1f, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Corpo.AddRelativeForce(0, 0, -0.05f, ForceMode.Impulse);
        }
    }
}
