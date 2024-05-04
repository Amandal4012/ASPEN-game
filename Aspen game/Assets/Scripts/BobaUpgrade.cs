using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BobaUpgrade : ScriptableObject
{
    public float UpgradeAmount = 1f;
    public double OriginalUpgradeCost = 50;
    public double CurrentUpgradeCost = 50;
    public double CostIncreaseMultiplierPerPurchase = 5f;

    public string UpgradeButtonText;
    [TextArea(3, 10)]

    public string UpgradeButtonDescription;

    public abstract void ApplyUpgrade();

    private void OnValidate()
    {
        CurrentUpgradeCost = OriginalUpgradeCost;
    }
}
