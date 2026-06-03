using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Main.UI.Dark
{
    public class PressKeyEvent : MonoBehaviour
    {
        // Settings
        public InputAction hotkey;

        // Events
        public UnityEvent onPressEvent;

        void Start()
        {
            hotkey.Enable();
        }

        void Update()
        {
            if (hotkey.triggered)
                onPressEvent.Invoke();
        }
    }
}