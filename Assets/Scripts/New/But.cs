using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class But : MonoBehaviour
{
    public string url = "https://www.maxfabrique.com/"; // �������� �� ������ URL

    public void Open()
    {
        Application.OpenURL(url);
    }
}
