using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderHealthBarSmoothy : MonoBehaviour
{
    [SerializeField] private Button _takeDamage;
    [SerializeField] private Button _takeHeal;

    [SerializeField] private Health _health;
    [SerializeField] private float _sliderSpeedChange;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Start()
    {
        _slider.maxValue = _health.MaxHealthPoint;
        _slider.value = _health.HealthPoint;
    }

    private void Update()
    {
        ChangeSlider();
    }

    private void ChangeSlider()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _health.HealthPoint, Time.deltaTime * _sliderSpeedChange);
    }
}
