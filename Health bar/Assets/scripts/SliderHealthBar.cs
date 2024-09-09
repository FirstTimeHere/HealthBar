using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderHealthBar : MonoBehaviour
{
    [SerializeField] private Button _takeDamage;
    [SerializeField] private Button _takeHeal;

    [SerializeField] private Health _health;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    protected void OnEnable()
    {
        _takeDamage.onClick.AddListener(ChangeSlider);
        _takeHeal.onClick.AddListener(ChangeSlider);
    }

    protected void OnDisable()
    {
        _takeDamage.onClick.RemoveListener(ChangeSlider);
        _takeHeal.onClick.RemoveListener(ChangeSlider);
    }

    private void Start()
    {
        _slider.maxValue = _health.MaxHealthPoint;
        _slider.value = _health.HealthPoint;
    }

    private void ChangeSlider()
    {
        _slider.value = _health.HealthPoint;
    }
}
