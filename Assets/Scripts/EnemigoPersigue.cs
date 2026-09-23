

using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyChaser : MonoBehaviour
{
    [Header("Referencias")]
    [Tooltip("Arrastra aquí el Transform del jugador.")]
    [SerializeField] private Transform player;

    [Header("Variables de Balance")]
    [Tooltip("Distancia máxima a la que el enemigo comienza a perseguir al jugador.")]
    [SerializeField] private float detectionRange = 10f;
    [Tooltip("Velocidad de movimiento del enemigo.")]
    [SerializeField] private float moveSpeed = 3.5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Si no se asigna manualmente, busca por la etiqueta "Player"
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
            {
                player = playerObj.transform;
            }
        }
    }

    private void FixedUpdate()
    {
        if (player == null) return;

        // Calculamos la distancia entre el enemigo y el jugador en el plano X-Z
        float distanceToPlayer = Vector3.Distance(
            new Vector3(transform.position.x, 0f, transform.position.z),
            new Vector3(player.position.x, 0f, player.position.z)
        );

        if (distanceToPlayer <= detectionRange)
        {
            // Dirección hacia el jugador (solo en X y Z)
            Vector3 direction = player.position - transform.position;
            direction.y = 0f;
            direction = direction.normalized; // CORREGIDO: Asignamos el valor normalizado

            // Mover usando Rigidbody manteniendo la velocidad vertical (gravedad)
            Vector3 targetVelocity = direction * moveSpeed;
            targetVelocity.y = rb.linearVelocity.y;
            rb.linearVelocity = targetVelocity;
        }
        else
        {
            // Detener el movimiento horizontal si sale del rango
            Vector3 velocity = rb.linearVelocity;
            velocity.x = 0f;
            velocity.z = 0f;
            rb.linearVelocity = velocity;
        }
    }
}