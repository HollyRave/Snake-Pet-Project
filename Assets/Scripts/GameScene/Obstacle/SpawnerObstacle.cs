using UnityEngine;

public class SpawnerObstacle : MonoBehaviour
{
    [SerializeField] private Object _prefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _timeBetweenSpawn;

    private float _elapsedTime = 0;
    private int _currentSpawnPoint;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        
        if(_elapsedTime >= _timeBetweenSpawn)
        {
            _elapsedTime = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        _currentSpawnPoint = Random.Range(0, _spawnPoints.Length);

        Instantiate(_prefab, _spawnPoints[_currentSpawnPoint]);
    }
}
