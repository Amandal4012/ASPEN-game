using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BobaManager : MonoBehaviour
{
    public static BobaManager instance;
    public GameObject MainGameCanvas;
    [SerializeField] private GameObject _upgradeCanvas;
    [SerializeField] private TextMeshProUGUI _bobaCountText;
    [SerializeField] private TextMeshProUGUI _bobaPerSecondText;
    [SerializeField] private GameObject _bobaObj;
    public GameObject BobaTextPopup;
    [SerializeField] private GameObject _backgroundnObj;

    [Space]
    [SerializeField] private GameObject _upgradeUIToSpawn;
    [SerializeField] private Transform _upgradeUIParent;
    public GameObject BobaPerSecondObjToSpawn;

    public double CurrentBobaCount {  get; set; }

    public double CurrentBobaPerSecond { get; set; }

    // upgrades

    public double BobaPerClickUpgrade { get; set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        UpdateBobaUI();
        UpdateBobaPerSecondUI();

        _upgradeCanvas.SetActive(false);
        MainGameCanvas.SetActive(true);
    }

    #region On Boba Clicked

    public void OnBobaClicked()
    {
        IncreaseBoba();
    }

    public void IncreaseBoba()
    {
        CurrentBobaCount += 1 + BobaPerClickUpgrade;
        UpdateBobaUI() ;

    }
    #endregion

    #region UI Updates

    private void UpdateBobaUI()
    {
        _bobaCountText.text = CurrentBobaCount.ToString();
    }

    private void UpdateBobaPerSecondUI()
    {
        _bobaPerSecondText.text = CurrentBobaPerSecond.ToString() + " P/S";
    }

    #endregion

    #region Butto Presses

    public void OnUpgradeButtonPress()
    {
        MainGameCanvas.SetActive(false );
        _upgradeCanvas.SetActive(true );
    }

    public void OnResumeButtonPress()
    {
        _upgradeCanvas.SetActive(false);
        MainGameCanvas.SetActive(true);
    }
    #endregion
}


