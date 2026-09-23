using UnityEngine;

public class CamaraSeguimiento : MonoBehaviour
{
    // Referencia al Transform del jugador (se asigna en el Inspector arrastrando el Player)
    public Transform objetivo;

    // Distancia o separación relativa entre la cámara y el jugador (altura en Y y retroceso en Z)
    public Vector3 offset = new Vector3(0f, 10f, -7f);

    // LateUpdate se ejecuta después de que todos los Update() del frame terminaron
    void Update()
    {
       
        {
            // Sigue la posición del jugador manteniendo la distancia offset
            transform.position = objetivo.position + offset;
        }
    }
}
