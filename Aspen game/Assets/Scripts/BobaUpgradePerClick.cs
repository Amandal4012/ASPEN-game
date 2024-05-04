using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Boba Upgrade/ Boba Per Click", fileName = "Boba Per Click")]
public class BobaUpgradePerClick : BobaUpgrade
{
    public override void ApplyUpgrade()
    {
        BobaManager.instance.BobaPerClickUpgrade += UpgradeAmount;
    }
}
