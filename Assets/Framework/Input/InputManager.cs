using UnityEngine;
using tannerhbrewer;
using System.Runtime.CompilerServices;

//tanner brewer 2023

namespace Hotshot
{
    public class InputManager : StaticInstance<InputManager> {

        private Controls controls;

        public InteractEvent interactEvent { get; private set; }
        
        public Vector2 Movement { get; private set; }

        override protected void Awake() {
            base.Awake();

            interactEvent = new InteractEvent();

            controls = new Controls();
        }

        private void OnEnable() {
            controls.Enable();

            controls.Gameplay.Movement.performed += ctx => Movement = ctx.ReadValue<Vector2>();
            controls.Gameplay.Movement.canceled += ctx => Movement = ctx.ReadValue<Vector2>();

            controls.Gameplay.Interact.performed += ctx => interactEvent.Notify();
        }

        private void OnDisable() {
            controls.Disable();

            controls.Gameplay.Movement.performed -= ctx => Movement = ctx.ReadValue<Vector2>();
            controls.Gameplay.Movement.canceled -= ctx => Movement = ctx.ReadValue<Vector2>();

            controls.Gameplay.Interact.performed -= ctx => interactEvent.Notify();
        }

    }

}
