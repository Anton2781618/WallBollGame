using UnityEngine;
using UnityEngine.UI;

public class UiContainerObjects : MonoBehaviour
{
    public Canvas MyCanvas { get; private set;}

    public Text EndMenuTimeText;

    public Text EndMenuAttemptText;

    public Text TimeText;



    private void Start()
    {
        MyCanvas = FindObjectOfType<Canvas>();
    }
}
