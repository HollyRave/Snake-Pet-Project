using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DestroyArea"))
        {
            Destroy(gameObject);
        }
    }
}
