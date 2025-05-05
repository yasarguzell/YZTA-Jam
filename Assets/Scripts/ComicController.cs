using UnityEngine;
using UnityEngine.UI;

public class ComicController : MonoBehaviour
{
    public Image comicImage;
    public Sprite[] panels;
    public Button nextButton;

    private int index = 0;
    public bool IsFinished { get; private set; } = false;

    void Start()
    {
        nextButton.onClick.AddListener(NextPanel);
        ShowPanel();
    }

    void ShowPanel()
    {
        if (index < panels.Length)
        {
            comicImage.sprite = panels[index];
        }
        else
        {
            IsFinished = true;
            gameObject.SetActive(false);
        }
    }

    void NextPanel()
    {
        index++;
        ShowPanel();
    }
}
