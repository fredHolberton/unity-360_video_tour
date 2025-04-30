using UnityEngine;
using TMPro;

public class InformationController : MonoBehaviour
{
    
    public GameObject informationGO;
    
    public TextMeshProUGUI informationText;

    public GameObject whiteboardButton;

    private const string whiteboardText = "Whiteboard walls, projectors, and plenty of seating bring students together to discuss projects and concepts.";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayWhiteboardInfo()
    {
        informationGO.SetActive(!informationGO.activeSelf);
        informationText.text = whiteboardText;
        //informationGO.transform.position = new Vector3(whiteboardButton.transform.position.x + 20, informationGO.transform.position.y, informationGO.transform.position.z); 
    }


}
