using UnityEngine;

public class InformationButton : MonoBehaviour
{
    public string url = " https://www.maxfabrique.com/"; // Пример ссылки

    public void OpenLink()=> GoToLink();

    private void GoToLink()
    {
        Application.OpenURL(url);
        Sound.instance.PlayButton();
    }
}
