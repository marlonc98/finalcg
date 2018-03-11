using UnityEngine;
using System.Collections;

public class creadorDeAmbiente : MonoBehaviour
{
    public int numeroRatones;
    public GameObject raton;
    public int numeroHuevos;
    public GameObject huevo;
    public int numeroPeces;
    public GameObject pez;
    public int numeroArboles;
    public GameObject arbol;
    // Use this for initialization
    void Start()
    {
        crearArboles(numeroArboles);
        //crearPeces(numeroPeces);
        //crearHuevos(numeroHuevos);
        //crearRatones(numeroRatones);
    }
    private void crearArboles(int numArboles)
    {
        for (int i = 0; i < numArboles; i++)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
