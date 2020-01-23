using UnityEngine;

public class PlayerController : MonoBehaviour, IInputReceiver
{
    public float Sensitivity = 1f;

    public void OnDrag(Vector2 delta)
    {
        transform.Rotate(Vector3.forward, delta.x * Sensitivity);
    }
}
