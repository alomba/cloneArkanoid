using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateModule : MonoBehaviour
{
    public GameObject pinchos;
    Vector3 distancia;
    float moduloDistancia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //debo restar las posiciones entre el player y los pinchos
        distancia = this.gameObject.transform.position - pinchos.transform.position;
        moduloDistancia = distancia.magnitude;
        if (moduloDistancia <= 1.5f)
        {
            Debug.Log("La Distancia entre el player y los pinchos es: " + moduloDistancia);
        }

        
    }
}
