using UnityEngine;

public class SnakeMover : MonoBehaviour
{
    [SerializeField] private float _stepSize;
    [SerializeField] private float _speed;
    [SerializeField] private float _leftMaxPoint;
    [SerializeField] private float _rightMaxPoint;

    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    public void MoveLeft()
    {
        _targetPosition = new Vector2(_targetPosition.x + _stepSize, _targetPosition.y);
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
    }

    public void MoveRight()
    {
        _targetPosition = new Vector2(_targetPosition.x - _stepSize, _targetPosition.y);
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
    }
}
