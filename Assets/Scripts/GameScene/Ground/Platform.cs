using UnityEngine;
using UnityEngine.Events;

public class Platform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DestroyArea"))
        {
            Destroy(gameObject);
        }
    }
}
