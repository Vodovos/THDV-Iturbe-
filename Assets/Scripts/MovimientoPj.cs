using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPj : MonoBehaviour
{
    public float velocidad = 5f;

    void Start()
    {

    }

    void Update()
    {
        if (Keyboard.current == null) return;

        float entradaX = 0f;
        float entradaZ = 0f;

        
        if (Keyboard.current.dKey.isPressed)
        {
            entradaX += 1f;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            entradaX -= 1f;
        }

        if (Keyboard.current.wKey.isPressed)
        {
            entradaZ += 1f;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            entradaZ -= 1f;
        }

        
        Vector3 direccion = new Vector3(entradaX, 0f, entradaZ);

       

       
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
    }
}