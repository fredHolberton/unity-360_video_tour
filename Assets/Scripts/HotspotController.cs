using System.Data.Common;
using UnityEngine;
using UnityEngine.Video;

public class HotspotController : MonoBehaviour
{
    
    /// <summary>
    /// Video Player for playing LivingRoom video
    /// </summary>
    public VideoPlayer livingRoomVideoPlayer;

    /// <summary>
    /// Video Player for playing Cantina video
    /// </summary>
    public VideoPlayer cantinaVideoPlayer;

    /// <summary>
    /// Video Player for playing Cube video
    /// </summary>
    public VideoPlayer cubeVideoPlayer;

    /// <summary>
    /// Video Player for playing Mezzanine video
    /// </summary>
    public VideoPlayer mezzanineVideoPlayer;

    /// <summary>
    /// group of Hotspots in the Living room
    /// </summary>
    public GameObject livingRoomGroup;
    
    /// <summary>
    /// group of Hotspots in the Cantina
    /// </summary>
    public GameObject cantinaGroup;
    
    /// <summary>
    /// group of Hotspots in the Cube
    /// </summary>
    public GameObject cubeGroup;
    
    /// <summary>
    /// group of Hotspots in the Mezzanine
    /// </summary>
    public GameObject mezzanineGroup;

    /* Animator for transition between two rooms */ 
    private Animator transition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Init of GameObjects in the scene
        transition = GetComponent<Animator>();

        // Enable the LivingRoom video and desable other
        ActivateLivingRoomVP(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Activate Livingroom video and desactivate other
    /// </summary>
    /// <param name="trans"></param>
    public void ActivateLivingRoomVP(bool trans = true)
    {
        if (trans) transition.SetTrigger("MakeTransition");

        livingRoomVideoPlayer.enabled = true;
        cantinaVideoPlayer.enabled = false;
        cubeVideoPlayer.enabled = false;
        mezzanineVideoPlayer.enabled = false;

        if (!livingRoomGroup.activeSelf) livingRoomGroup.SetActive(true);
        if (cantinaGroup.activeSelf) cantinaGroup.SetActive(false);
        if (cubeGroup.activeSelf) cubeGroup.SetActive(false);
        if (mezzanineGroup.activeSelf) mezzanineGroup.SetActive(false);
    }

    /// <summary>
    /// Activate Cantina video and desactivate other
    /// </summary>
    public void ActivateCantinaVP()
    {
        transition.SetTrigger("MakeTransition");

        livingRoomVideoPlayer.enabled = false;
        cantinaVideoPlayer.enabled = true;
        cubeVideoPlayer.enabled = false;
        mezzanineVideoPlayer.enabled = false;

        if (livingRoomGroup.activeSelf) livingRoomGroup.SetActive(false);
        if (!cantinaGroup.activeSelf) cantinaGroup.SetActive(true);
        if (cubeGroup.activeSelf) cubeGroup.SetActive(false);
        if (mezzanineGroup.activeSelf) mezzanineGroup.SetActive(false);
    }

    /// <summary>
    /// Activate Cube video and desactivate other
    /// </summary>
    public void ActivateCubeVP()
    {
        transition.SetTrigger("MakeTransition");

        livingRoomVideoPlayer.enabled = false;
        cantinaVideoPlayer.enabled = false;
        cubeVideoPlayer.enabled = true;
        mezzanineVideoPlayer.enabled = false;

        if (livingRoomGroup.activeSelf) livingRoomGroup.SetActive(false);
        if (cantinaGroup.activeSelf) cantinaGroup.SetActive(false);
        if (!cubeGroup.activeSelf) cubeGroup.SetActive(true);
        if (mezzanineGroup.activeSelf) mezzanineGroup.SetActive(false);
    }

    /// <summary>
    /// Activate Mezzanine video and desactivate other
    /// </summary>
    public void ActivateMezzanineVP()
    {
        transition.SetTrigger("MakeTransition");
        
        livingRoomVideoPlayer.enabled = false;
        cantinaVideoPlayer.enabled = false;
        cubeVideoPlayer.enabled = false;
        mezzanineVideoPlayer.enabled = true;

        if (livingRoomGroup.activeSelf) livingRoomGroup.SetActive(false);
        if (cantinaGroup.activeSelf) cantinaGroup.SetActive(false);
        if (cubeGroup.activeSelf) cubeGroup.SetActive(false);
        if (!mezzanineGroup.activeSelf) mezzanineGroup.SetActive(true);
    }


}
