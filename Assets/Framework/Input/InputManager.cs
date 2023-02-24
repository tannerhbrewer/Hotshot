using UnityEngine;
using tannerhbrewer;
using System.Runtime.CompilerServices;

//tanner brewer 2023

namespace Hotshot
{
    public class InputManager : StaticInstance<InputManager> {

        private Controls controls;
        
        public Vector2 Movement { get; private set; }

        override protected void Awake() {
            base.Awake();
            controls = new Controls();
        }

        private void OnEnable() {
            controls.Enable();

            controls.Gameplay.Movement.performed += ctx => Movement = ctx.ReadValue<Vector2>();
            controls.Gameplay.Movement.canceled += ctx => Movement = ctx.ReadValue<Vector2>();
        }

        private void OnDisable() {
            controls.Disable();

            controls.Gameplay.Movement.performed -= ctx => Movement = ctx.ReadValue<Vector2>();
            controls.Gameplay.Movement.canceled -= ctx => Movement = ctx.ReadValue<Vector2>();
        }

        private void Update() {
            
        }

    }
}
