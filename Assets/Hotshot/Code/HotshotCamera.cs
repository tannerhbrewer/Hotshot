using UnityEngine;

//tanner brewer 2023

namespace Hotshot
{
    public class HotshotCamera : MonoBehaviour {

        [Header("Camera Values")]
        [SerializeField] private Transform target;
        [SerializeField] private float smoothTime = 0.25f;

        private Vector3 offset = new Vector3( 0f, 0f, -10f );
        private Vector3 velocity = Vector3.zero;

        private void FixedUpdate() {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp( transform.position, targetPosition, ref velocity, smoothTime );
        }

    }
}
