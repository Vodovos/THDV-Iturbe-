using UnityEngine;

public class Ejercicio1Tiempo : MonoBehaviour
{
    float tiempo = 0;
    int segundos = 0;
    int duracion = 10;
    bool terminado = false;
   int segundosRestantes = 10;
    void Start()
    {
        
    }


    void Update()
    {
        // Pepito();
       LogicaCuentaRegresiva();


        }
    void Pepito()
    {
        if (!terminado)

        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;
                Debug.Log("segundo:" + segundos);
                tiempo = 0;

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer Terminado");
                }
            }
        }

    }
    void LogicaCuentaRegresiva()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= 1)
        {
            segundosRestantes--;

            Debug.Log("segundos restantes" + segundosRestantes);
            tiempo = 0;

            if (segundosRestantes <= 0)
            {
                terminado = true;
                Debug.Log("Timer Terminado");
            }
        }

    }
            




        
}
