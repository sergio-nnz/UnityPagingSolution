using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PageController : MonoBehaviour
{
    [SerializeField] private Button _nextButton;
    [SerializeField] private Button _previousButton;
    [SerializeField] private TextMeshProUGUI _textPage;

    // IPage pageSelection = new PageSelector();

    public void SetTextForPaging()
    {
        //  Sets new text to the pager
    }

    public void NexPage()
    {
        // Set text from a certain iterator?
    }

    public void PreviousPage()
    {
        // Set text from a certain iterator
    }

    public void ToggleButtons()
    {
        // Turns buttons on and off
    }
}
