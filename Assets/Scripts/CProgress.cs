using UnityEngine;
using UnityEngine.UI;

public class CProgress : MonoBehaviour
{
    [SerializeField] private Image[] _starImages;
    [SerializeField] private Sprite _openStar;
    [SerializeField] private Sprite _closeStar;
    [SerializeField] private RectTransform _progressTransform;

    public float[] targetsPercent;

    public float maxProgress = 1000f;

    public GameObject[] stars;

    private bool[] reachTargets;

    private RectTransform rectransform;

    private float maxWidth;

    private float current;

    public float Current
    {
        get { return current; }
        set
        {
            current = value;
            UpdateUI();
        }
    }

    private void Start()
    {
        foreach (var star in _starImages)
            star.sprite = _closeStar;


        rectransform = GetComponent<RectTransform>();
        Vector2 sizeDelta = rectransform.sizeDelta;
        maxWidth = sizeDelta.x;
        reachTargets = new bool[targetsPercent.Length];
        Current = 0f;
    }

    private void UpdateUI()
    {
        if (maxProgress == 0f)
        {
            return;
        }

        float num = Mathf.Clamp(Current / maxProgress, 0f, 1f);
        RectTransform rectTransform = rectransform;
        // RectTransform rectTransform = _progressTransform;
        float x = maxWidth * num;
        Vector2 sizeDelta = rectransform.sizeDelta;
        rectTransform.sizeDelta = new Vector2(x, sizeDelta.y);
        for (int i = 0; i < targetsPercent.Length; i++)
        {
            if (!reachTargets[i] && num >= targetsPercent[i])
            {
                OnReachTarget(i);
                reachTargets[i] = true;
            }
        }
    }

    private void OnReachTarget(int target)
    {
        Debug.Log("INDEX " + target);
        _starImages[target].sprite = _openStar;
        
        if (stars.Length > target)
        {
            _starImages[target].sprite = _openStar;
            stars[target].SetActive(value: true);
        }
    }

    public int GetReachedTarget()
    {
        int num = 0;
        for (int i = 0; i < reachTargets.Length; i++)
        {
            if (reachTargets[i])
            {
                num++;
            }
        }

        return num;
    }
}