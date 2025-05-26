using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UINotas : MonoBehaviour
{
    public GameObject nota1;

    private bool juegoPausado = false;
    public FirstPersonController jugador;

    private void Awake()
    {
        nota1 = GameObject.FindGameObjectWithTag("nota1");
    }

    private void Start()
    {
        nota1.SetActive(false);
    }

    void Update()
    {

    }

    public void AbrirNotas()
    {
        nota1.SetActive(true);
        jugador.cameraCanMove = false;
        Time.timeScale = 0f;
        juegoPausado = true;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
