using UnityEngine;

public class InformationButton : MonoBehaviour
{
    //public string url = " https://www.maxfabrique.com/"; 

    //public void OpenLink()=> GoToLink();

    //private void GoToLink()
    //{
    //    Application.OpenURL(url);
    //    Sound.instance.PlayButton();
    //}


    public string url = "https://www.maxfabrique.com/"; // Замените на нужный URL

    public void Open()
    {
        Application.OpenURL(url);
    }
}
