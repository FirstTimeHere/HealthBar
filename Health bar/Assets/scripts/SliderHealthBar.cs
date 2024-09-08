using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderHealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private DrawSliderSelect _drawSelect;

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
        if (_drawSelect == DrawSliderSelect.Default)
        {
            _slider.value = _health.HealthPoint;
        }
        else
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health.HealthPoint, Time.deltaTime * 1500f);
        }
    }
}
