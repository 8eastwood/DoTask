using DG.Tweening;
using UnityEngine;

public class RotationChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _toAngle;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private float _duration;
    
    void Start()
    {
        transform.DORotate(_toAngle, _duration, _rotateMode);
    }
}
