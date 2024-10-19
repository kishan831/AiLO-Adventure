using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeJumpMechanic : MonoBehaviour
{
    public float jumpForce = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            // Apply an upward force to simulate the jump
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.Log("JJJJJJ");
        }
    }
}
