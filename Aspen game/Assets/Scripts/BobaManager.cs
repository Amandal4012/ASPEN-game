using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
public class BobaManager : MonoBehaviour
{
    public Sprite SecondBoba;
    public Image oldImage;
    public Sprite newImage; 
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

    public SpriteRenderer spriteRenderer;

    

    void ChangeSprite()

    {
        spriteRenderer.sprite = SecondBoba;
    }
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

    #region Button Presses

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

    #region Simple Increases

    public void SimpleBobaIncrease(double amount)
    {
        CurrentBobaCount += amount;
        UpdateBobaUI();
    }

    public void SimpleBobaPerSecondIncrease(double amount)
    {
        CurrentBobaPerSecond += amount;
        UpdateBobaUI();
    }
    #endregion

    #region Upgrade Click
    public void OnUpgradeButtonClick(BobaUpgrade upgrade, UpgradeButtonReferences buttonRef)
    {
        if(CurrentBobaCount >= upgrade.CurrentUpgradeCost)
        {
            upgrade.ApplyUpgrade();
            CurrentBobaCount -= upgrade.CurrentUpgradeCost;
            UpdateBobaUI();

            upgrade.CurrentUpgradeCost = Mathf.Round((float)CurrentBobaCount);
        }
    }
    #endregion

     void Start()
    {

        
    }
    public void ImageChange()
    {
        if (CurrentBobaCount == 50)
        {
            oldImage.sprite = newImage;
            Debug.Log("You win!");
        }

    }

}



