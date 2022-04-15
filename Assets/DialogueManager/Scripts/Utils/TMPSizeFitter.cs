using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[AddComponentMenu("Layout/TMP Fitter")]
public class TMPSizeFitter : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI m_TextMeshPro;

    public TMPro.TextMeshProUGUI TextMeshPro
    {
        get
        {
            if (m_TextMeshPro == null && transform.GetComponentInChildren<TMPro.TextMeshProUGUI>())
            {
                m_TextMeshPro = transform.GetComponentInChildren<TMPro.TextMeshProUGUI>();
                m_TMPRectTransform = m_TextMeshPro.rectTransform;
            }
            return m_TextMeshPro;
        }
    }

    private RectTransform m_RectTransform;
    public RectTransform rectTransform
    {
        get
        {
            if (m_RectTransform == null)
            {
                m_RectTransform = GetComponent<RectTransform>();
            }
            return m_RectTransform;
        }
    }


    private RectTransform m_TMPRectTransform;
    public RectTransform TMPRectTransform { get { return m_TMPRectTransform; } }

    private float m_PreferredHeight;
    public float PreferredHeight { get { return m_PreferredHeight; } }

    private float m_PreferredWidth;
    public float PreferredWidth { get { return m_PreferredWidth; } }

    void SetHeight()
    {
        if (TextMeshPro == null)
            return;

        m_PreferredHeight = TextMeshPro.preferredHeight;
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, m_PreferredHeight);
    }

    void SetWidth()
    {
        if (TextMeshPro == null)
            return;

        m_PreferredWidth = TextMeshPro.preferredWidth;
        rectTransform.sizeDelta = new Vector2(m_PreferredWidth, rectTransform.sizeDelta.y);
    }

    private void OnEnable()
    {
        SetHeight();
        SetWidth();
    }

    private void Start()
    {
        SetHeight();
        SetWidth();
    }

    private void Update()
    {
        if (PreferredHeight != TextMeshPro.preferredHeight)
        {
            SetHeight();
            SetWidth();
        }
    }
}
