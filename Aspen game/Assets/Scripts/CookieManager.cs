using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CookieManager : MonoBehaviour
{
    public GameObject MainGameCanvas;
    [SerializeField] private GameObject _upgradeCanvas;
    [SerializeField] private TextMeshProUGUI _BobaCountText;
    [SerializeField] private TextMeshProUGUI _BobaPerSecondText;
    [SerializeField] private GameObject _BobaObj;
    public GameObject BobaTextPopup;
    [SerializeField] private GameObject _backgroundnObj;

    [Space]
    [SerializeField] private GameObject _upgradeUIToSpawn;
    [SerializeField] private Transform _upgrade UIParent;
    public GameObject BobaPerSecondObjToSpawn;

    public double CurrentBobaCount {  get; set; }

    public double CurrentBobaPerSecond { get; set; }

    // upgrades

    public double BobaPerClickUpgrade { get; set; }
}
