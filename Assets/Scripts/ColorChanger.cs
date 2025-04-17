using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    private void Start()
    {
        _material.DOColor(_color, _duration);
    }
}
