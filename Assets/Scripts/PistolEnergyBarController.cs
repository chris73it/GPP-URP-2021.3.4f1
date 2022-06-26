using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.UI;

public class PistolEnergyBarController : MonoBehaviour
{
    [SerializeField] Image pistolBarImage; 
    [SerializeField] FloatReference pistolCurrentEnergy = null;
    [SerializeField] FloatReference pistolMaxEnergy = null;

    void Awake()
    {
        pistolCurrentEnergy.Value = pistolMaxEnergy.Value;
    }

    public void UpdateEnergyBar()
    {
        if (pistolBarImage.fillAmount != pistolCurrentEnergy.Value / pistolMaxEnergy.Value)
        {
            pistolBarImage.fillAmount = pistolCurrentEnergy.Value / pistolMaxEnergy.Value;
        }
    }
}