using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PageController : MonoBehaviour
{
    [SerializeField] private Button _nextButton;
    [SerializeField] private Button _previousButton;
    [SerializeField] private TextMeshProUGUI _textPage;

    private int PageCount { get; set; }

    private PageController()
    {
        PageCount = 1;
    }

    public void SetTextForPaging(string newText)
    {
        _textPage.text = newText;
    }

    public void NexPage()
    {
        PageCount++;
        _textPage.pageToDisplay = PageCount;
    }

    public void PreviousPage()
    {
        PageCount--;
        _textPage.pageToDisplay = PageCount;
    }

    public void RestorePage()
    {
        PageCount = 1;
        _textPage.pageToDisplay = PageCount;
    }

    public void ToggleButtons()
    {
        // Turns buttons on and off
    }
}
