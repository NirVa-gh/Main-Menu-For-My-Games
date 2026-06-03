using UnityEngine;

namespace Main.UI.Dark
{
    public class ExitToSystem : MonoBehaviour
    {
        public void ExitGame()
        {
            Debug.Log("Exit method is working in builds.");
            Application.Quit();
        }
    }
}