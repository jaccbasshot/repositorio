using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlGenerator_ChrisPalominos : MonoBehaviour
{
    public GameObject[] partesDeNivel;
    public float distanciaMin;
    public Transform puntoFinal;
    public int partesIniciales;
    //public Transform jugador;
    public Player jugador;

    private void Start()
    {
        jugador = FindAnyObjectByType<Player>();
    }

    private void Update()
    {
        if(Vector2.Distance(jugador.transform.position, puntoFinal.position) < distanciaMin)
        {
            GenerarParteNivel();
        }
    }

    public void GenerarParteNivel()
    {
        int numeroRandom = Random.Range(0, partesDeNivel.Length);
        GameObject nivel = Instantiate(partesDeNivel[numeroRandom], puntoFinal.position, Quaternion.identity);
        puntoFinal = BuscarPuntoFinal(nivel, "PuntoFinal");
    }

    public Transform BuscarPuntoFinal(GameObject parteNivel, string etiqueta)
    {
        Transform punto = null;
        foreach(Transform ubicacion in parteNivel.transform)
        {
            if(ubicacion.CompareTag(etiqueta))
            {
                punto = ubicacion;
                break;
            }
        }
        return punto;
    }
}
