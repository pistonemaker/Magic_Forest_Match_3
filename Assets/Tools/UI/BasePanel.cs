using DG.Tweening;
using UnityEngine;

public class BasePanel : MonoBehaviour
{
    protected virtual void OnEnable()
    {
        OpenPanel();
        LoadButtonAndImage();
        SetListener();
    }

    protected void OpenPanel()      
    {
        transform.localScale = Vector3.one * 1.3f;
        transform.DOScale(Vector3.one * 1.02f, 0.15f);
    }

    protected virtual void ClosePanel(float time, bool resume = true)
    {
        gameObject.SetActive(false);
    }

    protected virtual void LoadButtonAndImage()
    {
        
    }

    protected virtual void SetListener()
    {
        
    }

    protected void Reset()
    {
        LoadButtonAndImage();
    }
}