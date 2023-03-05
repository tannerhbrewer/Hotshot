using UnityEngine;

//tanner brewer 2023

namespace Hotshot
{
    public class HotshotInteraction : MonoBehaviour, IObserver {

        public void OnNotify() {

            Debug.Log( "Interaction" );

        }

        private void OnEnable() {
            InputManager.Instance.interactEvent.AddObserver( this );
        }

    }
}
