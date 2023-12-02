using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int inimigosDerrotados;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuacao(int pontosParaGanhar)
    {
        inimigosDerrotados += pontosParaGanhar;
    }
}
