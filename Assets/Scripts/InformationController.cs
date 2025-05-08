using UnityEngine;
using TMPro;

public class InformationController : MonoBehaviour
{
    /// <summary>
    /// Game object to display informations for whiteboard
    /// </summary>
    public GameObject whiteboardText;

    /// <summary>
    /// Game object to display informations for Library
    /// </summary>
    public GameObject libraryText;

    /// <summary>
    /// Game object to display informations for cube
    /// </summary>
    public GameObject cubeText;

    /// <summary>
    /// Game object to display informations for cantina
    /// </summary>
    public GameObject cantinaText;

    /// <summary>
    /// Game object to display informations for mezzanine 1
    /// </summary>
    public GameObject mezzanineText1;

    /// <summary>
    /// Game object to display informations for mezzanine 2
    /// </summary>
    public GameObject mezzanineText2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (whiteboardText.activeSelf) whiteboardText.SetActive(false);
        if (libraryText.activeSelf) libraryText.SetActive(false); 
        if (cubeText.activeSelf) cubeText.SetActive(false);
        if (cantinaText.activeSelf) cantinaText.SetActive(false);
        if (mezzanineText1.activeSelf) mezzanineText1.SetActive(false);
        if (mezzanineText2.activeSelf) mezzanineText2.SetActive(false);

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
        whiteboardText.SetActive(!whiteboardText.activeSelf);
    }

    /// <summary>
    /// Display Library Information
    /// </summary>
    public void DisplayLibraryInfo()
    {
        libraryText.SetActive(!libraryText.activeSelf);
    }

    /// <summary>
    /// Display Cube Information
    /// </summary>
    public void DisplayCubeInfo()
    {
        cubeText.SetActive(!cubeText.activeSelf);
    }

    /// <summary>
    /// Display Cantina Information
    /// </summary>
    public void DisplayCantinaInfo()
    {
        cantinaText.SetActive(!cantinaText.activeSelf);
    }

    /// <summary>
    /// Display Mezzanine Information 1
    /// </summary>
    public void DisplayMezzanineInfo1()
    {
        mezzanineText1.SetActive(!mezzanineText1.activeSelf);
    }

    /// <summary>
    /// Display Mezzanine Information 2
    /// </summary>
    public void DisplayMezzanineInfo2()
    {
        mezzanineText2.SetActive(!mezzanineText2.activeSelf);
    }


}
