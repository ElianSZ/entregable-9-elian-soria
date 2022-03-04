using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntreEscenas : MonoBehaviour
{
    public void BtwnNewScene()
    {
        SceneManager.LoadScene("Escena 2");     // Carga la escena 2
    }
}
