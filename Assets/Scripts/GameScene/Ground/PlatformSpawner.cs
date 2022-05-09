using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private Object _prefab;
    [SerializeField] private DestroyArea _destroyArea;

    private void OnEnable()
    {
        _destroyArea.Destroyed += Spawn;
    }

    private void OnDisable()
    {
        _destroyArea.Destroyed -= Spawn;
    }

    private void Spawn()
    {
        Instantiate(_prefab, _spawnPosition.transform);
    }
}
