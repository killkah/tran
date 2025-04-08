using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : SimpleButton
{
    /// <summary>
    /// ������������ ������� ����������� ���������� (������� �� ����� Game)
    /// </summary>
    public override void OnClick()
    {
        base.OnClick();
        SceneManager.LoadScene("Game");
    }

    private void Start()
    {
        AddButtonListener();
    }
}
