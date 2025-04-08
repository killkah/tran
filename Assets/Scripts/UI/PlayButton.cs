using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : SimpleButton
{
    /// <summary>
    /// Переписываем функцию добавлением функционал (переход на сцену Game)
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
