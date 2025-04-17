using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private string _string1;
    [SerializeField] private Text _text2;
    [SerializeField] private string _string2;
    [SerializeField] private Text _text3;
    [SerializeField] private string _string3;
    [SerializeField] private float _duration;
    
    private bool _isRichTextEnabled = true;

    private void Start()
    {
        _text1.DOText(_string1, _duration);
        _text2.DOText(_string2, _duration).SetRelative();
        _text3.DOText(_string3, _duration, _isRichTextEnabled, ScrambleMode.All);
    }
}
