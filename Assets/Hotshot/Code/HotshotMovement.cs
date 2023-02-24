using UnityEngine;

//tanner brewer 2023

namespace Hotshot
{
    public class HotshotMovement : MonoBehaviour {

        [SerializeField] private float movementSpeed = 5.0f;
        [SerializeField] private Rigidbody2D rb;

        private void FixedUpdate() {
            Vector2 movementVector = InputManager.Instance.Movement.normalized;
            rb.velocity = new Vector2( movementVector.x * movementSpeed, movementVector.y * movementSpeed );
        }

    }
}
