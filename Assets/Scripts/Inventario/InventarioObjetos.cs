using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioObjetos : MonoBehaviour
{

    public GameObject contenedorInventario;
    private NombresObjetos objetosDisponibles;
    private BaseDeDatosJugador objetosObtenidos;



    // Start is called before the first frame update
    void Start()
    {
        objetosDisponibles = contenedorInventario.GetComponent<NombresObjetos>();
        objetosObtenidos = contenedorInventario.GetComponent<BaseDeDatosJugador>();

        //Notas
        for (int i = 0; i < objetosDisponibles.ItemsString.Length; i++)
        {
            string item = objetosDisponibles.ItemsString[i];
            if (item.Substring(0, 4) == "nota")
            {
                int j = 0;
                while (j < objetosObtenidos.slotsBasicos.Length)
                {
                    if (item == objetosObtenidos.slotsBasicos[j])
                    {
                        print("Tengo esta nota " + objetosObtenidos.slotsBasicos[j]);
                        break;
                    }
                    j++;
                }
            }
        }

        //Objetos
        for (int i = 0; i < objetosDisponibles.ItemsString.Length; i++)
        {
            string item = objetosDisponibles.ItemsString[i];
            if (item.Substring(0, 4) != "nota")
            {
                int j = 0;
                while (j < objetosObtenidos.slotsBasicos.Length)
                {
                    if (item == objetosObtenidos.slotsBasicos[j])
                    {
                        //Instantiate()
                        print("Tengo este objeto " + objetosObtenidos.slotsBasicos[j]);
                        break;
                    }
                    j++;
                }
            }     
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
