using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Snake : MonoBehaviour
{
    public event UnityAction Touched;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Touched?.Invoke();
        }
    }
}
