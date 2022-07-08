using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SteamErrorManager : MonoBehaviour
{
    public static SteamErrorManager Instance;
    
    [SerializeField] private GameObject _steamErrorPannel;
    [SerializeField] private Button _reloadButton;
    
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _reloadButton.onClick.AddListener(OnClickReload);
    }

    public void EnableSteamErrorPannel(bool value)
    {
        _steamErrorPannel.SetActive(value);
    }

    private void OnClickReload()
    {
        EnableSteamErrorPannel(false);

        GameObject steamManagerObj = FindObjectOfType<SteamManager>().gameObject;
        Destroy(steamManagerObj);
        
        SceneManager.LoadScene(0);
    }
}
