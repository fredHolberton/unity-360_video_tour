using UnityEngine;
using TMPro;

public class InformationController : MonoBehaviour
{
    /// <summary>
    /// Game object to display information
    /// </summary>
    public GameObject informationGO;
    
    /// <summary>
    /// Textbox to display information
    /// </summary>
    public TextMeshProUGUI informationText;

    // Texts to display Information text
    private const string whiteboardText = "Whiteboard walls, projectors, and plenty of seating bring students together to discuss projects and concepts.";
    private const string libraryText = "Above Holberton's entrance is our library, a bright, cozy nook overlooking the school's open space.";
    private const string cubeText = "The Cube is a comfortable, quiet space to work, relax, or take a quick nap.";
    private const string cantinaText = "Our cantina is also our meetup space, featuring a stage for student presentations as well as talks and fireside chats with industry professionals.";
    private const string mezzanineText1 = "Our mezzanine’s booth seating encourages students to talk, collaborate, and work together to solve problems.";
    private const string mezzanineText2 = "Holberton provides iMacs for students to use as well as plenty of open desk space for those who opt to bring in their own laptops.";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Display Whiteboard Information
    /// </summary> 
    public void DisplayWhiteboardInfo()
    {
        informationGO.SetActive(!informationGO.activeSelf);
        informationText.text = whiteboardText; 
    }

    /// <summary>
    /// Display Library Information
    /// </summary>
    public void DisplayLibraryInfo()
    {
        informationGO.SetActive(!informationGO.activeSelf);
        informationText.text = libraryText;
    }

    /// <summary>
    /// Display Cube Information
    /// </summary>
    public void DisplayCubeInfo()
    {
        informationGO.SetActive(!informationGO.activeSelf);
        informationText.text = cubeText;
    }

    /// <summary>
    /// Display Cantina Information
    /// </summary>
    public void DisplayCantinaInfo()
    {
        informationGO.SetActive(!informationGO.activeSelf);
        informationText.text = cantinaText;
    }

    /// <summary>
    /// Display Mezzanine Information 1
    /// </summary>
    public void DisplayMezzanineInfo1()
    {
        informationGO.SetActive(!informationGO.activeSelf);
        informationText.text = mezzanineText1;
    }

    /// <summary>
    /// Display Mezzanine Information 2
    /// </summary>
    public void DisplayMezzanineInfo2()
    {
        informationGO.SetActive(!informationGO.activeSelf);
        informationText.text = mezzanineText2;
    }


}
