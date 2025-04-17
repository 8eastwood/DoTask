using DG.Tweening;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _size;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    
    void Start()
    {
        transform.DOScale(_size, _duration).SetLoops(_repeats, _loopType);
    }
}
