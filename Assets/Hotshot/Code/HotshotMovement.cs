using UnityEngine;

//tanner brewer 2023

namespace Hotshot
{
    public class HotshotMovement : MonoBehaviour {

        private void Update() {
            Debug.Log( InputManager.Instance.Movement );
        }

    }
}
