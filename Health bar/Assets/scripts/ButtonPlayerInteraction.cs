using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPlayerInteraction : MonoBehaviour
{
    [SerializeField] private Button _buttonTakeHeal;
    [SerializeField] private Button _buttonTakeDamage;

    [SerializeField] private TextMeshProUGUI _healthStatus;

    [Header("��������")]
    [SerializeField] private Health _health;

    [Header("����/�������")]
    [SerializeField] private float _damage;
    [SerializeField] private float _heal;

    private void Start()
    {
        Draw();
    }

    protected void OnEnable()
    {
        _buttonTakeDamage.onClick.AddListener(TakeDamage);
        _buttonTakeHeal.onClick.AddListener(TakeHeal);
    }

    protected void OnDisable()
    {
        _buttonTakeDamage.onClick.RemoveListener(TakeDamage);
        _buttonTakeHeal.onClick.RemoveListener(TakeHeal);
    }

    private void Update()
    {
        Draw();
    }

    private void TakeDamage()
    {
        _health.TakeDamage(_damage);
    }

    private void TakeHeal()
    {
        _health.TakeHeal(_heal);
    }

    private void Draw()
    {
        _healthStatus.text = $"��������:\n{_health.HealthPoint} �� {_health.MaxHealthPoint}";
    }
}
