using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlInput : MonoBehaviour
{

    public static bool iSpace;
    public static bool iW;
    public static bool iA;
    public static bool iS;
    public static bool iD;
    public static bool iE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }

    public void ClearInputs()
    {

        //Essa função serve para limpar as variáveis booleanas caso necessário
        iSpace = false;
        iW = false;
        iA = false;
        iS = false;
        iD = false;
        iE = false;

    }

    public void CheckInputs()
    {

        //Esta função serve para checar os inputs das teclas Espaço, W, A, S, D e E

        //Armazena se a tecla espaço foi pressionada
        iSpace = Input.GetKeyDown(KeyCode.Space);
        if(iSpace == true)
        {
            //Chama o que precissar aqui
        }
       
        //Armazena se as teclas wasd foram pressionadas
        iW = Input.GetKeyDown(KeyCode.W);
        if(iW == true)
        {
            //Chama o que precissar aqui
        }
        iA = Input.GetKeyDown(KeyCode.A);
        if(iA == true)
        {
            //Chama o que precissar aqui
        }
        iS = Input.GetKeyDown(KeyCode.S);
        if(iS == true)
        {
            //Chama o que precissar aqui
        }
        iD = Input.GetKeyDown(KeyCode.D);
        if(iD == true)
        {
            //Chama o que precissar aqui
        }

        //Armazena se a tecla e foi pressionada
        iE = Input.GetKeyDown(KeyCode.D);
        if(iE == true)
        {
            //Chama o que precissar aqui
        }

    }

}
