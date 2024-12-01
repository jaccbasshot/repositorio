using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cAMBIOeSCENA : MonoBehaviour
{
    // Start is called before the first frame update
    public bool pasarVivel;
    public int indiceNivel;
    public int CambioNivel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CambiarNivel(indiceNivel);
        }
        if (pasarVivel)
        {
            CambiarNivel(indiceNivel);
        }
    }

    private void CambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
}
