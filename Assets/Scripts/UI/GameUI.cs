using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : BaseUI
{
    [SerializeField] private Slider hpSlider;
    [SerializeField] private Button pauseButton;
    private bool pauseActive = false;
    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);
        pauseButton.onClick.AddListener(OnClickPauseButton);
    }
    private void Start()
    {
        UpdateHPSlider(1); // ���� �� ü�� �����̴��� ���� ä�� (100%)
    }

    // ü�� �����̴� ���� �ۼ�Ʈ(0~1)�� ����
    public void UpdateHPSlider(float percentage)
    {
        hpSlider.value = percentage;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseActive == false)
            {
                uimanager.ShowPauseUI();
                pauseActive = true;
            }
            else
            {
                uimanager.HidePauseUI();
                pauseActive = false;
            }
                
        }
    }
    public void OnClickPauseButton()
    {
        if (pauseActive == false)
        {
            uimanager.ShowPauseUI();
            pauseActive = true;
        }
        else
        {
            uimanager.HidePauseUI();
            pauseActive = false;
        }
    }
    protected override UIState GetUIState()
    {
        return UIState.Game;
    }
}
