using UnityEngine;
#if UNITY_ADS
using UnityEngine.Advertisements;
#endif

public class UnityAdsExample : MonoBehaviour
{
    void Start()
    {
#if UNITY_ADS
        Advertisement.Initialize("1344773", true);
        
        StartCoroutine(ShowAdWhenReady());
#endif
    }

#if UNITY_ADS
    System.Collections.IEnumerator ShowAdWhenReady()
    {
        while (!Advertisement.IsReady())
            yield return null;

        Advertisement.Show();
    }
#endif

}