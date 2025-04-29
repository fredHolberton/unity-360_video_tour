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

    public GameObject livingRoomGroup;
    public GameObject cantinaGroup;
    public GameObject cubeGroup;
    public GameObject mezzanineGroup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable the LivingRoom video and desable other
        ActivateLivingRoomVP();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateLivingRoomVP()
    {
        livingRoomVideoPlayer.enabled = true;
        cantinaVideoPlayer.enabled = false;
        cubeVideoPlayer.enabled = false;
        mezzanineVideoPlayer.enabled = false;

        if (!livingRoomGroup.activeSelf)
        {
            livingRoomGroup.SetActive(true);
        }
        if (cantinaGroup.activeSelf) 
        {
            cantinaGroup.SetActive(false);
        }
        if (cubeGroup.activeSelf) 
        {
            cubeGroup.SetActive(false);
        }
        if (mezzanineGroup.activeSelf) 
        {
            mezzanineGroup.SetActive(false);
        }
    }

    public void ActivateCantinaVP()
    {
        livingRoomVideoPlayer.enabled = false;
        cantinaVideoPlayer.enabled = true;
        cubeVideoPlayer.enabled = false;
        mezzanineVideoPlayer.enabled = false;

        if (livingRoomGroup.activeSelf) livingRoomGroup.SetActive(false);
        if (!cantinaGroup.activeSelf) cantinaGroup.SetActive(true);
        if (cubeGroup.activeSelf) cubeGroup.SetActive(false);
        if (mezzanineGroup.activeSelf) mezzanineGroup.SetActive(false);
    }

    public void ActivateCubeVP()
    {
        livingRoomVideoPlayer.enabled = false;
        cantinaVideoPlayer.enabled = false;
        cubeVideoPlayer.enabled = true;
        mezzanineVideoPlayer.enabled = false;

        if (livingRoomGroup.activeSelf) livingRoomGroup.SetActive(false);
        if (cantinaGroup.activeSelf) cantinaGroup.SetActive(false);
        if (!cubeGroup.activeSelf) cubeGroup.SetActive(true);
        if (mezzanineGroup.activeSelf) mezzanineGroup.SetActive(false);
    }

    public void ActivateMezzanineVP()
    {
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
