using UnityEngine;
using UnityEngine.Events;

public class DestroyArea : MonoBehaviour
{
    public event UnityAction Destroyed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            Destroyed?.Invoke();
        }
    }
}
