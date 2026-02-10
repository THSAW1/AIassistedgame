using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private void OnMove(InputValue inputValue)
    {
        Debug.Log(inputValue.Get<Vector2>());
    }
}
