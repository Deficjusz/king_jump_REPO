using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zarzadzaniescenami : MonoBehaviour
{
    public void Zmienscene()
    {
        SceneManager.LoadScene("Glowna_scena_gry");       
    }
}
